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
    public partial class RegulaFalseYontemi : Form
    {
        public RegulaFalseYontemi()
        {
            InitializeComponent();
        }

        private void btn_Hesapla_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txt_Ndegeri.Text);
            string[] Dizi = txt_Katsayilar.Text.Split('/');
            if (Dizi.Length == n + 1)
            {
                double a = Convert.ToDouble(txt_Baslangic.Text);
                double b = Convert.ToDouble(txt_Bitis.Text);
                double Epsilon = Convert.ToDouble(txt_EpsilonDegeri.Text);
                double FC ;
                double c;
                FonksiyonHesaplama FAhesaplama = new FonksiyonHesaplama();
                double FA = FAhesaplama.DegerHesapla(Dizi, a);
                FonksiyonHesaplama FBhesaplama = new FonksiyonHesaplama();
                double FB = FBhesaplama.DegerHesapla(Dizi, b);
                c = (b * FA - a * FB) / (FA - FB);
                FonksiyonHesaplama FChesaplama = new FonksiyonHesaplama();
                FC = FChesaplama.DegerHesapla(Dizi, c);                
                while (FC > Epsilon)
                {
                    FA = FAhesaplama.DegerHesapla(Dizi, a);
                    FB = FBhesaplama.DegerHesapla(Dizi, b);
                    c = (b * FA - a * FB) / (FA - FB);                    
                    FC = FChesaplama.DegerHesapla(Dizi, c);
                    if (FA * FC < 0)
                    {
                        b = c;
                    }
                    else
                    {
                        a = c;
                    }
                }
                MessageBox.Show("Kök Değeri: " + c);


            }
            else
            {
                MessageBox.Show("Lütfen Girdiğiniz Katsayı Değeri Kadar Eleman Giriniz.(Aralarına - Koymayı Unutmayın :) )");
            }
        }
    }
}
