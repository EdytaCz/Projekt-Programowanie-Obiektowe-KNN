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
        public static double Pearson(ObiektDecyzyjny treningowy, ObiektDecyzyjny testowy)
        {
            double testoweSrednia = 0;
            double treningoweSrednia = 0;
            double mianownikLewa = 0;
            double mianownikPrawa = 0;
            double r = 0;
            for (int i = 0; i < testowy.atrybuty.Count; i++)
            {
                testoweSrednia += testowy.atrybuty[i];
                treningoweSrednia += treningowy.atrybuty[i];
            }
            testoweSrednia = testoweSrednia / testowy.atrybuty.Count;
            treningoweSrednia = treningoweSrednia / testowy.atrybuty.Count;

            for (int i = 0; i < testowy.atrybuty.Count; i++)
            {
                mianownikLewa += Math.Pow(testowy.atrybuty[i] - testoweSrednia, 2);
                mianownikPrawa += Math.Pow(treningowy.atrybuty[i] - treningoweSrednia, 2);
            }
            mianownikLewa = mianownikLewa / testowy.atrybuty.Count;
            mianownikPrawa = mianownikPrawa / testowy.atrybuty.Count;
            for (int i = 0; i < testowy.atrybuty.Count; i++)
            {
                r += (testowy.atrybuty[i] - testoweSrednia) / Math.Sqrt(mianownikLewa) * ((treningowy.atrybuty[i] - treningoweSrednia) / Math.Sqrt(mianownikPrawa));
            }
            r = r / testowy.atrybuty.Count;
            return 1 - Math.Abs(r);
        }
    }
}
