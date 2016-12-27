using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie_Obiektowe___KNN
{
    public delegate double Metryka(ObiektDecyzyjny treningowy, ObiektDecyzyjny testowy);
    public class KNN
    {
        public int[][] daneTestoweWejściowe { get; set; }
        public int[][] daneTreningoweWejściowe { get; set; }
        public int IlośćSąsiadów { get; set; }

        public List<ObiektDecyzyjny> daneTreningowe = new List<ObiektDecyzyjny>();
        public List<ObiektDecyzyjny> daneTestowe = new List<ObiektDecyzyjny>();

        public string WyświetlenieSystemów(ref int[][] daneWejściowe)
        {
            string doWyświetlenia = string.Empty;
            if (daneWejściowe != null)
            {
                foreach (var linijka in daneWejściowe)
                {
                    foreach (var dana in linijka)
                    {
                        doWyświetlenia += dana.ToString() + " ";
                    }
                    doWyświetlenia += "\r\n";
                }

            }

            return doWyświetlenia;
        }

        public List<ObiektDecyzyjny> StwórzListęObiektów(int[][] dane)
        {
            var listaTymczasowa = new List<ObiektDecyzyjny>();
            foreach (var linijka in dane)
            {
                listaTymczasowa.Add(new ObiektDecyzyjny(linijka));
            }
            return listaTymczasowa;
        }

        public void LiczMetryki(Metryka metryka)
        {
            for (int i = 0; i < daneTestowe.Count; i++)
            {
                foreach (var treningowe in daneTreningowe)
                {
                    daneTestowe[i].metryki.Add(
                        new WartośćMetrykiDlaObiektu(
                            metryka(treningowe, daneTestowe[i]),
                            daneTreningowe.IndexOf(treningowe),
                            treningowe.klasaDecyzyjna
                        )
                    );
                }
            }
        }
        public void LiczDzielISortuj()
        {
            for (int i = 0; i < daneTestowe.Count; i++)
            {
                daneTestowe[i].DzielISortuj();
            }
        }
        public void SprawdźK()
        {
            var maxK = daneTestowe[0].klasy.FirstOrDefault().Value.Count();
            foreach (var obiektDecyzyjny in daneTestowe)
            {
                foreach (var klasa in obiektDecyzyjny.klasy)
                {
                    if (maxK > klasa.Value.Count)
                    {
                        maxK = klasa.Value.Count;
                    }
                }
            }
            if (IlośćSąsiadów > maxK)
            {
                IlośćSąsiadów = maxK;
            }
        }
    }
}
