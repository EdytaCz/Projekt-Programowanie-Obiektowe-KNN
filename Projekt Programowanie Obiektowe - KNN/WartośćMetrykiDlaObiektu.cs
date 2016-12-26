using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie_Obiektowe___KNN
{
    public class WartośćMetrykiDlaObiektu
    {
        public WartośćMetrykiDlaObiektu(double wartość, int indeks, int klasa)
        {
            IndeksObiektu = indeks;
            WartośćMetryki = wartość;
            Klasa = klasa;
        }
        public int IndeksObiektu { get; set; }
        public double WartośćMetryki { get; set; }
        public int Klasa { get; set; }
    }
}
