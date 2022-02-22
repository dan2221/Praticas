using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_2_manha
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {   
            /* Comentário de múiltiplas linhas
             * 
             * Atalho para fazer comentário: Ctrl + K + C
             * 
             * Objetos ////////////////////////////////////////
             * 
             * O ".Text" se refere a uma propriedade do objeto.
             * Objetos: txtbase, txtaltura e txtarea.
            */
            //txtbase.Text = "0";
            //txtaltura.Text = "0";
            //txtarea.Text = "0";

            // MÉTODOS ////////////////////////////////////////

            // Método/função para limpar o formulário
            txtarea.Clear();

            // Show é uma função para exibir pop-up.
            // MessageBox é um objeto padrão do programa.
            MessageBox.Show("Limpo!");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Definição das variáveis
            double area, bas, alt;

            // Atribuíção e conversão de tipo de variável
            bas = Convert.ToDouble(txtbase.Text);
            alt = Convert.ToDouble(txtaltura.Text);

            area = bas * alt / 2;

            txtarea.Text = Convert.ToString(area);
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
