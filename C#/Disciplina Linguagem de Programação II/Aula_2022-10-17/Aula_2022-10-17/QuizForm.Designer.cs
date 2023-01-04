namespace Aula_2022_10_17
{
    partial class QuizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblacertos = new System.Windows.Forms.Label();
            this.lblerros = new System.Windows.Forms.Label();
            this.grupo = new System.Windows.Forms.GroupBox();
            this.btiniciar = new System.Windows.Forms.Button();
            this.btproxima = new System.Windows.Forms.Button();
            this.resp4 = new System.Windows.Forms.RadioButton();
            this.resp3 = new System.Windows.Forms.RadioButton();
            this.resp2 = new System.Windows.Forms.RadioButton();
            this.resp1 = new System.Windows.Forms.RadioButton();
            this.lblassunto = new System.Windows.Forms.Label();
            this.cboassunto = new System.Windows.Forms.ComboBox();
            this.lblpergunta = new System.Windows.Forms.Label();
            this.grupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblacertos
            // 
            this.lblacertos.AutoSize = true;
            this.lblacertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblacertos.Location = new System.Drawing.Point(48, 89);
            this.lblacertos.Name = "lblacertos";
            this.lblacertos.Size = new System.Drawing.Size(58, 15);
            this.lblacertos.TabIndex = 0;
            this.lblacertos.Text = "Acertos:";
            // 
            // lblerros
            // 
            this.lblerros.AutoSize = true;
            this.lblerros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerros.Location = new System.Drawing.Point(315, 89);
            this.lblerros.Name = "lblerros";
            this.lblerros.Size = new System.Drawing.Size(45, 15);
            this.lblerros.TabIndex = 1;
            this.lblerros.Text = "Erros:";
            // 
            // grupo
            // 
            this.grupo.Controls.Add(this.lblpergunta);
            this.grupo.Controls.Add(this.btproxima);
            this.grupo.Controls.Add(this.resp4);
            this.grupo.Controls.Add(this.resp3);
            this.grupo.Controls.Add(this.resp2);
            this.grupo.Controls.Add(this.resp1);
            this.grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupo.Location = new System.Drawing.Point(32, 146);
            this.grupo.Name = "grupo";
            this.grupo.Size = new System.Drawing.Size(706, 275);
            this.grupo.TabIndex = 2;
            this.grupo.TabStop = false;
            this.grupo.Text = "Perguntas";
            // 
            // btiniciar
            // 
            this.btiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btiniciar.Location = new System.Drawing.Point(318, 443);
            this.btiniciar.Name = "btiniciar";
            this.btiniciar.Size = new System.Drawing.Size(75, 23);
            this.btiniciar.TabIndex = 5;
            this.btiniciar.Text = "Iniciar";
            this.btiniciar.UseVisualStyleBackColor = true;
            this.btiniciar.Click += new System.EventHandler(this.Btiniciar_Click);
            // 
            // btproxima
            // 
            this.btproxima.Location = new System.Drawing.Point(286, 241);
            this.btproxima.Name = "btproxima";
            this.btproxima.Size = new System.Drawing.Size(75, 23);
            this.btproxima.TabIndex = 4;
            this.btproxima.Text = "Próxima";
            this.btproxima.UseVisualStyleBackColor = true;
            this.btproxima.Click += new System.EventHandler(this.Btproxima_Click);
            // 
            // resp4
            // 
            this.resp4.AutoSize = true;
            this.resp4.Location = new System.Drawing.Point(68, 206);
            this.resp4.Name = "resp4";
            this.resp4.Size = new System.Drawing.Size(69, 19);
            this.resp4.TabIndex = 3;
            this.resp4.TabStop = true;
            this.resp4.Text = "resp. 4";
            this.resp4.UseVisualStyleBackColor = true;
            this.resp4.CheckedChanged += new System.EventHandler(this.Resp4_CheckedChanged);
            // 
            // resp3
            // 
            this.resp3.AutoSize = true;
            this.resp3.Location = new System.Drawing.Point(68, 156);
            this.resp3.Name = "resp3";
            this.resp3.Size = new System.Drawing.Size(69, 19);
            this.resp3.TabIndex = 2;
            this.resp3.TabStop = true;
            this.resp3.Text = "resp. 3";
            this.resp3.UseVisualStyleBackColor = true;
            this.resp3.CheckedChanged += new System.EventHandler(this.Resp3_CheckedChanged);
            // 
            // resp2
            // 
            this.resp2.AutoSize = true;
            this.resp2.Location = new System.Drawing.Point(68, 109);
            this.resp2.Name = "resp2";
            this.resp2.Size = new System.Drawing.Size(69, 19);
            this.resp2.TabIndex = 1;
            this.resp2.TabStop = true;
            this.resp2.Text = "resp. 2";
            this.resp2.UseVisualStyleBackColor = true;
            this.resp2.CheckedChanged += new System.EventHandler(this.Resp2_CheckedChanged);
            // 
            // resp1
            // 
            this.resp1.AutoSize = true;
            this.resp1.Location = new System.Drawing.Point(68, 66);
            this.resp1.Name = "resp1";
            this.resp1.Size = new System.Drawing.Size(69, 19);
            this.resp1.TabIndex = 0;
            this.resp1.TabStop = true;
            this.resp1.Text = "resp. 1";
            this.resp1.UseVisualStyleBackColor = true;
            this.resp1.CheckedChanged += new System.EventHandler(this.Resp1_CheckedChanged);
            // 
            // lblassunto
            // 
            this.lblassunto.AutoSize = true;
            this.lblassunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblassunto.Location = new System.Drawing.Point(48, 46);
            this.lblassunto.Name = "lblassunto";
            this.lblassunto.Size = new System.Drawing.Size(61, 15);
            this.lblassunto.TabIndex = 3;
            this.lblassunto.Text = "Assunto:";
            // 
            // cboassunto
            // 
            this.cboassunto.FormattingEnabled = true;
            this.cboassunto.Location = new System.Drawing.Point(137, 45);
            this.cboassunto.Name = "cboassunto";
            this.cboassunto.Size = new System.Drawing.Size(121, 21);
            this.cboassunto.TabIndex = 4;
            // 
            // lblpergunta
            // 
            this.lblpergunta.AutoSize = true;
            this.lblpergunta.Location = new System.Drawing.Point(288, 70);
            this.lblpergunta.Name = "lblpergunta";
            this.lblpergunta.Size = new System.Drawing.Size(64, 15);
            this.lblpergunta.TabIndex = 6;
            this.lblpergunta.Text = "pergunta";
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.cboassunto);
            this.Controls.Add(this.btiniciar);
            this.Controls.Add(this.lblassunto);
            this.Controls.Add(this.grupo);
            this.Controls.Add(this.lblerros);
            this.Controls.Add(this.lblacertos);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.grupo.ResumeLayout(false);
            this.grupo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblacertos;
        private System.Windows.Forms.Label lblerros;
        private System.Windows.Forms.GroupBox grupo;
        private System.Windows.Forms.Button btiniciar;
        private System.Windows.Forms.Button btproxima;
        private System.Windows.Forms.RadioButton resp4;
        private System.Windows.Forms.RadioButton resp3;
        private System.Windows.Forms.RadioButton resp2;
        private System.Windows.Forms.RadioButton resp1;
        private System.Windows.Forms.Label lblassunto;
        private System.Windows.Forms.ComboBox cboassunto;
        private System.Windows.Forms.Label lblpergunta;
    }
}