using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb; // Biblioteca para banco de dados.
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_2022_10_17
{
    public partial class QuizForm : Form
    {
        private OleDbConnection conexao;
        private OleDbDataAdapter adapter;
        private DataTable tblperg;
        string strsql, strconex;
        int acertos = 0, erros = 0, linha = 0, quantperg = 0;
        string correta = "", resposta = "";

        private void Resp1_CheckedChanged(object sender, EventArgs e)
        {
            resposta = resp1.Text;
        }

        private void Resp2_CheckedChanged(object sender, EventArgs e)
        {
            resposta = resp2.Text;
        }

        private void Resp3_CheckedChanged(object sender, EventArgs e)
        {
            resposta = resp3.Text;
        }

        private void Resp4_CheckedChanged(object sender, EventArgs e)
        {
            resposta = resp4.Text;
        }

        private void Btproxima_Click(object sender, EventArgs e)
        {
            if (resposta == correta)
            {
                acertos++;
                lblacertos.Text = "Acertos: " + acertos;
            }
            else
            {
                erros++;
                lblerros.Text = "Erros: " + erros;
                MessageBox.Show("A resposta certa era " + correta, "Correta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblassunto.Visible = true;
                cboassunto.Visible = true;
                btiniciar.Visible = true;
                grupo.Visible = false;
            }
            linha++;
            if (linha <= (quantperg - 1))
            {                
                Preencher();
            }
            else
            {
                MessageBox.Show("Quiz finalizado! Obrigado por jogar!", "Fim do quiz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btiniciar_Click(object sender, EventArgs e)
        {
            // Provedor e caminho do banco de dados.
            strconex = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\quiz.accdb";
            conexao = new OleDbConnection(strconex);
            conexao.Open();
            tblperg = new DataTable();
            strsql = "SELECT * FROM perguntas WHERE assunto='"+cboassunto.Text+"'";
            adapter = new OleDbDataAdapter(strsql, conexao);
            adapter.Fill(tblperg);

            lblassunto.Visible = false;
            cboassunto.Visible = false;
            btiniciar.Visible = false;
            grupo.Visible = true;
            quantperg = tblperg.Rows.Count;

            Preencher();
            linha = 0;
            acertos = 0;
            erros = 0;
            correta = "";
            resposta = "";
            Preencher();
        }

        /**
         * Preencher labels e radio buttons.
         */
        private void Preencher()
        {
            lblpergunta.Text = tblperg.Rows[linha]["pergunta"].ToString();
            resp1.Text = tblperg.Rows[linha]["resposta1"].ToString();
            resp2.Text = tblperg.Rows[linha]["resposta2"].ToString();
            resp3.Text = tblperg.Rows[linha]["resposta3"].ToString();
            resp4.Text = tblperg.Rows[linha]["resposta4"].ToString();
            correta = tblperg.Rows[linha]["respostacorreta"].ToString();
            resp1.Checked = true;
            resp1.Checked = false;
        }
        
        public QuizForm()
        {
            InitializeComponent();
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            // Provedor e caminho do banco de dados.
            strconex = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\quiz.accdb";
            conexao = new OleDbConnection(strconex);
            conexao.Open();
            tblperg = new DataTable();
            strsql = " SELECT distinct assunto FROM perguntas";
            adapter = new OleDbDataAdapter(strsql, conexao);
            adapter.Fill(tblperg);
            cboassunto.DataSource = tblperg;
            cboassunto.DisplayMember = "assunto";

            lblassunto.Visible = true;
            cboassunto.Visible = true;
            btiniciar.Visible = true;
            grupo.Visible = false;
        }
    }
}
