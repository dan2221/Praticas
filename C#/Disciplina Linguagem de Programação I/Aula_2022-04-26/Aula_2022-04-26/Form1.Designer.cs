namespace Aula_2022_04_26
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
            this.btcores = new System.Windows.Forms.Button();
            this.btfonte = new System.Windows.Forms.Button();
            this.btabrir = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.btpasta = new System.Windows.Forms.Button();
            this.cores = new System.Windows.Forms.ColorDialog();
            this.pasta = new System.Windows.Forms.FolderBrowserDialog();
            this.fonte = new System.Windows.Forms.FontDialog();
            this.abrir = new System.Windows.Forms.OpenFileDialog();
            this.salvar = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.figura = new System.Windows.Forms.PictureBox();
            this.imprimir = new System.Windows.Forms.PrintDialog();
            this.btimprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.figura)).BeginInit();
            this.SuspendLayout();
            // 
            // btcores
            // 
            this.btcores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcores.Location = new System.Drawing.Point(78, 93);
            this.btcores.Name = "btcores";
            this.btcores.Size = new System.Drawing.Size(75, 23);
            this.btcores.TabIndex = 0;
            this.btcores.Text = "Cores";
            this.btcores.UseVisualStyleBackColor = true;
            this.btcores.Click += new System.EventHandler(this.Btcores_Click);
            // 
            // btfonte
            // 
            this.btfonte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfonte.Location = new System.Drawing.Point(78, 143);
            this.btfonte.Name = "btfonte";
            this.btfonte.Size = new System.Drawing.Size(75, 23);
            this.btfonte.TabIndex = 1;
            this.btfonte.Text = "Fonte";
            this.btfonte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btfonte.UseVisualStyleBackColor = true;
            this.btfonte.Click += new System.EventHandler(this.Btfonte_Click);
            // 
            // btabrir
            // 
            this.btabrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btabrir.Location = new System.Drawing.Point(78, 194);
            this.btabrir.Name = "btabrir";
            this.btabrir.Size = new System.Drawing.Size(75, 23);
            this.btabrir.TabIndex = 2;
            this.btabrir.Text = "Abrir";
            this.btabrir.UseVisualStyleBackColor = true;
            this.btabrir.Click += new System.EventHandler(this.Btabrir_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsalvar.Location = new System.Drawing.Point(78, 249);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(75, 23);
            this.btsalvar.TabIndex = 3;
            this.btsalvar.Text = "Salvar";
            this.btsalvar.UseVisualStyleBackColor = true;
            this.btsalvar.Click += new System.EventHandler(this.Btsalvar_Click);
            // 
            // btpasta
            // 
            this.btpasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpasta.Location = new System.Drawing.Point(78, 300);
            this.btpasta.Name = "btpasta";
            this.btpasta.Size = new System.Drawing.Size(75, 23);
            this.btpasta.TabIndex = 4;
            this.btpasta.Text = "Pasta";
            this.btpasta.UseVisualStyleBackColor = true;
            this.btpasta.Click += new System.EventHandler(this.Btpasta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // figura
            // 
            this.figura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.figura.Location = new System.Drawing.Point(324, 98);
            this.figura.Name = "figura";
            this.figura.Size = new System.Drawing.Size(238, 214);
            this.figura.TabIndex = 6;
            this.figura.TabStop = false;
            // 
            // imprimir
            // 
            this.imprimir.UseEXDialog = true;
            // 
            // btimprimir
            // 
            this.btimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btimprimir.Location = new System.Drawing.Point(403, 353);
            this.btimprimir.Name = "btimprimir";
            this.btimprimir.Size = new System.Drawing.Size(75, 23);
            this.btimprimir.TabIndex = 7;
            this.btimprimir.Text = "Imprimir";
            this.btimprimir.UseVisualStyleBackColor = true;
            this.btimprimir.Click += new System.EventHandler(this.Btimprimir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 415);
            this.Controls.Add(this.btimprimir);
            this.Controls.Add(this.figura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btpasta);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.btabrir);
            this.Controls.Add(this.btfonte);
            this.Controls.Add(this.btcores);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.figura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcores;
        private System.Windows.Forms.Button btfonte;
        private System.Windows.Forms.Button btabrir;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.Button btpasta;
        private System.Windows.Forms.ColorDialog cores;
        private System.Windows.Forms.FolderBrowserDialog pasta;
        private System.Windows.Forms.FontDialog fonte;
        private System.Windows.Forms.OpenFileDialog abrir;
        private System.Windows.Forms.SaveFileDialog salvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox figura;
        private System.Windows.Forms.PrintDialog imprimir;
        private System.Windows.Forms.Button btimprimir;
    }
}

