using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayisalAnalizProje
{
    class TurevAlma
    {
        public string[] TurevAl(string[] Dizi)
        {
            string[] TurevDizi = new string[Dizi.Length];
            int j = 0;
            for (int i = 1; i < Dizi.Length; i++)
            {
                TurevDizi[j] = (i * Convert.ToDouble(Dizi[i])).ToString();
                j++;
            }
            return TurevDizi;

        }
    }
}
