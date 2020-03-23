using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayisalAnalizProje
{
    public partial class SimpsonYontemi : Form
    {
        public SimpsonYontemi()
        {
            InitializeComponent();
        }

        private void btn_Hesapla_Click(object sender, EventArgs e)
        {
            int Boyut = Convert.ToInt32(txt_BoyutDegeri.Text);
            string[] Dizi = txt_Katsayilar.Text.Split('/');
            if (Dizi.Length == Boyut + 1)
            {
                int n = Convert.ToInt32(txt_NDegeri.Text);
                double a = Convert.ToDouble(txt_Baslangic.Text);
                double b = Convert.ToDouble(txt_Bitis.Text);
                double h = (b - a) / (n - 1);
                FonksiyonHesaplama FAHesapla = new FonksiyonHesaplama();
                double FA = FAHesapla.DegerHesapla(Dizi, a);
                FonksiyonHesaplama FBHesapla = new FonksiyonHesaplama();
                double FB = FBHesapla.DegerHesapla(Dizi, b);
                double temp = 0;
                double x = a;
                for (int i = 1; i < n; i++)
                {

                    x = x + h;
                    if (i % 2 != 0)
                    {
                        FonksiyonHesaplama FXHesapla = new FonksiyonHesaplama();
                        double FX = FXHesapla.DegerHesapla(Dizi, x);
                        temp = 4 * FX + temp;
                    }
                    else
                    {
                        FonksiyonHesaplama FXHesapla = new FonksiyonHesaplama();
                        double FX = FXHesapla.DegerHesapla(Dizi, x);
                        temp = 2 * FX + temp;
                    }
                }
                double S = (h / 3) * (FA + FB + temp);
                MessageBox.Show("S değeri : " + S);


            }
            else
            {
                MessageBox.Show("Lütfen Girdiğiniz Katsayı Değeri Kadar Eleman Giriniz.(Aralarına / Koymayı Unutmayın :) )");
            }
        }
    }
}
