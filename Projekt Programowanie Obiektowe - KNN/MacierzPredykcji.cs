using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie_Obiektowe___KNN
{
    public class MacierzPredykcji
    {
        public Dictionary<int, double> Trafności = new Dictionary<int, double>();

        public Dictionary<int, List<int?>> Dane = new Dictionary<int, List<int?>>();

        public void LiczTrafności()
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

    }
}
