using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayisalAnalizProje
{
    public partial class MatrisInverse : Form
    {
        public MatrisInverse()
        {
            InitializeComponent();
        }
        TextBox[,] Matris, InversMatrisi;

        private void button1_Click(object sender, EventArgs e)
        {
            //panel1.Visible = true;
            //panel2.Visible = true;
            //panel3.Visible = true;
            ////Matrix M = new Matrix();
            ////M[1][1] = txt_11.Text;
            int n = Convert.ToInt32(txt_MatrisBoyut.Text);
            Matris = new TextBox[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    TextBox yenitextBox = new TextBox();
                    yenitextBox.Location = new System.Drawing.Point(i * 25 + 12, 120 + j * 25);
                    yenitextBox.Name = i + " * " + j;
                    yenitextBox.Size = new System.Drawing.Size(20, 20);
                    yenitextBox.TabIndex = 1;
                    yenitextBox.BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(yenitextBox);
                    Matris[i, j] = yenitextBox;
                }

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txt_MatrisBoyut.Text);

            double a, b;
            double[,] InversMatris = new double[n, 2 * n];
            double[,] AsilMatris = new double[n, 2 * n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        InversMatris[i, j] = 1;
                    }
                    else
                    {
                        InversMatris[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    AsilMatris[i, j] = Convert.ToDouble(Matris[i, j].Text);
                }
            }

            //Matris İnvers Alma İşlemi
            for (int i = 0; i < n; i++)
            {
                a = AsilMatris[i, i];
                for (int j = 0; j < n; j++)
                {
                    AsilMatris[i, j] = AsilMatris[i, j] / a;
                    InversMatris[i, j] = InversMatris[i, j] / a;
                }
                for (int k = 0; k < n; k++)
                {
                    if (k != i)
                    {
                        b = AsilMatris[k, i];
                        for (int l = 0; l < n; l++)
                        {
                            AsilMatris[k, l] = AsilMatris[k, l] - (AsilMatris[i, l] * b);
                            InversMatris[k, l] = InversMatris[k, l] - (InversMatris[i, l] * b);
                        }
                    }
                }
            }

            //Ekrana Yazdırma İşlemi
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    TextBox yenitextBox = new TextBox();
                    yenitextBox.Location = new System.Drawing.Point(i * 25 + 150, 120 + j * 25);
                    yenitextBox.Name = i + " * " + j;
                    yenitextBox.Size = new System.Drawing.Size(20, 20);
                    yenitextBox.TabIndex = 1;
                    yenitextBox.BorderStyle = BorderStyle.FixedSingle;
                    yenitextBox.Text = InversMatris[i, j].ToString();
                    this.Controls.Add(yenitextBox);
                }

            }
            Label YeniLabel = new Label();
            YeniLabel.Location = new System.Drawing.Point(150, 90);
            YeniLabel.Text = "Matrisin İnversi Aşağıdaki Gibidir.";
            this.Controls.Add(YeniLabel);
        }
    }
}
