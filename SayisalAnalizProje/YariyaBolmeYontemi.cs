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
    public partial class YariyaBolmeYontemi : Form
    {
        public YariyaBolmeYontemi()
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
                FonksiyonHesaplama FAhesaplama = new FonksiyonHesaplama();
                double FA = FAhesaplama.DegerHesapla(Dizi, a);
                FonksiyonHesaplama FBhesaplama = new FonksiyonHesaplama();
                double FB = FBhesaplama.DegerHesapla(Dizi, b);
                if (FA * FB <= 0)
                {
                    if (FA == 0)
                    {
                        if (FB == 0)
                        {
                            MessageBox.Show("A ve B Çakışık Kök!");
                        }
                        else
                        {
                            MessageBox.Show("A Köktür!");
                        }
                    }
                    else
                    {
                        if (FB == 0)
                        {
                            MessageBox.Show("B Köktür!");
                        }
                        else
                        {
                            double c = (a + b) / 2;
                            FonksiyonHesaplama FChesaplama = new FonksiyonHesaplama();
                            double FC = FChesaplama.DegerHesapla(Dizi, c);
                            while (FC <= Epsilon)
                            {
                                c = (a + b) / 2;
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
                            MessageBox.Show("Kök Değeri:" + c);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kök Yoktur!");
                }

            }
            else
            {
                MessageBox.Show("Lütfen Girdiğiniz Katsayı Değeri Kadar Eleman Giriniz.(Aralarına - Koymayı Unutmayın :) )");
            }

        }
    }
}
