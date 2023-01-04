using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2_login_banco_de_dados
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Função nativa utilizada para executar determinada ação quando a
        // janela/formulário for fechada.
        // Neste exemplo fechará toda a aplicação, evitando que o outro
        // formulário permaneça ativo.
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
