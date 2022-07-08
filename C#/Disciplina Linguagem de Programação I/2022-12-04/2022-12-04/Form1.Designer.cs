namespace _2022_12_04
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtmedia = new System.Windows.Forms.TextBox();
            this.txttrab = new System.Windows.Forms.TextBox();
            this.txtp2 = new System.Windows.Forms.TextBox();
            this.txtp1 = new System.Windows.Forms.TextBox();
            this.btcalcular = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota P1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota P2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota Trabalho:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Média:";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(248, 293);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(20, 16);
            this.lblresult.TabIndex = 4;
            this.lblresult.Text = "...";
            // 
            // txtmedia
            // 
            this.txtmedia.Enabled = false;
            this.txtmedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmedia.Location = new System.Drawing.Point(317, 231);
            this.txtmedia.Name = "txtmedia";
            this.txtmedia.Size = new System.Drawing.Size(100, 20);
            this.txtmedia.TabIndex = 5;
            // 
            // txttrab
            // 
            this.txttrab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttrab.Location = new System.Drawing.Point(317, 172);
            this.txttrab.Name = "txttrab";
            this.txttrab.Size = new System.Drawing.Size(100, 20);
            this.txttrab.TabIndex = 6;
            // 
            // txtp2
            // 
            this.txtp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtp2.Location = new System.Drawing.Point(317, 105);
            this.txtp2.Name = "txtp2";
            this.txtp2.Size = new System.Drawing.Size(100, 20);
            this.txtp2.TabIndex = 7;
            // 
            // txtp1
            // 
            this.txtp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtp1.Location = new System.Drawing.Point(317, 43);
            this.txtp1.Name = "txtp1";
            this.txtp1.Size = new System.Drawing.Size(100, 20);
            this.txtp1.TabIndex = 8;
            // 
            // btcalcular
            // 
            this.btcalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcalcular.Location = new System.Drawing.Point(124, 339);
            this.btcalcular.Name = "btcalcular";
            this.btcalcular.Size = new System.Drawing.Size(75, 23);
            this.btcalcular.TabIndex = 9;
            this.btcalcular.Text = "Calcular";
            this.btcalcular.UseVisualStyleBackColor = true;
            this.btcalcular.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btlimpar
            // 
            this.btlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpar.Location = new System.Drawing.Point(317, 339);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(75, 23);
            this.btlimpar.TabIndex = 10;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.Btlimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(515, 393);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btcalcular);
            this.Controls.Add(this.txtp1);
            this.Controls.Add(this.txtp2);
            this.Controls.Add(this.txttrab);
            this.Controls.Add(this.txtmedia);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtmedia;
        private System.Windows.Forms.TextBox txttrab;
        private System.Windows.Forms.TextBox txtp2;
        private System.Windows.Forms.TextBox txtp1;
        private System.Windows.Forms.Button btcalcular;
        private System.Windows.Forms.Button btlimpar;
    }
}

