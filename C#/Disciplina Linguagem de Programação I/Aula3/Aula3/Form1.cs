using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Objeto DateTime, atributos: hoje e ano.
            txtatual.Text = DateTime.Today.Year.ToString(); // Outro método de conversão de variável.
        }

        private void Lblatual_Click(object sender, EventArgs e)
        {

        }

        private void Lblnasc_Click(object sender, EventArgs e)
        {

        }

        private void Lblidade_Click(object sender, EventArgs e)
        {

        }

        private void Btlimpar_Click(object sender, EventArgs e)
        {
            // Método Clear() para limpar valores das propriedades do objeto.
            txtnasc.Clear();
            txtatual.Text = DateTime.Today.Year.ToString(); // Ano atual,
            txtidade.Clear();

            // Mudando a propriedade "Image" do objeto Picfig para vazio (null).
            picfig.Image = null;
        }

        private void Btcalcular_Click(object sender, EventArgs e)
        {
            int atual, nasc, idade;

            atual = Convert.ToInt16(txtatual.Text);
            nasc = Convert.ToInt16(txtnasc.Text);
            idade = atual - nasc;

            // É preciso converter os valores para string, pois somente assim podem ser exibidos
            // na caixa de texto.
            txtidade.Text = Convert.ToString(idade);

            // O algoritmo acima também pode ser feito da seguinte forma:
            //
            // idade.Text = Convert.ToString(Convert.ToInt16(txtatual.Text) - Convert.ToInt16(txtnasc.Text));

            if (idade >= 18)
            {   
                // Método Load () para mudar a imagem do objeto Picfig.
                // Use barra dupla para identificar como diretório e não comando.
                picfig.Load("C:\\imagens\\pode.jpg");

                //-------------- Texto --------- Título da janela ------- Botões -------------------- Ícone
                MessageBox.Show("Pode dirigir!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                picfig.Load("C:\\imagens\\naopode.jpg");
                MessageBox.Show("Não pode dirigir!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Picfig_Click(object sender, EventArgs e)
        {
            // Imagem (bebê no carrinho) por coolunit.
            // Site Pixabay
            // Disponível em: https://pixabay.com/images/id-867577/

            // Imagem (homem dirigindo) por mohamed Hassan. 
            // Site Pixabay
            // Disponível em : https://pixabay.com/images/id-4155505/

        }
    }
}
