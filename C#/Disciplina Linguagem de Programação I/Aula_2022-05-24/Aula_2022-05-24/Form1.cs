using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_2022_05_24
{
    public partial class Form1 : Form
    {
        // Se declarada no cabeçalho, a instancia pode ser utilizada
        // em todos os métodos.
        Geometria geoglobal = new Geometria();

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Instanciando objeto que usa a classe
            Geometria geo = new Geometria();

            MessageBox.Show("A área é " + geo.Quadrado(4));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Geometria geo = new Geometria();

            MessageBox.Show("A área é " + geo.Retangulo(5, 7));
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A área é " + geoglobal.Triangulo(5, 7));
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A área é " + geoglobal.Trapezio(5, 7, 9));
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("o fatorial é " + geoglobal.Fatorial(5));
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Tempo t1 = new Tempo();
            MessageBox.Show("Tempo: " + t1.Imprimir());
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Tempo t2 = new Tempo(11, 42, 36);
            MessageBox.Show("Tempo: " + t2.Imprimir());
        }
    }
}
