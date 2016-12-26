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
    }
}
