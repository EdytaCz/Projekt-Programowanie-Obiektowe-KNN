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
    }
}
