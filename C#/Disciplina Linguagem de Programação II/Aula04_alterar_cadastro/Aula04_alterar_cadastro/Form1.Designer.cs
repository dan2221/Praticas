namespace Aula04_alterar_cadastro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grupo1 = new System.Windows.Forms.GroupBox();
            this.grupo2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btgravar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.txtcodcateg = new System.Windows.Forms.TextBox();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.grupo1.SuspendLayout();
            this.grupo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupo1
            // 
            this.grupo1.Controls.Add(this.txtcodcateg);
            this.grupo1.Controls.Add(this.btpesquisar);
            this.grupo1.Controls.Add(this.label1);
            this.grupo1.Location = new System.Drawing.Point(12, 12);
            this.grupo1.Name = "grupo1";
            this.grupo1.Size = new System.Drawing.Size(409, 100);
            this.grupo1.TabIndex = 0;
            this.grupo1.TabStop = false;
            this.grupo1.Text = "groupBox1";
            // 
            // grupo2
            // 
            this.grupo2.Controls.Add(this.txtvalor);
            this.grupo2.Controls.Add(this.txtdescricao);
            this.grupo2.Controls.Add(this.txtcategoria);
            this.grupo2.Controls.Add(this.btcancelar);
            this.grupo2.Controls.Add(this.btgravar);
            this.grupo2.Controls.Add(this.lblcategoria);
            this.grupo2.Controls.Add(this.label3);
            this.grupo2.Controls.Add(this.label4);
            this.grupo2.Location = new System.Drawing.Point(12, 131);
            this.grupo2.Name = "grupo2";
            this.grupo2.Size = new System.Drawing.Size(409, 200);
            this.grupo2.TabIndex = 1;
            this.grupo2.TabStop = false;
            this.grupo2.Text = "groupBox2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod. Categoria:";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(21, 41);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(55, 13);
            this.lblcategoria.TabIndex = 1;
            this.lblcategoria.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor:";
            // 
            // btgravar
            // 
            this.btgravar.Location = new System.Drawing.Point(51, 153);
            this.btgravar.Name = "btgravar";
            this.btgravar.Size = new System.Drawing.Size(75, 23);
            this.btgravar.TabIndex = 4;
            this.btgravar.Text = "Gravar";
            this.btgravar.UseVisualStyleBackColor = true;
            this.btgravar.Click += new System.EventHandler(this.Btgravar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Location = new System.Drawing.Point(250, 153);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(75, 23);
            this.btcancelar.TabIndex = 5;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.Btcancelar_Click);
            // 
            // btpesquisar
            // 
            this.btpesquisar.Location = new System.Drawing.Point(308, 35);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(75, 23);
            this.btpesquisar.TabIndex = 6;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = true;
            this.btpesquisar.Click += new System.EventHandler(this.Btpesquisar_Click);
            // 
            // txtcodcateg
            // 
            this.txtcodcateg.Location = new System.Drawing.Point(118, 37);
            this.txtcodcateg.Name = "txtcodcateg";
            this.txtcodcateg.Size = new System.Drawing.Size(172, 20);
            this.txtcodcateg.TabIndex = 7;
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(118, 38);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(172, 20);
            this.txtcategoria.TabIndex = 7;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(118, 69);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(172, 20);
            this.txtdescricao.TabIndex = 7;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(118, 101);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(172, 20);
            this.txtvalor.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 343);
            this.Controls.Add(this.grupo2);
            this.Controls.Add(this.grupo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grupo1.ResumeLayout(false);
            this.grupo1.PerformLayout();
            this.grupo2.ResumeLayout(false);
            this.grupo2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupo1;
        private System.Windows.Forms.TextBox txtcodcateg;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grupo2;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

