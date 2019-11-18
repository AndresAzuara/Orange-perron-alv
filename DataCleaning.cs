using Orange_perron_chido.Clases;
using Orange_perron_chido.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orange_perron_chido
{
    public partial class DataCleaning : Form
    {
        List<string> valores;
        List<string> atributos;
        List<string> elementsToAnalyse;
        int columnIndex;
        BoxPlotElements boxplot;
        public DataCleaning(List<string> valores, List<string> atributos, List<string> elementsToAnalyse, int columnIndex, BoxPlotElements boxplot)
        {
            this.valores = valores;
            this.atributos = atributos;
            this.elementsToAnalyse = elementsToAnalyse;
            this.columnIndex = columnIndex;
            this.boxplot = boxplot;
            InitializeComponent();
            makeGrid();
            optionsWatch.Items.Add("Con reemplazo");
            optionsWatch.Items.Add("Sin reemplazo");
            transformacionValores.Items.Add("Min - Max");
            transformacionValores.Items.Add("Z-score Desviacion Estandar");
            transformacionValores.Items.Add("Z-score Desviacion Media Absoluta");
        }

        private void insertarHeader()
        {
            int columnas = 0;
            tablaPrincipal.ColumnCount = atributos.Count + 1;
            tablaPrincipal.Columns[columnas++].Name = "ID";
            foreach (var atributo in atributos)
            {
                tablaPrincipal.Columns[columnas++].Name = atributo;
            }
        }

        private void insertarInformacion()
        {
            int id = 1;
            int actual = 0;
            bool completo = true;
            do
            {
                ArrayList row = new ArrayList();
                if (actual == valores.Count)
                {
                    completo = false;
                    break;
                }
                row.Add(id++);
                for (int i = 0; i < atributos.Count; i++)
                {
                    row.Add(valores.ElementAt(actual++));
                }
                tablaPrincipal.Rows.Add(row.ToArray());
            } while (completo);
        }

        private void makeGrid()
        {
            insertarHeader();
            insertarInformacion();
        }

        private void tablaPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            checarValoresFaltantes();
        }

        private bool elementIsNumeric(List<string> elements)
        {
            double number;
            foreach (var element in elements)
            {
                if (double.TryParse(element, out number))
                {
                    return true;
                }
            }
            return false;
        }

        private List<double> getNumbersList(List<string> elements)
        {
            List<double> numbers = new List<double>();
            double number;
            foreach (var element in elements)
            {
                if (!element.Equals(""))
                {
                    double.TryParse(element, out number);
                    numbers.Add(number);
                }

            }
            return numbers;
        }

        private void correctOutliers(BoxPlotElements boxplot, List<double> numbers)
        {
            double diferencia = (boxplot.max - boxplot.q3) - (boxplot.q1 - boxplot.min);
            double newValue;
            if (diferencia == 0)
            {
                newValue = boxplot.avg;
            }
            else
            {
                newValue = boxplot.med;
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.ElementAt(i) > boxplot.max || numbers.ElementAt(i) < boxplot.min)
                {
                    numbers[i] = newValue;
                    tablaPrincipal.Rows[i].Cells[columnIndex].Value = newValue;
                }
            }
            tablaPrincipal.Refresh();
        }

        private void checarValoresFaltantes()
        {
            double mediana;
            double moda;
            string titulo = "Corrección de valor";
            for (int i = 0; i < elementsToAnalyse.Count; i++)
            {
                if (elementsToAnalyse.ElementAt(i).Equals(""))
                {
                    if (elementIsNumeric(elementsToAnalyse))
                    {
                        Stadistic.getModeAndMedian(getNumbersList(elementsToAnalyse), out moda, out mediana);
                        int value = Prompt.ShowDialog(moda.ToString(), mediana.ToString(), titulo);
                        switch (value)
                        {
                            case 1:
                                elementsToAnalyse[i] = moda.ToString();
                                break;
                            case 2:
                                elementsToAnalyse[i] = mediana.ToString();
                                break;
                        }
                    }
                    else
                    {
                        var mode = Stadistic.getCategoricalMode(elementsToAnalyse);
                        elementsToAnalyse[i] = mode;
                    }
                }
            }
            for(int i = 0; i < elementsToAnalyse.Count; i++)
            {
                tablaPrincipal.Rows[i].Cells[columnIndex].Value = elementsToAnalyse.ElementAt(i);
            }
            tablaPrincipal.Refresh();
        }

        private void corregirOutliers_Click(object sender, EventArgs e)
        {
            if (elementIsNumeric(elementsToAnalyse))
            {
                List<double> numbers = getNumbersList(elementsToAnalyse);
                correctOutliers(boxplot, numbers);
            }
        }

        private void getNewMinAndMax()
        {
            var minAndMax = getActualMinAndMax();
            double actualMin = minAndMax.Item1;
            double actualMax = minAndMax.Item2;
            List<double> numbers = getNumbersList(elementsToAnalyse);
            double number = 0;
            if (elementIsNumeric(elementsToAnalyse))
            {
                for(int i = 0; i < numbers.Count; i++)
                {
                    number = numbers.ElementAt(i);
                    if (!elementsToAnalyse.ElementAt(i).Equals(null))
                    {
                        number = (number - actualMin) / (actualMax - actualMin);
                        number *= (1 - 0) + 0;
                        numbers[i] = number;
                        elementsToAnalyse[i] = numbers[i].ToString();
                    }
                }
                for (int y = 0; y < tablaPrincipal.Rows.Count - 1; y++)
                {
                    tablaPrincipal.Rows[y].Cells[columnIndex].Value = elementsToAnalyse[y];
                }
            }
        }

        private (double, double) getActualMinAndMax()
        {
            double minimo;
            double maximo;
            List<double> numeros = getNumbersList(elementsToAnalyse);
            numeros.Sort();
            minimo = numeros.Select(r => r).FirstOrDefault();
            maximo = numeros.Select(r => r).LastOrDefault();
            return (minimo, maximo);
        }

        private void writeToFile(string path, List<Object[]> data, List<string> columnNames)
        {
            int contador = 0;
            int contadorData = 0;
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            File.Create(path).Dispose();
            using (StreamWriter w = File.AppendText(path))
            {
                Console.WriteLine("header");
                foreach (var column in columnNames)
                {
                    Console.WriteLine(column);
                    w.Write(column);
                    if (++contador != columnNames.Count)
                    {
                        w.Write(",");
                    }
                    else
                    {
                        w.WriteLine("");
                    }
                }
                contador = 0;
                Console.WriteLine("elementos");
                data.RemoveAt(data.Count - 1);
                foreach (var el in data)
                {
                    foreach (var ele in el)
                    {
                        w.Write(ele);
                        if (++contadorData != el.Length)
                        {
                            w.Write(",");
                        }
                        else if (++contador != data.Count)
                        {
                            w.WriteLine("");
                        }
                    }
                    contadorData = 0;
                }
                w.Close();
            }
        }

        private void DataWatch_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int quantity = rnd.Next(1, elementsToAnalyse.Count);
            List<double> numeros = getNumbersList(elementsToAnalyse);
            int index;
            List<Object[]> elements = new List<Object[]>();
            Object[] auxArray;
            int o = 0;
            switch (optionsWatch.Text)
            {
                case "Con reemplazo":
                    for (int i = 0; i < quantity; i++)
                    {
                        index = rnd.Next(0, (valores.Count / atributos.Count));
                        index *= atributos.Count;
                        auxArray = new Object[atributos.Count];
                        for (int y = index; y < index + 4; y++)
                        {
                            auxArray[o++] = valores.ElementAt(y);
                        }
                        elements.Add(auxArray);
                        auxArray = null;
                        o = 0;
                    }
                    break;
                case "Sin reemplazo":
                    List<int> indices = new List<int>();
                    int aux;
                    for (int i = 0; i < quantity; i++)
                    {
                        do
                        {
                            index = rnd.Next(0, (valores.Count / atributos.Count));
                            index *= atributos.Count;
                            foreach (var num in indices)
                            {
                                if (index.Equals(num))
                                {
                                    index = -1;
                                }
                            }
                        } while (index == -1);
                        indices.Add(index);
                        auxArray = new Object[atributos.Count];
                        for (int y = index; y < index + 4; y++)
                        {
                            auxArray[o++] = valores.ElementAt(y);
                        }
                        elements.Add(auxArray);
                        auxArray = null;
                        o = 0;
                    }
                    break;
            }
                        string path = string.Format(@"C:\Users\pepti\source\repos\Orange-perron-alv\Files\{0}.csv", muestreoNombreArchivo.Text);
                        writeToFile(path, elements, atributos);
        }

        private void getZScoreStandarDesviation()
        {
            List<double> numbers = getNumbersList(elementsToAnalyse);
            double average = Stadistic.getAverage(numbers);
            double standarDesviation = Stadistic.getStandarDesviation(numbers);
            for(int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = (numbers[i] - average) / standarDesviation;
                tablaPrincipal.Rows[i].Cells[columnIndex].Value = numbers[i].ToString();
            }
        }

        private void getZScoreAbsolute()
        {
            List<double> numbers = getNumbersList(elementsToAnalyse);
            double average = Stadistic.getAverage(numbers);
            double absoluteMeanDesviation = Stadistic.getAbsoluteMeanDesviation(numbers);
            for(int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = (numbers[i] - average) / absoluteMeanDesviation;
                tablaPrincipal.Rows[i].Cells[columnIndex].Value = numbers[i].ToString();
            }
        }

        private void transformatValor_Click(object sender, EventArgs e)
        {
            switch (transformacionValores.Text)
            {
                case "Min - Max":
                    getNewMinAndMax();
                    break;
                case "Z-score Desviacion Estandar":
                    getZScoreStandarDesviation();
                    break;
                case "Z-score Desviacion Media Absoluta":
                    getZScoreAbsolute();
                    break;
            }
        }
    } 
        }
