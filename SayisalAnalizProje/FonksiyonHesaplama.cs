using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayisalAnalizProje
{
    class FonksiyonHesaplama
    {
        public double DegerHesapla(string[] Dizi, double GelenDeger)
        {
            double temp=1, Fonk = 0;
            for (int i = 0; i < Dizi.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {                    
                    temp = GelenDeger * temp;
                }
                Fonk = Convert.ToDouble(Dizi[i]) * temp + Fonk;
                temp = 1;
            }
            return Fonk;
        }
    }

}
