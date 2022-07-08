using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double raio1, raio2, raioMenor, raioMaior, altura, volume;

            altura = Convert.ToDouble(txtalt.Text);
            raio1 = Convert.ToDouble(txtraio1.Text);
            raio2 = Convert.ToDouble(txtraio2.Text);
            if (raio1 > raio2)
            {
                raioMaior = raio1;
                raioMenor = raio2;
            }
            else
            {
                raioMaior = raio2;
                raioMenor = raio1;
            }

            volume = 1.0 / 3.0 * Math.PI * altura * (Math.Pow(raioMaior, 2) + Math.Pow(raioMenor, 2) + raioMaior * raioMenor);
            MessageBox.Show("Volume: " + Convert.ToString(Math.Round(volume,3)));
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtalt.Text = "";
            txtraio1.Text = "";
            txtraio2.Text = "";
        }
    }
}
