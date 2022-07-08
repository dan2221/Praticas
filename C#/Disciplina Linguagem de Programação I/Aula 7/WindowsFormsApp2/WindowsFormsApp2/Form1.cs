using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AzulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void AmareloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void RosaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void VerdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PretoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbltitulo.ForeColor = Color.Black;
        }

        private void BrancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbltitulo.ForeColor = Color.White;
        }

        private void AzulToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbltitulo.ForeColor = Color.DarkBlue;
        }

        private void RoxoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbltitulo.ForeColor = Color.Purple;
        }

        private void FuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Estrutura da instância

            // Classe objeto = new Classe
            Funcionarios func = new Funcionarios();
            func.Show();
        }

        private void LocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Locacao func = new Locacao();
            func.Show();
        }

        private void VeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Veiculos func = new Veiculos();
            func.Show();
        }

        private void ClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clientes func = new Clientes();
            func.Show();
        }
    }
}
