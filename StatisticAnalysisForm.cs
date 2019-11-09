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
using Orange_perron_chido.DTO;

namespace Orange_perron_chido
{
    public partial class StatisticAnalysisForm : Form
    {
        List<string> elementsToAnalyse;
        public StatisticAnalysisForm(List<string> data, string columnName)
        {
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
        private void makeNumericalAnalyse(List<int> elements, string columnName)
        {
            int mode;
            int median;
            int average = getAverage(elements);
            Object x = 0;
            int i = 0;
            double[] valores = new double[6];
            List<int> descendingList = elements.OrderByDescending(p => p).ToList();
            getModeAndMedian(elements, out mode, out median);
            int standarDesviation = getStandarDesviation(elements, average);
            ValueMedian.Text = median.ToString();
            ValueMode.Text = mode.ToString();
            ValueAverage.Text = average.ToString();
            ValueStandarDesviation.Text = standarDesviation.ToString();
            elements.Sort();
            valores[0] = elements.FirstOrDefault(); //Minimo
            valores[1] = elements.LastOrDefault(); //Maximo
            valores[2] = getQuartile(elements); //Quartile 1
            valores[3] = getQuartile(descendingList); // Quartile 3
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

        private float getValue(List<int> elements, int max)
        {
            double value = 0;
            for(int i = 0; i < max; i++)
            {
                value += elements.ElementAt(i);
            }
            return (float)value;
        }

        private float getQuartile(List<int> elements)
        {
            float mitad = elements.Count / 2.0f;
            double value = 0;
            int RoundValue = (int)Math.Floor(mitad);
            if ((mitad - RoundValue) == 0)
            {
                value = getValue(elements, RoundValue - 1);
                return (float)value / (RoundValue - 1);
            }
            else
            {
                value = getValue(elements, RoundValue);
                return (float)value / RoundValue;
            }
        }

        private int getStandarDesviation(List<int> numbers, int average)
        {
            int count = 0;
            foreach(var number in numbers)
            {
                count += (number - average) * (number - average);
            }
            Console.WriteLine(count);
            count /= numbers.Count - 1;
            return (int)Math.Sqrt(count);
        }

        private void getModeAndMedian(List<int> numbers, out int mode, out int median)
        {
            numbers.Sort();
            float mitad = numbers.Count / 2;
            mode = numbers.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
            if(mitad - Math.Round(mitad, 0) == 0)
            {
                median = numbers.ElementAt((int)mitad - 1) + numbers.ElementAt((int)mitad + 1);
                median /= 2;
            }
            else
            {
                median = numbers.ElementAt((int)mitad);
            }
        }

        private int getAverage(List<int> numbers)
        {
            int count = 0;
            foreach(var number in numbers)
            {
                count += number;
            }
            return count / numbers.Count;
        }

        (bool, List<int>) isNumber()
        {
            bool isNumeric;
            List<int> numeros = new List<int>();
            int n;
            foreach (var element in elementsToAnalyse)
            {
                isNumeric = int.TryParse(element, out n);
                numeros.Add(n);
                if (!isNumeric)
                {
                    return (false, null);
                }
            }
            return (true, numeros);
        }
    }
}
