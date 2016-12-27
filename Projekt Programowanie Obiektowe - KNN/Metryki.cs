using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie_Obiektowe___KNN
{
    public class Metryki
    {
        public static double Manhattan(ObiektDecyzyjny treningowy, ObiektDecyzyjny testowy)
        {
            double suma = 0;
            for (int i = 0; i < testowy.atrybuty.Count; i++)
            {
                suma += Math.Abs(Convert.ToDouble(testowy.atrybuty[i] - treningowy.atrybuty[i]));
            }
            return suma;
        }
        public static double Euklides(ObiektDecyzyjny treningowy, ObiektDecyzyjny testowy)
        {
            double suma = 0;
            for (int i = 0; i < testowy.atrybuty.Count; i++)
            {
                suma += Math.Pow(Convert.ToDouble(testowy.atrybuty[i] - treningowy.atrybuty[i]), 2);
            }
            return Math.Sqrt(suma);
        }

        public static double Canberr(ObiektDecyzyjny treningowy, ObiektDecyzyjny testowy)
        {
            double suma = 0;
            for (int i = 0; i < testowy.atrybuty.Count; i++)
            {
                suma += Math.Abs(Convert.ToDouble((
                    testowy.atrybuty[i] - treningowy.atrybuty[i]) / (testowy.atrybuty[i] + treningowy.atrybuty[i])));
            }
            return suma;
        }

        public static double Czebyszew(ObiektDecyzyjny treningowy, ObiektDecyzyjny testowy)
        {
            double suma = 0;
            List<double> MaxWynik = new List<double>();

            for (int i = 0; i < testowy.atrybuty.Count; i++)
            {
                suma = Math.Abs(Convert.ToDouble(testowy.atrybuty[i] - treningowy.atrybuty[i]));
                MaxWynik.Add(suma);
            }
            return MaxWynik.Max();
        }
    }
}
