namespace Aula3
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
            this.btcalcular = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.lblnasc = new System.Windows.Forms.Label();
            this.lblatual = new System.Windows.Forms.Label();
            this.lblidade = new System.Windows.Forms.Label();
            this.txtnasc = new System.Windows.Forms.TextBox();
            this.txtatual = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.picfig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picfig)).BeginInit();
            this.SuspendLayout();
            // 
            // btcalcular
            // 
            this.btcalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcalcular.Location = new System.Drawing.Point(221, 384);
            this.btcalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btcalcular.Name = "btcalcular";
            this.btcalcular.Size = new System.Drawing.Size(86, 29);
            this.btcalcular.TabIndex = 0;
            this.btcalcular.Text = "Calcular";
            this.btcalcular.UseVisualStyleBackColor = true;
            this.btcalcular.Click += new System.EventHandler(this.Btcalcular_Click);
            // 
            // btlimpar
            // 
            this.btlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpar.Location = new System.Drawing.Point(376, 384);
            this.btlimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(86, 29);
            this.btlimpar.TabIndex = 0;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.Btlimpar_Click);
            // 
            // lblnasc
            // 
            this.lblnasc.AutoSize = true;
            this.lblnasc.BackColor = System.Drawing.Color.Transparent;
            this.lblnasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnasc.Location = new System.Drawing.Point(30, 105);
            this.lblnasc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnasc.Name = "lblnasc";
            this.lblnasc.Size = new System.Drawing.Size(80, 16);
            this.lblnasc.TabIndex = 1;
            this.lblnasc.Text = "Ano nasc.:";
            this.lblnasc.Click += new System.EventHandler(this.Lblnasc_Click);
            // 
            // lblatual
            // 
            this.lblatual.AutoSize = true;
            this.lblatual.BackColor = System.Drawing.Color.Transparent;
            this.lblatual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblatual.Location = new System.Drawing.Point(30, 189);
            this.lblatual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblatual.Name = "lblatual";
            this.lblatual.Size = new System.Drawing.Size(78, 16);
            this.lblatual.TabIndex = 1;
            this.lblatual.Text = "Ano Atual:";
            this.lblatual.Click += new System.EventHandler(this.Lblatual_Click);
            // 
            // lblidade
            // 
            this.lblidade.AutoSize = true;
            this.lblidade.BackColor = System.Drawing.Color.Transparent;
            this.lblidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidade.Location = new System.Drawing.Point(30, 265);
            this.lblidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidade.Name = "lblidade";
            this.lblidade.Size = new System.Drawing.Size(52, 16);
            this.lblidade.TabIndex = 1;
            this.lblidade.Text = "Idade:";
            this.lblidade.Click += new System.EventHandler(this.Lblidade_Click);
            // 
            // txtnasc
            // 
            this.txtnasc.Location = new System.Drawing.Point(148, 105);
            this.txtnasc.Margin = new System.Windows.Forms.Padding(4);
            this.txtnasc.Name = "txtnasc";
            this.txtnasc.Size = new System.Drawing.Size(93, 22);
            this.txtnasc.TabIndex = 2;
            // 
            // txtatual
            // 
            this.txtatual.Location = new System.Drawing.Point(148, 183);
            this.txtatual.Margin = new System.Windows.Forms.Padding(4);
            this.txtatual.Name = "txtatual";
            this.txtatual.Size = new System.Drawing.Size(93, 22);
            this.txtatual.TabIndex = 2;
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(148, 262);
            this.txtidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(93, 22);
            this.txtidade.TabIndex = 2;
            // 
            // picfig
            // 
            this.picfig.BackColor = System.Drawing.Color.Transparent;
            this.picfig.Location = new System.Drawing.Point(290, 92);
            this.picfig.Margin = new System.Windows.Forms.Padding(4);
            this.picfig.Name = "picfig";
            this.picfig.Size = new System.Drawing.Size(320, 206);
            this.picfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picfig.TabIndex = 3;
            this.picfig.TabStop = false;
            this.picfig.Click += new System.EventHandler(this.Picfig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aula3.Properties.Resources.background_g76bff9b50_640;
            this.ClientSize = new System.Drawing.Size(640, 477);
            this.Controls.Add(this.picfig);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.txtatual);
            this.Controls.Add(this.txtnasc);
            this.Controls.Add(this.lblidade);
            this.Controls.Add(this.lblatual);
            this.Controls.Add(this.lblnasc);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btcalcular);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcalcular;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.Label lblnasc;
        private System.Windows.Forms.Label lblatual;
        private System.Windows.Forms.Label lblidade;
        private System.Windows.Forms.TextBox txtnasc;
        private System.Windows.Forms.TextBox txtatual;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.PictureBox picfig;
    }
}

