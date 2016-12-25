using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie_Obiektowe___KNN
{
    class KNN
    {
        public int[][] daneTestoweWejściowe { get; set; }
        public int[][] daneTreningoweWejściowe { get; set; }

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
    }
}
