using Orange_perron_chido.Clases;
using Orange_perron_chido.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            List<double> numbers = getNumbersList(elementsToAnalyse);
            correctOutliers(boxplot, numbers);
        }

        private void DataWatch_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int quantity = rnd.Next(1, elementsToAnalyse.Count);
            List<double> numeros = getNumbersList(elementsToAnalyse);
            int index;
            List<double> elements = new List<double> ();
            switch(optionsWatch.Text){
                case "Con reemplazo":
                    for(int i = 0; i < quantity; i++)
                    {
                        index = rnd.Next(0, elementsToAnalyse.Count);
                        elements.Add(numeros.ElementAt(index));
                    }
                    break;
                case "Sin reemplazo":
                    List<int> indices = new List<int>();
                    int aux;
                    for(int i = 0; i < quantity; i++)
                    {
                        aux = 0;
                        do
                        {
                            index = rnd.Next(0, elementsToAnalyse.Count);
                            aux = indices.Find((ei) => ei == index);
                            if (aux == 0) 
                            {
                                elements.Add(numeros.ElementAt(index));
                            }
                        } while (aux != 0);
                    }
                    break;
            }
        }
    }
}
