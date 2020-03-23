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
    public partial class GrafikYontemi : Form
    {
        public GrafikYontemi()
        {
            InitializeComponent();
        }

        private void GrafikYontemi_Load(object sender, EventArgs e)
        {

        }

        private void btn_Hesapla_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txt_Ndegeri.Text);
            string[] Dizi = txt_Katsayilar.Text.Split('/');
            int diziuzunluk = Dizi.Length;
            double x0 = Convert.ToDouble(txt_Baslangic.Text);
            double Dx = Convert.ToDouble(txt_DeltaXDegeri.Text);
            double Epsilon = Convert.ToDouble(txt_EpsilonDegeri.Text);
            double x1 = Dx + x0;

            if (diziuzunluk==n+1)
            {
                while (Math.Abs(x1 - x0) >= Epsilon)
                {
                    FonksiyonHesaplama F0Hesapla = new FonksiyonHesaplama();
                    double F0 =  F0Hesapla.DegerHesapla(Dizi, x0);
                    FonksiyonHesaplama F1Hesapla = new FonksiyonHesaplama();
                    double F1 = F1Hesapla.DegerHesapla(Dizi, x1);
                    if (F0 * F1 <= 0)
                    {
                        x1 = x0 + Dx / 2;
                        Dx = Dx / 2;
                    }
                    else      
                    {
                        x0 = x1;
                        x1 = x1 + Dx;
                    }
                }
                MessageBox.Show("Kök Değeri:" + x0);
            }
            else
            {
                MessageBox.Show("Lütfen Girdiğiniz Katsayı Değeri Kadar Eleman Giriniz.(Aralarına Virgül Koymayı Unutmayın :) )");
            }
        }
    }
}
