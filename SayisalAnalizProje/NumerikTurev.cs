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
    public partial class NumerikTurev : Form
    {
        public NumerikTurev()
        {
            InitializeComponent();
        }

        private void btn_Hesapla_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txt_Ndegeri.Text);
            string[] Dizi = txt_Katsayilar.Text.Split('/');
            if (Dizi.Length == n + 1)
            {
                double x0 = Convert.ToDouble(txt_x0.Text);
                double Dx = Convert.ToDouble(txt_DeltaDegeri.Text);
                double xIleri = x0 + Dx;
                double xGeri = x0 - Dx;
                FonksiyonHesaplama FonksiyonHesapla = new FonksiyonHesaplama();
                double FX0 = FonksiyonHesapla.DegerHesapla(Dizi, x0);
                double FXIleri = FonksiyonHesapla.DegerHesapla(Dizi, xIleri);
                double FXGeri = FonksiyonHesapla.DegerHesapla(Dizi, xGeri);
                double IleriFark = (FXIleri - FX0) / Dx;
                double GeriFark = (FX0 - FXGeri) / Dx;
                double MerkeziFark = (FXIleri - FXGeri) / (2 * Dx);
                MessageBox.Show(" İleri Fark Türevi = " + IleriFark + "\n Geri Fark Türevi = " + GeriFark + "\n Merkezi Fark Türevi = " + MerkeziFark);
            }
            else
            {
                MessageBox.Show("Lütfen Girdiğiniz Katsayı Değeri Kadar Eleman Giriniz.(Aralarına - Koymayı Unutmayın :) )");
            }
        }
    }
}
