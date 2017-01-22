using System.Collections.Generic;
using System.Linq;

namespace Projekt_Programowanie_Obiektowe___KNN
{
    public class ObiektDecyzyjny
    {
        public ObiektDecyzyjny(int[] argumenty)
        {
            Atrybuty = argumenty.Take(argumenty.Length - 1).ToList();
            KlasaDecyzyjna = argumenty.Last();
        }
        
        public List<int> Atrybuty;
        public int KlasaDecyzyjna { get; set; }

        public List<WartośćMetrykiDlaObiektu> Metryki = new List<WartośćMetrykiDlaObiektu>();

        public Dictionary<int, List<WartośćMetrykiDlaObiektu>> Klasy = new Dictionary<int, List<WartośćMetrykiDlaObiektu>>();
        public Dictionary<int, double> SumyWartościSąsiadów = new Dictionary<int, double>();
        public int? SklasyfikowanyDoKlasy { get; set; }
        public void DzielISortuj()
        {
            foreach (var metryka in Metryki)
            {
                bool czyIstniejeSłownik = Klasy.ContainsKey(metryka.Klasa);
                if (!czyIstniejeSłownik)
                {
                    Klasy.Add(metryka.Klasa, new List<WartośćMetrykiDlaObiektu>());
                    Klasy[metryka.Klasa].Add(metryka);
                }
                else
                {
                    Klasy[metryka.Klasa].Add(metryka);
                }
            }
            foreach (var klucz in Klasy.Keys)
            {
                Klasy[klucz].Sort((x, y) => x.WartośćMetryki.CompareTo(y.WartośćMetryki));
            }
        }
        public void Klasyfikuj(int ilośćSąsiadów)
        {
            foreach (var klasa in Klasy)
            {
                double suma = 0;
                for (int i = 0; i < ilośćSąsiadów; i++)
                {
                    suma += klasa.Value[i].WartośćMetryki;
                }
                SumyWartościSąsiadów[klasa.Key] = suma;
            }
            PorównajKlasyfikacje();
        }
        private void PorównajKlasyfikacje()
        {
            var najmniejsza = 0;

            var czyŁapie = !SumyWartościSąsiadów.Values.All(x => x.Equals(SumyWartościSąsiadów.Values.FirstOrDefault()));

            if (czyŁapie)
            {
                foreach (var suma in SumyWartościSąsiadów)
                {
                    foreach (var suma2 in SumyWartościSąsiadów)
                    {
                        if (suma.Value < suma2.Value)
                        {
                            najmniejsza = suma.Key;
                        }
                    }
                }
                SklasyfikowanyDoKlasy = najmniejsza;
            }
        }

    }
}
