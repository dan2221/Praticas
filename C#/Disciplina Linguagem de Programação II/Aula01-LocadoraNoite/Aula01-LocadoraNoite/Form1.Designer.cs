namespace Aula01_LocadoraNoite
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
            this.lblmarca = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.grade = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grade)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarca.Location = new System.Drawing.Point(100, 74);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(109, 16);
            this.lblmarca.TabIndex = 0;
            this.lblmarca.Text = "Digite a marca";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(225, 73);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(326, 20);
            this.txtmarca.TabIndex = 1;
            // 
            // btpesquisar
            // 
            this.btpesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpesquisar.Location = new System.Drawing.Point(595, 71);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(89, 23);
            this.btpesquisar.TabIndex = 2;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = true;
            this.btpesquisar.Click += new System.EventHandler(this.Btpesquisar_Click);
            // 
            // grade
            // 
            this.grade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade.Location = new System.Drawing.Point(103, 123);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(581, 292);
            this.grade.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.btpesquisar);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.lblmarca);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.DataGridView grade;
    }
}

