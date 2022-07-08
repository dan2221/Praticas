using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_12_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Botão Calcular
        private void Button1_Click(object sender, EventArgs e)
        {
            double nota1, nota2, media, trab;
            nota1 = Convert.ToDouble(txtp1.Text);
            nota2 = Convert.ToDouble(txtp2.Text);
            trab = Convert.ToDouble(txttrab.Text);

            media = nota1 * 0.35 + nota2 * 0.45 + trab * 0.2;

            txtmedia.Text = Convert.ToString(media);

            if(media > 6){
                lblresult.Text = "Aprovado!";
            }
            else
            {
                lblresult.Text = "Reprovado!";
            }
        }

        // Botão Limpar
        private void Btlimpar_Click(object sender, EventArgs e)
        {
            txtp1.Clear();
            txtp2.Clear();
            txttrab.Clear();
            txtmedia.Clear();
            lblresult.Text = "...";
        }
    }
}
