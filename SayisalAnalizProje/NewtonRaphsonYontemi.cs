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
    public partial class NewtonRaphsonYontemi : Form
    {
        public NewtonRaphsonYontemi()
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
                double Epsilon = Convert.ToDouble(txt_EpsilonDegeri.Text);
                FonksiyonHesaplama F0hesaplama = new FonksiyonHesaplama();
                double F0 = F0hesaplama.DegerHesapla(Dizi, x0);
                TurevAlma Turev = new TurevAlma();
                string[] TurevDizi = Turev.TurevAl(Dizi);
                FonksiyonHesaplama FTurev0Hesaplama = new FonksiyonHesaplama();
                double FTurev0 = FTurev0Hesaplama.DegerHesapla(TurevDizi, x0);
                double x1 = x0 - (F0 / FTurev0);
                while (x1 - x0 > Epsilon)
                {
                    x0 = x1;
                    F0 = F0hesaplama.DegerHesapla(Dizi, x0);
                    FTurev0 = FTurev0Hesaplama.DegerHesapla(TurevDizi, x0);
                    x1 = x0 - (F0 / FTurev0);
                }
                MessageBox.Show("X in kök değeri : " + x0);

            }
            else
            {
                MessageBox.Show("Lütfen Girdiğiniz Katsayı Değeri Kadar Eleman Giriniz.(Aralarına - Koymayı Unutmayın :) )");
            }
        }
    }
}
