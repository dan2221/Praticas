namespace Aula_2022_10_31___Subconsulta
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
            this.brpri = new System.Windows.Forms.Button();
            this.btant = new System.Windows.Forms.Button();
            this.btpro = new System.Windows.Forms.Button();
            this.btbuilt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.txtcodcategoria = new System.Windows.Forms.TextBox();
            this.grade = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grade)).BeginInit();
            this.SuspendLayout();
            // 
            // brpri
            // 
            this.brpri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brpri.Location = new System.Drawing.Point(37, 148);
            this.brpri.Name = "brpri";
            this.brpri.Size = new System.Drawing.Size(75, 23);
            this.brpri.TabIndex = 0;
            this.brpri.Text = "<<";
            this.brpri.UseVisualStyleBackColor = true;
            // 
            // btant
            // 
            this.btant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btant.Location = new System.Drawing.Point(143, 148);
            this.btant.Name = "btant";
            this.btant.Size = new System.Drawing.Size(75, 23);
            this.btant.TabIndex = 1;
            this.btant.Text = "<";
            this.btant.UseVisualStyleBackColor = true;
            // 
            // btpro
            // 
            this.btpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpro.Location = new System.Drawing.Point(263, 148);
            this.btpro.Name = "btpro";
            this.btpro.Size = new System.Drawing.Size(75, 23);
            this.btpro.TabIndex = 2;
            this.btpro.Text = ">";
            this.btpro.UseVisualStyleBackColor = true;
            // 
            // btbuilt
            // 
            this.btbuilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbuilt.Location = new System.Drawing.Point(372, 148);
            this.btbuilt.Name = "btbuilt";
            this.btbuilt.Size = new System.Drawing.Size(75, 23);
            this.btbuilt.TabIndex = 3;
            this.btbuilt.Text = ">>";
            this.btbuilt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cod. Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descrição:";
            // 
            // txtvalor
            // 
            this.txtvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.Location = new System.Drawing.Point(361, 55);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(86, 22);
            this.txtvalor.TabIndex = 8;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.Location = new System.Drawing.Point(139, 88);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(308, 22);
            this.txtdescricao.TabIndex = 9;
            // 
            // txtcategoria
            // 
            this.txtcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategoria.Location = new System.Drawing.Point(139, 55);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(167, 22);
            this.txtcategoria.TabIndex = 10;
            // 
            // txtcodcategoria
            // 
            this.txtcodcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodcategoria.Location = new System.Drawing.Point(139, 25);
            this.txtcodcategoria.Name = "txtcodcategoria";
            this.txtcodcategoria.Size = new System.Drawing.Size(79, 22);
            this.txtcodcategoria.TabIndex = 11;
            // 
            // grade
            // 
            this.grade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade.Location = new System.Drawing.Point(37, 189);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(410, 234);
            this.grade.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.txtcodcategoria);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btbuilt);
            this.Controls.Add(this.btpro);
            this.Controls.Add(this.btant);
            this.Controls.Add(this.brpri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brpri;
        private System.Windows.Forms.Button btant;
        private System.Windows.Forms.Button btpro;
        private System.Windows.Forms.Button btbuilt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.TextBox txtcodcategoria;
        private System.Windows.Forms.DataGridView grade;
    }
}

