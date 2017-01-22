using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Projekt_Programowanie_Obiektowe___KNN
{
    public partial class Form1 : Form
    {
        public Knn Knn = new Knn();
        public Form1()
        {
            InitializeComponent();
        }

        public int[][] WczytywanieZpliku(ref OpenFileDialog ofd)
        {
            int[][] daneZPliku = new int[][] { };
            var wynik = ofd.ShowDialog();
            if (wynik != DialogResult.OK)
            {
                return null;
            }
            if (wynik == DialogResult.OK)
            {
                string trescPliku = System.IO.File.ReadAllText(ofd.FileName);

                string[] poziomy = trescPliku.Split('\n');

                daneZPliku = new int[poziomy.Length][];

                for (int i = 0; i < poziomy.Length; i++)
                {
                    string poziom = poziomy[i].Trim();
                    string[] miejscaParkingowe = poziom.Split(' ');
                    daneZPliku[i] = new int[miejscaParkingowe.Length];
                    for (int j = 0; j < miejscaParkingowe.Length; j++)
                    {
                        daneZPliku[i][j] = int.Parse(miejscaParkingowe[j]);
                    }
                }
            }
            return daneZPliku;
        }

        private void btnWczytajTreningowe_Click(object sender, EventArgs e)
        {
            btnLicz.Enabled = false;
            numericSasiedzi.Enabled = false;

            Knn.DaneTreningoweWejściowe = WczytywanieZpliku(ref ofdTrening);
            var treningowe = Knn.DaneTreningoweWejściowe;
            tbSciezkaTrening.Text = ofdTrening.FileName;
            tbDaneTreningowe.Text = Knn.WyświetlenieSystemów(ref treningowe);
            if (treningowe != null)
            {
                var możliweK = new Dictionary<int, int>();
                foreach (var wiersz in treningowe)
                {
                    if (!możliweK.ContainsKey(wiersz.LastOrDefault()))
                    {
                        możliweK.Add(wiersz.LastOrDefault(), 1);
                    }

                    else
                    {
                        możliweK[wiersz.LastOrDefault()]++;
                    }
                }
                numericSasiedzi.Maximum = możliweK.Aggregate((l, r) => l.Value > r.Value ? l : r).Value;
                numericSasiedzi.Enabled = true;
                OdblokujLiczenie();
            }

        }

        private void btnWczytajTestowe_Click(object sender, EventArgs e)
        {
            btnLicz.Enabled = false;
            Knn.DaneTestoweWejściowe = WczytywanieZpliku(ref ofdTest);
            var testowe = Knn.DaneTestoweWejściowe;
            tbSciezkaTest.Text = ofdTest.FileName;
            tbDaneTestowe.Text = Knn.WyświetlenieSystemów(ref testowe);
            OdblokujLiczenie();
        }

        private void OdblokujLiczenie()
        {
            btnLicz.Enabled = tbDaneTreningowe.Text != String.Empty && tbDaneTestowe.Text != String.Empty;
        }
        private void btnLicz_Click(object sender, EventArgs e)
        {
            Knn.DaneTestowe = Knn.StwórzListęObiektów(Knn.DaneTestoweWejściowe);
            Knn.DaneTreningowe = Knn.StwórzListęObiektów(Knn.DaneTreningoweWejściowe);
            Knn.IlośćSąsiadów = Convert.ToInt16(numericSasiedzi.Value);

            Metryka metryka = (Metryka)Delegate.CreateDelegate(typeof(Metryka), (MethodInfo)cbMetryki.SelectedItem);
            Knn.LiczMetryki(metryka);
            Knn.LiczDzielISortuj();
            Knn.KlasyfikujObiekty();
            Knn.LiczMacierzPredykcji();
            Knn.MacierzPredykcji.LiczTrafnosciAcc();
            Knn.MacierzPredykcji.LiczPokryciaCov();
            Knn.MacierzPredykcji.LiczStosunekTpr();
            Knn.MacierzPredykcji.LiczTrafnoscGlobalna();
            Knn.MacierzPredykcji.LiczPokrycieGlobalne();
            tbWyniki.Text = Knn.MacierzPredykcji.WypiszWyniki();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbMetryki.DataSource = typeof(Metryki).GetMethods().Where(
                metoda => metoda.ReturnType == typeof(double)).ToList();
            cbMetryki.DisplayMember = "Name";
            ofdTrening.Filter = "Pliki tekstowe (*.txt)|*.txt";
            ofdTest.Filter = "Pliki tekstowe (*.txt)|*.txt";
        }

        private void ZablokowanieComboboxa(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
