using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_2022_04_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btcores_Click(object sender, EventArgs e)
        {
            cores.ShowDialog();
            this.BackColor = cores.Color;
        }

        private void Btfonte_Click(object sender, EventArgs e)
        {
            fonte.ShowDialog();
            this.Font = fonte.Font;
        }

        private void Btabrir_Click(object sender, EventArgs e)
        {
            abrir.ShowDialog();
            figura.Load(abrir.FileName);

        }

        private void Btsalvar_Click(object sender, EventArgs e)
        {
            salvar.ShowDialog();
            label1.Text = salvar.FileName;
        }

        private void Btpasta_Click(object sender, EventArgs e)
        {
            pasta.ShowDialog();
            label1.Text = pasta.SelectedPath;
        }

        private void Picimagem_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btimprimir_Click(object sender, EventArgs e)
        {
            imprimir.ShowDialog();
        }
    }
}
