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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.ForeColor = System.Drawing.Color.Red;
            label6.Font = new Font("Arial", 20);
        }

        private void btnt_grafikYontemi_Click(object sender, EventArgs e)
        {
            GrafikYontemi grYontemi = new GrafikYontemi();
            grYontemi.Show();
        }

        private void btn_yariyaBolme_Click(object sender, EventArgs e)
        {
            YariyaBolmeYontemi ybYontemi = new YariyaBolmeYontemi();
            ybYontemi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegulaFalseYontemi rfYontemi = new RegulaFalseYontemi();
            rfYontemi.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewtonRaphsonYontemi nrYontemi = new NewtonRaphsonYontemi();
            nrYontemi.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TrapezYontemi TpYontemi = new TrapezYontemi();
            TpYontemi.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MatrisInverse MInverse = new MatrisInverse();
            MInverse.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SimpsonYontemi SYontemi = new SimpsonYontemi();
            SYontemi.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumerikTurev NTurev = new NumerikTurev();
            NTurev.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GaussEleminasyon GEleminasyon = new GaussEleminasyon();
            GEleminasyon.Show();
        }
    }
}
