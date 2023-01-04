using System;
using System.Collections.Generic;
using System.ComponentModel;
// Bibliotecas SQL ///////////
using System.Data;
using System.Data.SqlClient;
//////////////////////////////
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04_alterar_cadastro
{
    public partial class Form1 : Form
    {
        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private DataTable tblcategorias;
        private SqlCommand comando;
        private string strsql, strconex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grupo1.Enabled = true;
            grupo2.Visible = false;
        }

        private void Btgravar_Click(object sender, EventArgs e)
        {
            try
            {
                strsql = $"UPDATE categorias SET categoria='{txtcategoria.Text}', " +
                                $"descricao='{txtdescricao.Text}', valor='{txtvalor.Text.Replace(",", ".")}' " +
                                $"WHERE codcategoria='{txtcodcateg.Text}'";
                comando = new SqlCommand(strsql, conexao);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso.", "Informação");

                grupo1.Enabled = true;
                grupo2.Visible = false;
            }
            catch
            {
                MessageBox.Show("Verifique os dados digitados.", "Informação");
            }
            
        }

        private void Btcancelar_Click(object sender, EventArgs e)
        {
            grupo1.Enabled = true;
            grupo2.Visible = false;
        }

        private void Btpesquisar_Click(object sender, EventArgs e)
        {
            // Se estiver usando o SQL Server Express Edition altere a parte "source=(local)" para "source=\\LAB6-14.
            // O código não pode conter dois espaços seguidos.
            strconex = "data source=(local);initial catalog=locadora;integrated security=sspi";
            conexao = new SqlConnection(strconex);
            conexao.Open();
            tblcategorias = new DataTable();

            // Três formas de se concatenar uma string
            strsql = "SELECT * FROM Categorias WHERE codcategoria= '"+txtcodcateg.Text+"'";
 //           strsql = $"SELECT * FROM Categorias WHERE codcategoria= '{txtcategoria.Text}'";
 //           strsql = string.Format("SELECT * FROM Categorias WHERE codcategoria= '{0}'", txtcategoria.Text);

            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblcategorias); // Preencher tabela

            if(tblcategorias.Rows.Count == 1)
            {
                grupo1.Enabled = false;
                grupo2.Visible = true;
                txtcategoria.Text = tblcategorias.Rows[0]["categoria"].ToString();
                txtdescricao.Text = tblcategorias.Rows[0]["descricao"].ToString();
                txtvalor.Text = tblcategorias.Rows[0]["valor"].ToString();
            }
            else
            {
                MessageBox.Show("Registro não encontrado.", "Aviso");
            }
            
        }
    }
}
