// DICA !!!!!!!!!!!!!

// Use o site Connection Strings: https://www.connectionstrings.com/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb; // Biblioteca p/ acessar banco de dados do Microsoft Acess.
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_2022_10_17
{
    public partial class Form1 : Form
    {
        // Criação e instancia do objeto.
        // Instância significa pôr o objeto em uso.

        // Em 1 Linha //////////////////////////////////////////////////////
        //     Declaração      |     Instância
        // DataTable tblperguntas = new DataTable();
        //
        // Em 2 Linhas /////////////////////////////////////////////////////
        // DataTable tblperguntas2;            // Declaração
        // tblperguntas2 = new DataTable();    // Instância
        ////////////////////////////////////////////////////////////////////
        
        private OleDbConnection conexao; // Criando objeto de conexão ao banco
        private OleDbDataAdapter adapter;
        private DataTable tblperguntas;

        private string strsql, strconex;
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btpesquisar_Click(object sender, EventArgs e)
        {
            // Provedor e caminho do banco de dados.
            strconex = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\quiz.accdb";
            conexao = new OleDbConnection(strconex);
            conexao.Open();

            tblperguntas = new DataTable();

            strsql = " SELECT * FROM perguntas WHERE assunto = '" + txtpesquisar.Text + "'";
            adapter = new OleDbDataAdapter(strsql, conexao);
            adapter.Fill(tblperguntas);
            grade.DataSource = tblperguntas;
        }
    }
}
