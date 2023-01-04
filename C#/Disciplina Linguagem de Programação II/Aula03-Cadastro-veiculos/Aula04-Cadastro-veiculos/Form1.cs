using System;
using System.Collections.Generic;
using System.ComponentModel;
// Bibliotecas SQL //
using System.Data;
using System.Data.SqlClient;
/////////////////////////
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04_Cadastro_veiculos
{
    public partial class Form1 : Form
    {
        // Declaração de atributos da classe pública.
        // Eles usam tipos de dados obtidos das bibliotecas SQL.
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
            // Se estiver usando o SQL Server Express Edition altere a parte "source=(local)" para "source=\\LAB6-14.
            strconex = "data source=(local);initial catalog=locadora;integrated security=sspi";
            conexao = new SqlConnection(strconex);
            conexao.Open();
            tblcategorias = new DataTable();

            strsql = "SELECT * FROM Categorias";
            adapter = new SqlDataAdapter(strsql, conexao);
            // Preencher tabela
            adapter.Fill(tblcategorias);

            cbocodcategoria.DataSource = tblcategorias;
            cbocodcategoria.DisplayMember = "categoria";
            cbocodcategoria.ValueMember = "codcategoria";

            // Exibe um código da categoria dentro da label
            lblcodcategoria.Text = cbocodcategoria.SelectedValue.ToString();
        }

        private void Cbocodcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Atualiza a label do código da categoria
            lblcodcategoria.Text = cbocodcategoria.SelectedValue.ToString();
        }

        private void Btgravar_Click(object sender, EventArgs e)
        {
            strsql = "INSERT INTO veiculos (Marca, Modelo, Cor, Placa, Ano, Codcategoria) " +
                "VALUES ('" + txtmarca.Text + "','" + txtmodelo.Text + "','" + txtcor.Text + "','" + txtplaca.Text + "','" + txtano.Text + "','" + cbocodcategoria.SelectedValue + "')";
            comando = new SqlCommand(strsql, conexao);
            comando.ExecuteNonQuery();
            MessageBox.Show("Gravado com sucesso!", "mensagem");
        }
    }
}
