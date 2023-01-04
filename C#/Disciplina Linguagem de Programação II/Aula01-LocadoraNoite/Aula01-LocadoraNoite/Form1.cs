// AVISO ////////////////////////////////////////////////
// Antes de executar o programa, execute o banco de dados
// no SQL Server.
/////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;

// Bibliotecas para banco de dados
using System.Data;
using System.Data.SqlClient;
// Elas são exclusivas para o SQL Server
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula01_LocadoraNoite
{
    public partial class Form1 : Form
    {

        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private DataTable tblveiculos;
        private string strsql, strconex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btpesquisar_Click(object sender, EventArgs e)
        {
            // Não coloque dois espaços seguidos dentro da string de comandos sql!
            strconex = "data source=(local);initial catalog=locadora;integrated security=sspi";
            conexao = new SqlConnection(strconex);
            conexao.Open();

            tblveiculos = new DataTable();

            strsql = "select * from veiculos where marca='"+txtmarca.Text +"'";
            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblveiculos);
            grade.DataSource = tblveiculos;
        }
    }
}
