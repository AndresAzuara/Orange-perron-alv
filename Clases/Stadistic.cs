using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_perron_chido.Clases
{
    public static class Stadistic
    {
        public static void getModeAndMedian(List<double> numbers, out double mode, out double median)
        {
            numbers.Sort();
            double mitad = numbers.Count / 2.0;
            mode = numbers.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
            if (mitad - Math.Round(mitad, 0) == 0)
            {
                median = numbers.ElementAt((int)mitad - 1) + numbers.ElementAt((int)mitad + 1);
                median /= 2;
            }
            else
            {
                median = numbers.ElementAt((int)mitad);
            }
        }

        public static double getAverage(List<double> numbers)
        {
            double suma = 0;
            foreach(var number in numbers)
            {
                suma += number;
            }
            return suma / numbers.Count;
        }
        public static string getCategoricalMode(List<string> elements)
        {
            return elements.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
        }

        public static double getInterquartileRange(double q3, double q1)
        {
            return q3 - q1;
        }

        public static double getBoxPlotMax(double q3, double iqr)
        {
            return q3 + (1.5 * iqr);
        }

        public static double getBoxPlotMin(double q1, double iqr)
        {
            return q1 - (1.5 * iqr);
        }

        public static double getStandarDesviation(List<double> numbers)
        {
            double average = getAverage(numbers);
            double suma = 0;
            double aux = 0;
            foreach(var number in numbers)
            {
                aux = number - average;
                aux = Math.Pow(aux, 2);
                suma += aux;
            }
            suma = suma / (numbers.Count - 1);
            return Math.Sqrt(suma);
        }

        public static double getAbsoluteMeanDesviation(List<double> numbers)
        {
            double average = getAverage(numbers);
            double suma = 0;
            double aux = 0;
            foreach(var number in numbers)
            {
                aux = number - average;
                aux = Math.Abs(aux);
                suma += aux;
            }
            return suma / numbers.Count;
        }

    }
}
