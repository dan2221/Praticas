using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_aula2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Definição das variáveis
            double diam, vel, den, vis, nr;
            string textoexib;

            // Atribuíção de valores às variáveis
            diam = Convert.ToDouble(diametro.Text);
            vel = Convert.ToDouble(velocidade.Text);
            den = Convert.ToDouble(densidade.Text);
            vis = Convert.ToDouble(viscosidade.Text);

            // Cálculo do NR
            nr = diam * vel * den / vis;

            // Conversão para string
            textoexib = Convert.ToString(nr);

            // Exibição do resultado
            MessageBox.Show("Resultado: " + textoexib);

        }
    }
}
