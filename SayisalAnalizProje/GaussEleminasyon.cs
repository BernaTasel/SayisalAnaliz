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
    public partial class GaussEleminasyon : Form
    {
        public GaussEleminasyon()
        {
            InitializeComponent();
        }
        TextBox[,] Matris;
        private void GaussEleminasyon_Load(object sender, EventArgs e)
        {
            Matris = new TextBox[3, 4];
            Label xLabel = new Label();
            xLabel.Location = new System.Drawing.Point(12, 10);
            xLabel.Text = "x";
            xLabel.Size = new System.Drawing.Size(20, 20);
            this.Controls.Add(xLabel);

            Label yLabel = new Label();
            yLabel.Location = new System.Drawing.Point(37, 10);
            yLabel.Text = "y";
            yLabel.Size = new System.Drawing.Size(20, 20);
            this.Controls.Add(yLabel);

            Label zLabel = new Label();
            zLabel.Location = new System.Drawing.Point(62, 10);
            zLabel.Text = "z";
            zLabel.Size = new System.Drawing.Size(20, 20);
            this.Controls.Add(zLabel);

            Label cLabel = new Label();
            cLabel.Location = new System.Drawing.Point(87, 10);
            cLabel.Text = "c";
            cLabel.Size = new System.Drawing.Size(20, 20);
            this.Controls.Add(cLabel);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    TextBox yenitextBox = new TextBox();
                    yenitextBox.Location = new System.Drawing.Point(i * 25 + 12, 35 + j * 25);
                    yenitextBox.Name = i + " * " + j;
                    yenitextBox.Size = new System.Drawing.Size(20, 20);
                    yenitextBox.TabIndex = 1;
                    yenitextBox.BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(yenitextBox);
                    Matris[j, i] = yenitextBox;
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double temp = 0;
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i > j)
                    {
                        temp = Convert.ToDouble(Matris[i, j].Text) / Convert.ToDouble(Matris[j, j].Text);
                        for (int k = 0; k < 4; k++)
                        {
                            (Matris[i, k].Text) = (Convert.ToDouble(Matris[i, k].Text) - temp * Convert.ToDouble(Matris[j, k].Text)).ToString();
                        }
                    }
                }
            }
            double[] Degerler = new double[3];
            double Toplam = 0;
            Degerler[2] = Convert.ToDouble(Matris[2, 3].Text) / Convert.ToDouble(Matris[2, 2].Text);
            for (int i = 2; i >= 0; i--)
            {
                Toplam = 0;
                for (int j = i + 1; j < 3; j++)
                {
                    Toplam = Toplam + Convert.ToDouble(Matris[i, j].Text) * Degerler[j];
                }
                Degerler[i] = (Convert.ToDouble(Matris[i, 3].Text) - Toplam) / Convert.ToDouble(Matris[i, i].Text);
            }
            MessageBox.Show(" x Degeri= " + Degerler[0].ToString() + "\n y Degeri= " + Degerler[1].ToString() + "\n z Degeri= " + Degerler[2].ToString());
        }
    }
}
