using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista
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

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            lblitem.Text = lstfrutas.Text;
            // Outro método:
            // lblitem.Text = lstfrutas.SelectedItem.ToString();

            // Nenhum item selecionado
            if ( lstfrutas.SelectedIndex != -1)
            {
                lblitem.Text = lstfrutas.Items[lstfrutas.SelectedIndex].ToString();
            }
            else
            {
                MessageBox.Show("Selecione um item na lista", "informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            // Remover item

            // 1° Jeito
            // lstfrutas.Items.Remove(lstfrutas.Items[lstfrutas.SelectedIndex]);
            
            // 2° Jeito
            // lstfrutas.Items.Remove(lstfrutas.SelectedItem);

            // 3° Jeito
            lstfrutas.Items.RemoveAt(lstfrutas.SelectedIndex);

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            lstfrutas.Items.Clear();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bttamanho_Click(object sender, EventArgs e)
        {
            lbltamanho.Text = lstfrutas.Items.Count.ToString();
        }

        private void Btindice_Click(object sender, EventArgs e)
        {
            lblindice.Text = lstfrutas.SelectedIndex.ToString();
        }

        private void Btadicionar_Click(object sender, EventArgs e)
        {
            int i, quant;
            bool achei = false;
            quant = lstfrutas.Items.Count;
            for (i = 0; i < quant; i++)
            {
                if (lstfrutas.Items[i].ToString().ToLower() == txtfruta.Text)
                {
                    achei = true;
                    break;
                }
            }
            if (achei == false)
            {
                lstfrutas.Items.Add(txtfruta.Text.ToString());
            }
            else
            {
                MessageBox.Show("Já existe esse item", "informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
