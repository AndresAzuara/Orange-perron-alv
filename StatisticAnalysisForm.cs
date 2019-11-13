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
using System.Windows.Forms.DataVisualization.Charting;
using Orange_perron_chido.Clases;
using Orange_perron_chido.DTO;

namespace Orange_perron_chido
{
    public partial class StatisticAnalysisForm : Form
    {
        List<string> elementsToAnalyse;
        Form1 _anterior;
        public StatisticAnalysisForm(List<string> data, string columnName, Form1 anterior)
        {
            _anterior = anterior;
            elementsToAnalyse = data;
            InitializeComponent();
            if (isNumber().Item1)
            {
                Mode.Text = "Moda";
                Median.Text = "Mediana";
                Average.Text = "Promedio";
                StandarDesviation.Text = "Desviación Estandar";
                Frecuencias.Visible = false;
                boxPlot.Visible = true;
                makeNumericalAnalyse(isNumber().Item2, columnName);
            }
            else
            {
                Mode.Text = "";
                ValueMode.Text = "";
                Median.Text = "";
                ValueMedian.Text = "";
                Average.Text = "";
                ValueAverage.Text = "";
                StandarDesviation.Text = "";
                ValueStandarDesviation.Text = "";
                boxPlot.Visible = false;
                Frecuencias.Visible = true;
                makeCategoricalAnalyse(data);
            }
        }

        private void makeCategoricalAnalyse(List<string> data)
        {
            var valueAndQuantity = (from element in data
                                   group element by element into elements
                                   select new ValueAndQuantityDTO
                                   {
                                       Value = elements.Key,
                                       quantity = elements.Count()
                                   }).ToList();
            cargarColumnas(valueAndQuantity);
            cargarInformacion(valueAndQuantity);
        }
        private void cargarColumnas(List<ValueAndQuantityDTO> data)
        {
            int columnas = 0;
            Frecuencias.ColumnCount = data.Count;
            foreach(var elemento in data)
            {
                Frecuencias.Columns[columnas++].Name = elemento.Value;
            }
        }

        private void cargarInformacion(List<ValueAndQuantityDTO> data)
        {
            ArrayList row = new ArrayList();
            foreach(var elemento in data)
            {
                row.Add(elemento.quantity);
            }
            Frecuencias.Rows.Add(row.ToArray());
        }
        private void makeNumericalAnalyse(List<double> elements, string columnName)
        {
            double mode;
            double median;
            double average = getAverage(elements);
            Object x = 0;
            int i = 0;
            double[] valores = new double[6];
            Stadistic.getModeAndMedian(elements, out mode, out median);
            double standarDesviation = getStandarDesviation(elements, average);
            ValueMedian.Text = median.ToString();
            ValueMode.Text = mode.ToString();
            ValueAverage.Text = average.ToString();
            ValueStandarDesviation.Text = standarDesviation.ToString();
            elements.Sort();
            var quartile1 = getFirstQuartile(elements);
            var quartile3 = getLastQuartile(elements);
            var interquartileRange = Stadistic.getInterquartileRange(quartile3, quartile1);
            valores[0] = Stadistic.getBoxPlotMin(quartile1, interquartileRange); //Minimo
            valores[1] = Stadistic.getBoxPlotMax(quartile3, interquartileRange); //Maximo
            valores[2] = quartile1; //Quartile 1
            valores[3] = quartile3; // Quartile 3
            valores[4] = average; // media
            valores[5] = median; //mediana
            Series s = boxPlot.Series.Add(columnName);
            s.ChartType = SeriesChartType.BoxPlot;
            s.Points.Add(valores);
            DrawAnnotation("Mínimo - ", 0, columnName, valores);
            DrawAnnotation("Máximo - ", 1, columnName, valores);
            DrawAnnotation("Cuartil 1 - ", 2, columnName, valores);
            DrawAnnotation("Cuartil 2 - ", 3, columnName, valores);
        }

        private void DrawAnnotation(string text, int index, string columnName, double[] valores)
        {
            TextAnnotation textAnnotation = new TextAnnotation();
            textAnnotation.Text = text + valores[index].ToString();
            textAnnotation.AnchorDataPoint = boxPlot.Series[columnName].Points[0];
            textAnnotation.AnchorY = valores[index];
            boxPlot.Annotations.Add(textAnnotation);
        }

        private double getFirstQuartile(List<double> elements)
        {
            float value = 0;
            value = (elements.Count + 1) / 4;
            int round = (int)value;
            double deci = value - round;
            if ((value - Math.Floor(value)) == 0)
            {
                return elements.ElementAt(round) + deci * (elements.ElementAt(round + 1) - elements.ElementAt(round));
            }
            else
            {
                return elements.ElementAt((int)value);
            }
        }

        private double getLastQuartile(List<double> elements)
        {
            float value = 0;
            value = 3 * (elements.Count + 1) / 4;
            int round = (int)value;
            double deci = value - round;
            if ((value - Math.Floor(value)) == 0)
            {
                return elements.ElementAt(round) + deci * (elements.ElementAt(round + 1) - elements.ElementAt(round));
            }
            else
            {
                return elements.ElementAt((int)value);
            }
        }

        private int getStandarDesviation(List<double> numbers, double average)
        {
            double count = 0;
            foreach(var number in numbers)
            {
                count += (number - average) * (number - average);
            }
            Console.WriteLine(count);
            count /= numbers.Count - 1;
            return (int)Math.Sqrt(count);
        }

        private double getAverage(List<double> numbers)
        {
            double count = 0;
            foreach(var number in numbers)
            {
                count += number;
            }
            return count / numbers.Count;
        }

        private (bool, List<double>) isNumber()
        {
            bool isNumeric;
            List<double> numeros = new List<double>();
            double n;
            foreach (var element in elementsToAnalyse)
            {
                isNumeric = double.TryParse(element, out n);
                numeros.Add(n);
                if (!isNumeric)
                {
                    return (false, null);
                }
            }
            return (true, numeros);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            _anterior.ShowDialog();   
        }
    }
}
