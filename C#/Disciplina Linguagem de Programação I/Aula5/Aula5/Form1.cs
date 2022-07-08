using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula5
{
    public partial class Form1 : Form
    {
        public int acrescimo = 30;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
        
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (lblnome.Top <= this.Height - (lblnome.Height + acrescimo * 2))
            {
                lblnome.Top += 20;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (lblnome.Left >= 0)
            {
                lblnome.Left -= 20;
            }
        }

        private void Button1_Click_2(object sender, EventArgs e)
        // Botão direito
        {
            if (lblnome.Left <= this.Width - (lblnome.Width + this.acrescimo))
            {
                lblnome.Left += 20;
            }
        }

        private void Acima_Click(object sender, EventArgs e)
        {
            if (lblnome.Top >= 0)
            {
                lblnome.Top -= 20;
            }
        }
    }
}
