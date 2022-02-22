namespace Exercicio_aula2
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
            this.label_diametro = new System.Windows.Forms.Label();
            this.label_velocidade = new System.Windows.Forms.Label();
            this.label_densidade = new System.Windows.Forms.Label();
            this.label_viscosidade = new System.Windows.Forms.Label();
            this.diametro = new System.Windows.Forms.TextBox();
            this.velocidade = new System.Windows.Forms.TextBox();
            this.densidade = new System.Windows.Forms.TextBox();
            this.viscosidade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular o  Número de Reynolds";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label_diametro
            // 
            this.label_diametro.AutoSize = true;
            this.label_diametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_diametro.Location = new System.Drawing.Point(130, 122);
            this.label_diametro.Name = "label_diametro";
            this.label_diametro.Size = new System.Drawing.Size(61, 15);
            this.label_diametro.TabIndex = 1;
            this.label_diametro.Text = "Diâmetro:";
            this.label_diametro.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label_velocidade
            // 
            this.label_velocidade.AutoSize = true;
            this.label_velocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_velocidade.Location = new System.Drawing.Point(130, 174);
            this.label_velocidade.Name = "label_velocidade";
            this.label_velocidade.Size = new System.Drawing.Size(71, 15);
            this.label_velocidade.TabIndex = 2;
            this.label_velocidade.Text = "Velocidade:";
            // 
            // label_densidade
            // 
            this.label_densidade.AutoSize = true;
            this.label_densidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_densidade.Location = new System.Drawing.Point(130, 236);
            this.label_densidade.Name = "label_densidade";
            this.label_densidade.Size = new System.Drawing.Size(70, 15);
            this.label_densidade.TabIndex = 3;
            this.label_densidade.Text = "Densidade:";
            // 
            // label_viscosidade
            // 
            this.label_viscosidade.AutoSize = true;
            this.label_viscosidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_viscosidade.Location = new System.Drawing.Point(130, 290);
            this.label_viscosidade.Name = "label_viscosidade";
            this.label_viscosidade.Size = new System.Drawing.Size(76, 15);
            this.label_viscosidade.TabIndex = 3;
            this.label_viscosidade.Text = "Viscosidade:";
            // 
            // diametro
            // 
            this.diametro.Location = new System.Drawing.Point(280, 122);
            this.diametro.Name = "diametro";
            this.diametro.Size = new System.Drawing.Size(100, 20);
            this.diametro.TabIndex = 4;
            // 
            // velocidade
            // 
            this.velocidade.Location = new System.Drawing.Point(280, 173);
            this.velocidade.Name = "velocidade";
            this.velocidade.Size = new System.Drawing.Size(100, 20);
            this.velocidade.TabIndex = 4;
            // 
            // densidade
            // 
            this.densidade.Location = new System.Drawing.Point(280, 235);
            this.densidade.Name = "densidade";
            this.densidade.Size = new System.Drawing.Size(100, 20);
            this.densidade.TabIndex = 4;
            // 
            // viscosidade
            // 
            this.viscosidade.Location = new System.Drawing.Point(280, 289);
            this.viscosidade.Name = "viscosidade";
            this.viscosidade.Size = new System.Drawing.Size(100, 20);
            this.viscosidade.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(208, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viscosidade);
            this.Controls.Add(this.densidade);
            this.Controls.Add(this.velocidade);
            this.Controls.Add(this.diametro);
            this.Controls.Add(this.label_viscosidade);
            this.Controls.Add(this.label_densidade);
            this.Controls.Add(this.label_velocidade);
            this.Controls.Add(this.label_diametro);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_diametro;
        private System.Windows.Forms.Label label_velocidade;
        private System.Windows.Forms.Label label_densidade;
        private System.Windows.Forms.Label label_viscosidade;
        private System.Windows.Forms.TextBox diametro;
        private System.Windows.Forms.TextBox velocidade;
        private System.Windows.Forms.TextBox densidade;
        private System.Windows.Forms.TextBox viscosidade;
        private System.Windows.Forms.Button button1;
    }
}

