using System.Collections.Generic;
using System.Linq;

namespace Projekt_Programowanie_Obiektowe___KNN
{
    public class MacierzPredykcji
    {
        public Dictionary<int, List<int?>> Dane = new Dictionary<int, List<int?>>();

        public Dictionary<int, double> Trafnosci = new Dictionary<int, double>();
        public Dictionary<int, double> Pokrycia = new Dictionary<int, double>();
        public Dictionary<int, double> StosunekiPrawdziwychPozytywnych = new Dictionary<int, double>();
        public double TrafnoscGlobalna { get; set; }
        public double PokrycieGlobalne { get; set; }
        public void LiczTrafnosciAcc()
        {
            foreach (var dana in Dane)
            {
                double trafnoscLicznik = dana.Value.Count(x => x.HasValue && x.Value == dana.Key);
                double trafnoscMianownik = dana.Value.Count(x => x.HasValue);
                var trafnosc = trafnoscLicznik / trafnoscMianownik;
                Trafnosci[dana.Key] = trafnosc;
            }
        }

        public void LiczPokryciaCov()
        {
            foreach (var dana in Dane)
            {
                double pokrycieLicznik = 0;
                double pokrycieMianownik = dana.Value.Count;
                pokrycieLicznik += dana.Value.Count(x => x.HasValue);
                var pokrycie = pokrycieLicznik / pokrycieMianownik;
                Pokrycia[dana.Key] = pokrycie;
            }
        }
        public void LiczStosunekTpr()
        {
            foreach (var dana in Dane)
            {
                double stosunekLicznik = dana.Value.Count(x => x.HasValue && x.Value == dana.Key);
                var stosunekMianownik = stosunekLicznik;
                foreach (var dana2 in Dane)
                {
                    if (dana2.Key != dana.Key)
                    {
                        stosunekMianownik += dana2.Value.Count(x => x.HasValue && x.Value == dana.Key);
                    }
                }
                var stosunek = stosunekLicznik / stosunekMianownik;
                StosunekiPrawdziwychPozytywnych[dana.Key] = stosunek;
            }
        }
        public void LiczTrafnoscGlobalna()
        {
            double globalnaLicznik = 0;
            double globalnaMianownik = 0;
            foreach (var dana in Dane)
            {
                globalnaLicznik += dana.Value.Count(x => x.HasValue && x.Value == dana.Key);
                globalnaMianownik += dana.Value.Count(x => x.HasValue);
            }
            TrafnoscGlobalna = globalnaLicznik / globalnaMianownik; ;
        }

        public void LiczPokrycieGlobalne()
        {
            double globalnaLicznik = 0;
            double globalnaMianownik = 0;
            foreach (var dana in Dane)
            {
                globalnaLicznik += dana.Value.Count(x => x.HasValue);
                globalnaMianownik += dana.Value.Count;
            }
            PokrycieGlobalne = globalnaLicznik / globalnaMianownik;
        }

        public string WypiszWyniki()
        {
            string wynik = "\t\t";
            var doWyswietlenia = Dane.OrderBy(x => x.Key);
            var tprDoWyswietlenia = StosunekiPrawdziwychPozytywnych.OrderBy(x => x.Key);
            foreach (var dana in doWyswietlenia)
            {
                wynik += "\t" + dana.Key;
            }
            wynik += "\tLiczba obiektów";
            wynik += "\tAcc";
            wynik += "\tCov";
            foreach (var wiersz in doWyswietlenia)
            {
                wynik += "\n";
                wynik += "\t\t" + wiersz.Key + "\t";
                foreach (var dana in doWyswietlenia)
                {
                    wynik += $"{wiersz.Value.Count(x => x.HasValue && x.Value == dana.Key):0.#}" + "\t";

                }
                wynik += "\t" + Dane.Values.Count;
                wynik += "\t" + $"{Trafnosci.FirstOrDefault(x => x.Key == wiersz.Key).Value:0.#}";
                wynik += "\t" + $"{Pokrycia.FirstOrDefault(x => x.Key == wiersz.Key).Value:0.#}";
            }
            wynik += "\nTrue Positive Rate\t\t";
            foreach (var stosunek in tprDoWyswietlenia)
            {
                wynik += $"{stosunek.Value:0.#}" + "\t";
            }
            wynik += "\nGlobal Cov\t" + $"{PokrycieGlobalne:0.##}";
            wynik += "\nGlobal Acc\t" + $"{TrafnoscGlobalna:0.##}";
            return wynik;
        }
    }
}
