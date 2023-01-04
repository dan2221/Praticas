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
            this.txtcountry = new System.Windows.Forms.TextBox();
            this.txtcompany = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtcustomerID = new System.Windows.Forms.TextBox();
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
            this.brpri.Click += new System.EventHandler(this.Brpri_Click);
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
            this.btant.Click += new System.EventHandler(this.Btant_Click);
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
            this.btpro.Click += new System.EventHandler(this.Btpro_Click);
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
            this.btbuilt.Click += new System.EventHandler(this.Btbuilt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "País:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Compania:";
            // 
            // txtcountry
            // 
            this.txtcountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcountry.Location = new System.Drawing.Point(361, 55);
            this.txtcountry.Name = "txtcountry";
            this.txtcountry.Size = new System.Drawing.Size(86, 22);
            this.txtcountry.TabIndex = 8;
            // 
            // txtcompany
            // 
            this.txtcompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompany.Location = new System.Drawing.Point(139, 88);
            this.txtcompany.Name = "txtcompany";
            this.txtcompany.Size = new System.Drawing.Size(308, 22);
            this.txtcompany.TabIndex = 9;
            // 
            // txtcontact
            // 
            this.txtcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.Location = new System.Drawing.Point(139, 55);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(167, 22);
            this.txtcontact.TabIndex = 10;
            // 
            // txtcustomerID
            // 
            this.txtcustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomerID.Location = new System.Drawing.Point(139, 25);
            this.txtcustomerID.Name = "txtcustomerID";
            this.txtcustomerID.Size = new System.Drawing.Size(79, 22);
            this.txtcustomerID.TabIndex = 11;
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
            this.Controls.Add(this.txtcustomerID);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtcompany);
            this.Controls.Add(this.txtcountry);
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
        private System.Windows.Forms.TextBox txtcountry;
        private System.Windows.Forms.TextBox txtcompany;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.TextBox txtcustomerID;
        private System.Windows.Forms.DataGridView grade;
    }
}

