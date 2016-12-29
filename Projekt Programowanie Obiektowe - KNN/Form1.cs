using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Programowanie_Obiektowe___KNN
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        KNN knn = new KNN();
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

                //tbScieszka.Text = ofd.FileName;
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
            knn.daneTreningoweWejściowe = WczytywanieZpliku(ref ofdTrening);
            int[][] treningowe = knn.daneTreningoweWejściowe;
            tbSciezkaTrening.Text = ofdTrening.FileName;
            tbDaneTreningowe.Text = knn.WyświetlenieSystemów(ref treningowe);
        }

        private void btnWczytajTestowe_Click(object sender, EventArgs e)
        {
            knn.daneTestoweWejściowe = WczytywanieZpliku(ref ofdTest);
            int[][] testowe = knn.daneTestoweWejściowe;
            tbSciezkaTest.Text = ofdTest.FileName;
            tbDaneTestowe.Text = knn.WyświetlenieSystemów(ref testowe);
        }
        private void btnLicz_Click(object sender, EventArgs e)
        {
            //do zrobienia: liczenie zablokowane przed wybraniem potrzebnych parametrów
            knn.IlośćSąsiadów = Convert.ToInt16(nrcSasiedzi.Value);
            knn.daneTreningowe = knn.StwórzListęObiektów(knn.daneTreningoweWejściowe);
            knn.daneTestowe = knn.StwórzListęObiektów(knn.daneTestoweWejściowe);
            Metryka metryka = (Metryka)Delegate.CreateDelegate(typeof(Metryka), (MethodInfo) cbMetryki.SelectedItem);
            knn.LiczMetryki(metryka);
            knn.LiczDzielISortuj();
            knn.SprawdźK();
            knn.KlasyfikujObiekty();
            knn.LiczMacierzPredykcji();
            knn.macierzPredykcji.LiczTrafnościAcc();
            knn.macierzPredykcji.LiczPokryciaCov();
            knn.macierzPredykcji.LiczStosunekTPR();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbMetryki.DataSource = typeof(Metryki).GetMethods().Where(
                metoda => metoda.ReturnType == typeof(double)).ToList();
            cbMetryki.DisplayMember = "Name";
        }
    }
}
