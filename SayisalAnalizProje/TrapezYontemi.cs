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
    public partial class TrapezYontemi : Form
    {
        public TrapezYontemi()
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
                double h = (b - a) / n;
                double x = a;
                FonksiyonHesaplama FXHesapla = new FonksiyonHesaplama();
                double[] FXDizisi = new double[n + 1];
                FXDizisi[0] = FXHesapla.DegerHesapla(Dizi, a);
                for (int i = 1; i < n; i++)
                {
                    x = x + h;
                    FXDizisi[i] = FXHesapla.DegerHesapla(Dizi, x);
                }
                double temp = 0;
                for (int i = 1; i < n; i++)
                {
                    temp = temp + FXDizisi[i];
                }
                double s = h * ((FXDizisi[0] + FXDizisi[n]) / 2 + temp);
                MessageBox.Show("S Değeri : " + s);
            }
            else
            {
                MessageBox.Show("Lütfen Girdiğiniz Katsayı Değeri Kadar Eleman Giriniz.(Aralarına - Koymayı Unutmayın :) )");
            }
        }

    }
}
