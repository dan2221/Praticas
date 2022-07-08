namespace Aula5
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
            this.lblnome = new System.Windows.Forms.Label();
            this.direita = new System.Windows.Forms.Button();
            this.esquerda = new System.Windows.Forms.Button();
            this.abaixo = new System.Windows.Forms.Button();
            this.acima = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(217, 324);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(51, 16);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "label1";
            // 
            // direita
            // 
            this.direita.Location = new System.Drawing.Point(298, 137);
            this.direita.Name = "direita";
            this.direita.Size = new System.Drawing.Size(75, 23);
            this.direita.TabIndex = 2;
            this.direita.Text = "button1";
            this.direita.UseVisualStyleBackColor = true;
            this.direita.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // esquerda
            // 
            this.esquerda.Location = new System.Drawing.Point(115, 137);
            this.esquerda.Name = "esquerda";
            this.esquerda.Size = new System.Drawing.Size(75, 23);
            this.esquerda.TabIndex = 3;
            this.esquerda.Text = "button2";
            this.esquerda.UseVisualStyleBackColor = true;
            this.esquerda.Click += new System.EventHandler(this.Button2_Click);
            // 
            // abaixo
            // 
            this.abaixo.Location = new System.Drawing.Point(206, 174);
            this.abaixo.Name = "abaixo";
            this.abaixo.Size = new System.Drawing.Size(75, 23);
            this.abaixo.TabIndex = 4;
            this.abaixo.Text = "button3";
            this.abaixo.UseVisualStyleBackColor = true;
            this.abaixo.Click += new System.EventHandler(this.Button3_Click);
            // 
            // acima
            // 
            this.acima.Location = new System.Drawing.Point(206, 90);
            this.acima.Name = "acima";
            this.acima.Size = new System.Drawing.Size(75, 23);
            this.acima.TabIndex = 5;
            this.acima.Text = "button4";
            this.acima.UseVisualStyleBackColor = true;
            this.acima.Click += new System.EventHandler(this.Acima_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.acima);
            this.Controls.Add(this.abaixo);
            this.Controls.Add(this.esquerda);
            this.Controls.Add(this.direita);
            this.Controls.Add(this.lblnome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Button direita;
        private System.Windows.Forms.Button esquerda;
        private System.Windows.Forms.Button abaixo;
        private System.Windows.Forms.Button acima;
    }
}

