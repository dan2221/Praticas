// Execute o banco de dados primeiro!
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_2022_10_03
{
    public partial class Form1 : Form
    {
        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private SqlCommand comando;
        private DataTable tblcategorias;
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

        private void Btcancelar_Click(object sender, EventArgs e)
        {
            grupo1.Enabled = true;
            grupo2.Visible = false;
        }

        private void Btexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                strsql = "DELETE FROM Categorias WHERE codcategoria = '"+txtcodcategoria.Text+"'";
                comando = new SqlCommand(strsql, conexao);
                comando.ExecuteNonQuery();
                grupo1.Enabled = true;
                grupo2.Visible = false;
                MessageBox.Show("Registro excluído com sucesso");
            }
            catch
            {
                MessageBox.Show("Esse registro não pode ser excluído",
                    "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            
        }

        private void Btpesquisar_Click(object sender, EventArgs e)
        {
            strconex = "data source=(local);initial catalog=locadora;integrated security=sspi";
            conexao = new SqlConnection(strconex);
            conexao.Open();

            tblcategorias = new DataTable();

            strsql = "SELECT * FROM Categorias WHERE codcategoria='"+ txtcodcategoria.Text+"'";
            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblcategorias);

            if (tblcategorias.Rows.Count == 1)
            {
                grupo1.Enabled = false;
                grupo2.Visible = true;
                txtcategoria.Text = tblcategorias.Rows[0]["categoria"].ToString();
                txtdescricao.Text = tblcategorias.Rows[0]["descricao"].ToString();
                txtvalor.Text = tblcategorias.Rows[0]["valor"].ToString();
            }
            else
            {
                MessageBox.Show("Registro não existe");
            }
        }
    }
}
