// Utilize o banco de dados NORTHWIND!
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // Biblioteca SQL
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_2022_10_31___Subconsulta
{
    public partial class Form1 : Form
    {
        // Variáveis
        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private DataTable tblcustomers, tblorders;
        private string strconex, strsql;
        private int linha = 0;

        private void Brpri_Click(object sender, EventArgs e)
        {
            if (linha != 0)
            {
                // retorna ao primeiro index da tabela
                linha = 0;
                mostrarRegistro();
            }
            else
            {
                MessageBox.Show("Você já chegou ao inicio!");
            }
        }

        private void Btbuilt_Click(object sender, EventArgs e)
        {
            if (linha != tblcustomers.Rows.Count - 1)
            {
                // Obtém o último index da tabela e o atribui à linha atual.
                linha = tblcustomers.Rows.Count - 1;
                mostrarRegistro();
            }
            else
            {
                MessageBox.Show("Você já chegou ao início!");
            }
        }

        private void Btpro_Click(object sender, EventArgs e)
        {
            if (linha != tblcustomers.Rows.Count - 1)
            {
                linha++;
                mostrarRegistro();
            } else
            {
                MessageBox.Show("Você já chegou ao fim!");
            }            
        }

        private void Btant_Click(object sender, EventArgs e)
        {
            if (linha != 0)
            {
                linha--;
                mostrarRegistro();
            }
            else
            {
                MessageBox.Show("Você já chegou ao inicio!");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            strconex = "data source=(local); initial catalog= Northwind; integrated security=sspi";
            conexao = new SqlConnection(strconex);
            conexao.Open();

            tblcustomers = new DataTable();

            strsql = "SELECT * FROM Customers";
            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblcustomers);
            mostrarRegistro();
        }
        /// <summary>
        /// Atualiza todo o formulário e move valores da tabela categorias para a veículos.
        /// </summary>
        private void mostrarRegistro()
        {
            txtcustomerID.Text = tblcustomers.Rows[linha]["CustomerID"].ToString();
            txtcontact.Text = tblcustomers.Rows[linha]["ContactName"].ToString();
            txtcompany.Text = tblcustomers.Rows[linha]["CompanyName"].ToString();
            txtcountry.Text = tblcustomers.Rows[linha]["Country"].ToString();

            // Instanciando tabela de dados veículos
            tblorders = new DataTable();

            strsql = "SELECT * FROM Orders WHERE CustomerID='" + txtcustomerID.Text + "'";
            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblorders);
            grade.DataSource = tblorders;
        }
    }
}
