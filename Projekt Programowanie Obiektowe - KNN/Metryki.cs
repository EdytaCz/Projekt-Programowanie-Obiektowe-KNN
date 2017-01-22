using System;
using System.Collections.Generic;
using System.Linq;

namespace Projekt_Programowanie_Obiektowe___KNN
{
    public class Metryki
    {
        public static double Manhattan(ObiektDecyzyjny treningowy, ObiektDecyzyjny testowy)
        {
            double suma = 0;
            for (int i = 0; i < testowy.Atrybuty.Count; i++)
            {
                suma += Math.Abs(Convert.ToDouble(testowy.Atrybuty[i] - treningowy.Atrybuty[i]));
            }
            return suma;
        }
        public static double Euklides(ObiektDecyzyjny treningowy, ObiektDecyzyjny testowy)
        {
            double suma = 0;
            for (int i = 0; i < testowy.Atrybuty.Count; i++)
            {
                suma += Math.Pow(Convert.ToDouble(testowy.Atrybuty[i] - treningowy.Atrybuty[i]), 2);
            }
            return Math.Sqrt(suma);
        }

        public static double Canberr(ObiektDecyzyjny treningowy, ObiektDecyzyjny testowy)
        {
            double suma = 0;
            for (int i = 0; i < testowy.Atrybuty.Count; i++)
            {
                double licznik = testowy.Atrybuty[i] - treningowy.Atrybuty[i];
                double mianownik = testowy.Atrybuty[i] + treningowy.Atrybuty[i];
                suma += Math.Abs(licznik / mianownik);
            }
            return suma;
        }

        public static double Czebyszew(ObiektDecyzyjny treningowy, ObiektDecyzyjny testowy)
        {
            var maxWynik = new List<double>();

            for (int i = 0; i < testowy.Atrybuty.Count; i++)
            {
                var suma = Math.Abs(Convert.ToDouble(testowy.Atrybuty[i] - treningowy.Atrybuty[i]));
                maxWynik.Add(suma);
            }
            return maxWynik.Max();
        }
        public static double Pearson(ObiektDecyzyjny treningowy, ObiektDecyzyjny testowy)
        {
            double testoweSrednia = 0;
            double treningoweSrednia = 0;
            double mianownikLewa = 0;
            double mianownikPrawa = 0;
            double r = 0;
            for (int i = 0; i < testowy.Atrybuty.Count; i++)
            {
                testoweSrednia += testowy.Atrybuty[i];
                treningoweSrednia += treningowy.Atrybuty[i];
            }
            testoweSrednia = testoweSrednia / testowy.Atrybuty.Count;
            treningoweSrednia = treningoweSrednia / testowy.Atrybuty.Count;

            for (int i = 0; i < testowy.Atrybuty.Count; i++)
            {
                mianownikLewa += Math.Pow(testowy.Atrybuty[i] - testoweSrednia, 2);
                mianownikPrawa += Math.Pow(treningowy.Atrybuty[i] - treningoweSrednia, 2);
            }
            mianownikLewa = mianownikLewa / testowy.Atrybuty.Count;
            mianownikPrawa = mianownikPrawa / testowy.Atrybuty.Count;
            for (int i = 0; i < testowy.Atrybuty.Count; i++)
            {
                r += (testowy.Atrybuty[i] - testoweSrednia) / Math.Sqrt(mianownikLewa) * ((treningowy.Atrybuty[i] - treningoweSrednia) / Math.Sqrt(mianownikPrawa));
            }
            r = r / testowy.Atrybuty.Count;
            return 1 - Math.Abs(r);
        }
    }
}
