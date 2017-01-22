using System.Collections.Generic;

namespace Projekt_Programowanie_Obiektowe___KNN
{
    public delegate double Metryka(ObiektDecyzyjny treningowy, ObiektDecyzyjny testowy);
    public class Knn
    {
        public int[][] DaneTestoweWejściowe { get; set; }
        public int[][] DaneTreningoweWejściowe { get; set; }
        public int IlośćSąsiadów { get; set; }

        public List<ObiektDecyzyjny> DaneTreningowe = new List<ObiektDecyzyjny>();
        public List<ObiektDecyzyjny> DaneTestowe = new List<ObiektDecyzyjny>();
        public MacierzPredykcji MacierzPredykcji = new MacierzPredykcji();
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
            for (int i = 0; i < DaneTestowe.Count; i++)
            {
                foreach (var treningowe in DaneTreningowe)
                {
                    DaneTestowe[i].Metryki.Add(
                        new WartośćMetrykiDlaObiektu(
                            metryka(treningowe, DaneTestowe[i]),
                            DaneTreningowe.IndexOf(treningowe),
                            treningowe.KlasaDecyzyjna
                        )
                    );
                }
            }
        }
        public void LiczDzielISortuj()
        {
            for (int i = 0; i < DaneTestowe.Count; i++)
            {
                DaneTestowe[i].DzielISortuj();
            }
        }

        public void KlasyfikujObiekty()
        {
            for (int i = 0; i < DaneTestowe.Count; i++)
            {
                DaneTestowe[i].Klasyfikuj(IlośćSąsiadów);
            }
        }
        Dictionary<int, List<int?>> SklasyfikowanePoprawnie = new Dictionary<int, List<int?>>();
        public void LiczMacierzPredykcji()
        {
            SklasyfikowanePoprawnie = new Dictionary<int, List<int?>>();
            foreach (var obiekt in DaneTestowe)
            {
                bool czyKluczJużIstnieje = !SklasyfikowanePoprawnie.ContainsKey(obiekt.KlasaDecyzyjna);
                if (czyKluczJużIstnieje)
                {
                    SklasyfikowanePoprawnie[obiekt.KlasaDecyzyjna] = new List<int?>();
                }
                SklasyfikowanePoprawnie[obiekt.KlasaDecyzyjna].Add(obiekt.SklasyfikowanyDoKlasy);
            }
            MacierzPredykcji.Dane = SklasyfikowanePoprawnie;
        }
    }
}
