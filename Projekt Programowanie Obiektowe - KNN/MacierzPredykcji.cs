using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie_Obiektowe___KNN
{
    public class MacierzPredykcji
    {
        public Dictionary<int, List<int?>> Dane = new Dictionary<int, List<int?>>();

        public Dictionary<int, double> Trafności = new Dictionary<int, double>();
        public Dictionary<int, double> Pokrycia = new Dictionary<int, double>();
        public Dictionary<int, double> StosunekiPrawdziwychPozytywnych = new Dictionary<int, double>();
        public double TrafnośćGlobalna { get; set; }
        public double PokrycieGlobalne { get; set; }
        public void LiczTrafnościAcc()
        {
            double trafność;
            double trafnośćLicznik;
            double trafnośćMianownik;
            foreach (var dana in Dane)
            {
                trafnośćLicznik = dana.Value.Count(x => x.HasValue && x.Value == dana.Key);
                trafnośćMianownik = dana.Value.Count(x => x.HasValue);
                trafność = trafnośćLicznik / trafnośćMianownik;
                Trafności[dana.Key] = trafność;
            }
        }

        public void LiczPokryciaCov()
        {
            double pokrycie;
            double pokrycieLicznik;
            double pokrycieMianownik;
            foreach (var dana in Dane)
            {
                pokrycieLicznik = 0;
                pokrycieMianownik = dana.Value.Count;
                foreach (var dana2 in Dane)
                {
                    pokrycieLicznik += dana2.Value.Count(x => x.HasValue && x.Value == dana.Key);
                }
                pokrycie = pokrycieLicznik / pokrycieMianownik;
                Pokrycia.Add(dana.Key, pokrycie);
            }
        }
        public void LiczStosunekTPR()
        {
            double stosunek;
            double stosunekLicznik;
            double stosunekMianownik;
            foreach (var dana in Dane)
            {
                stosunekLicznik = dana.Value.Count(x => x.HasValue && x.Value == dana.Key);
                stosunekMianownik = stosunekLicznik;
                foreach (var dana2 in Dane)
                {
                    if (dana2.Key != dana.Key)
                    {
                        stosunekMianownik += dana2.Value.Count(x => x.HasValue && x.Value == dana.Key);
                    }
                }
                stosunek = stosunekLicznik / stosunekMianownik;
                StosunekiPrawdziwychPozytywnych.Add(dana.Key, stosunek);
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
            TrafnośćGlobalna = globalnaLicznik / globalnaMianownik; ;
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
    }
}
