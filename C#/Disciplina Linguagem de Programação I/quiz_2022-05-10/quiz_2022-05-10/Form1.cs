using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_2022_05_10
{
    public partial class Form1 : Form
    {
        private string[,] mat = new string[5, 6];
        int pontos1, posicao,linha;
        string correta, resposta;

        public Form1()
        {
            InitializeComponent();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            linha++;
            if(linha >= 5)
            {
                btiniciar.Visible = true;
                grupo.Visible = false;
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lblpergunta_Click(object sender, EventArgs e)
        {
            mat[0, 0] = "Qual a cor do Céu?";
            mat[0, 1] = "Azul";
            mat[0, 2] = "Verde";
            mat[0, 3] = "Preto";
            mat[0, 4] = "Marrom";
            mat[0, 5] = "Azul";

            mat[1, 0] = "Qual a Capital do Brasil?";
            mat[1, 1] = "Olinda";
            mat[1, 2] = "Brasília";
            mat[1, 3] = "Curitiba";
            mat[1, 4] = "Brasília";
            mat[1, 5] = "Brasília";

            mat[2, 0] = "Qual animal tem tromba?";
            mat[2, 1] = "Leão Marinho";
            mat[2, 2] = "Hipopótamo";
            mat[2, 3] = "Elefante";
            mat[2, 4] = "Rinoceronte";
            mat[2, 5] = "Elefante";

            mat[3, 0] = "Quem descobriu o Brasil?";
            mat[3, 1] = "Don Pedro I";
            mat[3, 2] = "Dom João";
            mat[3, 3] = "Tiradentes";
            mat[3, 4] = "Pedro Alvares Cabral";
            mat[3, 5] = "Pedro Alvares Cabral";

            mat[4, 0] = "Quem descobriu o Brasil?";
            mat[4, 1] = "Don Pedro I";
            mat[4, 2] = "Dom João";
            mat[4, 3] = "Tiradentes";
            mat[4, 4] = "Pedro Alvares Cabral";
            mat[4, 5] = "Pedro Alvares Cabral";

            btiniciar.Visible = true;
            grupo.Visible = false;
            pontos1 = 0;
            lblpontos.Text = "Pontos: ";
        }

        private void Btiniciar_Click(object sender, EventArgs e)
        {
            btiniciar.Visible = false;
            grupo.Visible = true;
            pontos1 = 0;
            lblpontos.Text = "Pontos: ";
            linha = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
