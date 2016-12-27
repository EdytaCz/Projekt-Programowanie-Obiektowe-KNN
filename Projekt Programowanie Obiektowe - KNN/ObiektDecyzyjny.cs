using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie_Obiektowe___KNN
{
    public class ObiektDecyzyjny
    {
        public ObiektDecyzyjny(int[] argumenty)
        {
            atrybuty = argumenty.Take(argumenty.Length - 1).ToList();
            klasaDecyzyjna = argumenty.Last();
        }
        public List<int> atrybuty;
        public int klasaDecyzyjna { get; set; }

        public List<WartośćMetrykiDlaObiektu> metryki = new List<WartośćMetrykiDlaObiektu>();

        public Dictionary<int, List<WartośćMetrykiDlaObiektu>> klasy = new Dictionary<int, List<WartośćMetrykiDlaObiektu>>();
        public Dictionary<int, double> SumyWartościSąsiadów = new Dictionary<int, double>();
        public void DzielISortuj()
        {
            foreach (var metryka in metryki)
            {
                bool czyIstniejeSłownik = klasy.ContainsKey(metryka.Klasa);
                if (!czyIstniejeSłownik)
                {
                    klasy.Add(metryka.Klasa, new List<WartośćMetrykiDlaObiektu>());
                    klasy[metryka.Klasa].Add(metryka);
                }
                else
                {
                    klasy[metryka.Klasa].Add(metryka);
                }
            }
            foreach (var klucz in klasy.Keys)
            {
                klasy[klucz].Sort((x, y) => x.WartośćMetryki.CompareTo(y.WartośćMetryki));
            }
        }
        public void Klasyfikuj(int ilośćSąsiadów)
        {
            foreach (var klasa in klasy)
            {
                double suma = 0;
                for (int i = 0; i < ilośćSąsiadów; i++)
                {
                    suma += klasa.Value[i].WartośćMetryki;
                }
                SumyWartościSąsiadów.Add(klasa.Key, suma);
            }

        }
    }
}
