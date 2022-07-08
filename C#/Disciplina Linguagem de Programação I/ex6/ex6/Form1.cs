using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            decimal quant, preco, total;
            quant = Convert.ToDecimal(txtQtde.Text);
            preco = Convert.ToDecimal(txtPreco.Text);
            total = quant * preco;
            Console.WriteLine(preco);

            MessageBox.Show(txtNome.Text + ": R$" + Convert.ToString(total),"Total vendido");
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtPreco.Text = "";
            txtQtde.Text = "";
        }
    }
}
