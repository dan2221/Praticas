// Tarefa de ILP2

//Com base no formulário de Cadastro de Veículos
//Crie um Formulário de cadastro para a tabela de PRODUCTS  do banco de dados NORTHWIND.
//Utilizando ComboBox para as colunas que são chaves estrangeiras SupplierID e CategoryID.

//sendo que:

//Para a ComboBox de SupplierID,
//o DisplayMember (o que vai ser exibido) será a coluna CompanyName;
//o DisplayValue (o valor que vai ser utilizado) será a própria coluna  SupplierID;


//Para a ComboBox de CategoryID, 
//o DisplayMember (o que vai ser exibido) será a coluna CategoryName;
//o DisplayValue (o valor que vai ser utilizado) será a própria coluna  CategoryID;

//OBS.: ENTREGAR UM ARQUIVO DE TEXTO DO WORD COM O PRINT DA TELA E O CÓDIGO 

using System;
using System.Collections.Generic;
using System.ComponentModel;
// Bibliotecas SQL //////////
using System.Data;
using System.Data.SqlClient;
/////////////////////////////
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04_Cadastro_veiculos
{
    public partial class Form1 : Form
    {
        // Declaração de atributos da classe pública ////////////////////////////////////
        // Eles usam tipos de dados obtidos das bibliotecas SQL.

        // O objeto do tipo SqlConnection têm a função de gerar uma conexão
        // com um banco de dados sendo, portanto o objeto fundamental no acesso a dados.
        private SqlConnection conexao;

        // O SqlDataAdapter, serve como uma ponte entre um DataSet e o SQL Server para
        // recuperar e salvar dados.
        private SqlDataAdapter adapter;

        private SqlCommand comando;

        // O DataTable funciona como um conjunto de linhas e colunas na memória que
        // armazenam os dados filtrados e descarregados pelo DataAdapter, e pode ser
        // considerado a principal classe do ADO.NET para armazenar dados desconectados.
        private DataTable tblProducts;
        private string strsql, strconex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Se estiver usando o SQL Server Express Edition altere a parte "source=(local)" para "source=\\LAB6-14".
            strconex = "data source=(local);initial catalog=locadora;integrated security=sspi";
            conexao = new SqlConnection(strconex);
            conexao.Open();

            // Instanciando objeto do tipo DataTable.
            tblProducts = new DataTable();

            strsql = "SELECT * FROM Products";
            // O Objeto do tipo SqlDataAdapter serve para retornar o que eu quero da tabela.
            // Pode ser feito em forma de select para filtrar o resultado.
            adapter = new SqlDataAdapter(strsql, conexao);

            // O método Fill da Classe SqlDataAdapter serve para PREENCHER A TABELA do banco de dados ativo.
            adapter.Fill(tblProducts);

            // DataSource, DisplayMember e ValueMember são atributos do Objeto ComboBox.
            cboCodCategoria.DataSource = tblProducts; // Fonte de dados, neste caso é o objeto tblProducts.
            cboCodCategoria.DisplayMember = "CategoryName"; // O que vai ser exibido
            cboCodCategoria.ValueMember = "CategoryID";

            // Exibe um código da categoria dentro da label
            lblCodCategoria.Text = cboCodCategoria.SelectedValue.ToString();

            // Repetição dos procedimentos para a ComboBox Supplier(Fornecedor)
            cboSupplier.DataSource = tblProducts;
            cboSupplier.DisplayMember = "CompanyName";
            cboSupplier.ValueMember = "SupplierID";

            lblSupplier.Text = cboSupplier.SelectedValue.ToString();
        }

        private void Cbocodcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Atualiza a label do código da categoria
            lblCodCategoria.Text = cboCodCategoria.SelectedValue.ToString();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btgravar_Click(object sender, EventArgs e)
        {
            strsql = "INSERT INTO veiculos (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) " +
                "VALUES ('" + txtNome.Text + "','" + cboSupplier.SelectedValue + "','" + cboCodCategoria.SelectedValue + "','" + txtQtde.Text + "','" + txtUnitInStock.Text + "','" + txtUnitInOrder.Text + "','" + txtReorder.Text + "','" + txtDesc.Text + "')";
            comando = new SqlCommand(strsql, conexao);
            comando.ExecuteNonQuery();
            MessageBox.Show("Gravado com sucesso!", "mensagem");
        }
    }
}
