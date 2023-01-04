using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; // Biblioteca SQLs
using System.Data.SqlClient; // Biblioteca SQLs
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2_login_banco_de_dados
{

    public partial class Form1 : Form
    {
        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private DataTable tblfuncionarios;
        private string strsql, strconex;

        private void Btentrar_Click(object sender, EventArgs e)
        {
            // Não coloque dois espaços seguidos dentro da string de comandos sql!
            strconex = "data source=(local);initial catalog=locadora;integrated security=sspi";
            conexao = new SqlConnection(strconex);
            conexao.Open();

            tblfuncionarios = new DataTable();

            // Use aspas duplas e dois "mais" para concatenar variáveis à string do SQL:

            // Replace pode ser utilizado para evitar a execução de códigos SQL dentro da caixa de texto.
            // Isso é uma boa prática para combater crimes de invasão de perfil.
            // Exemplo de tentativa de invasão: escrever ' or 1-1 -- dentro da caixa de texto. Isso pode validar o acesso indevido a um sistema.
            //                                                                    !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!                  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            strsql = "SELECT * FROM funcionarios WHERE Usuario='"+txtusuario.Text.Replace("-","").Replace("'", "") + "' AND senha='"+txtsenha.Text.Replace("-", "$").Replace("'", "") + "'";
            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblfuncionarios);

            // Conta a quantidade de registros dentro da tabela, para evitar
            // busca desnecessária. Se não houver registro, não haverá login.
            if (tblfuncionarios.Rows.Count >= 1)
            {
                txtmensagem.Text = "Login com Sucesso!";
                // Exibir o menu do app
                Form2 menu = new Form2();
                menu.Show();
                // O "This" abaixo se refere ao formulário atual
                this.Hide();
            }
            else
            {
                txtmensagem.Text = "Erro de login!";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

    }
}
