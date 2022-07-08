namespace quiz_2022_05_10
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
            this.lblpontos = new System.Windows.Forms.Label();
            this.lblpergunta = new System.Windows.Forms.Label();
            this.grupo = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btproxima = new System.Windows.Forms.Button();
            this.btiniciar = new System.Windows.Forms.Button();
            this.grupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblpontos
            // 
            this.lblpontos.AutoSize = true;
            this.lblpontos.Location = new System.Drawing.Point(361, 40);
            this.lblpontos.Name = "lblpontos";
            this.lblpontos.Size = new System.Drawing.Size(43, 13);
            this.lblpontos.TabIndex = 0;
            this.lblpontos.Text = "Pontos:";
            // 
            // lblpergunta
            // 
            this.lblpergunta.AutoSize = true;
            this.lblpergunta.Location = new System.Drawing.Point(133, 116);
            this.lblpergunta.Name = "lblpergunta";
            this.lblpergunta.Size = new System.Drawing.Size(50, 13);
            this.lblpergunta.TabIndex = 1;
            this.lblpergunta.Text = "Pergunta";
            this.lblpergunta.Click += new System.EventHandler(this.Lblpergunta_Click);
            // 
            // grupo
            // 
            this.grupo.Controls.Add(this.checkedListBox1);
            this.grupo.Controls.Add(this.btproxima);
            this.grupo.Location = new System.Drawing.Point(94, 142);
            this.grupo.Name = "grupo";
            this.grupo.Size = new System.Drawing.Size(634, 247);
            this.grupo.TabIndex = 2;
            this.grupo.TabStop = false;
            this.grupo.Text = "resp1";
            this.grupo.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "resposta1",
            "resposta2",
            "resposta3",
            "resposta4"});
            this.checkedListBox1.Location = new System.Drawing.Point(13, 20);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(126, 139);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
            // 
            // btproxima
            // 
            this.btproxima.Location = new System.Drawing.Point(259, 205);
            this.btproxima.Name = "btproxima";
            this.btproxima.Size = new System.Drawing.Size(75, 23);
            this.btproxima.TabIndex = 3;
            this.btproxima.Text = "Próxima";
            this.btproxima.UseVisualStyleBackColor = true;
            this.btproxima.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btiniciar
            // 
            this.btiniciar.Location = new System.Drawing.Point(353, 395);
            this.btiniciar.Name = "btiniciar";
            this.btiniciar.Size = new System.Drawing.Size(75, 23);
            this.btiniciar.TabIndex = 4;
            this.btiniciar.Text = "Iniciar";
            this.btiniciar.UseVisualStyleBackColor = true;
            this.btiniciar.Click += new System.EventHandler(this.Btiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btiniciar);
            this.Controls.Add(this.grupo);
            this.Controls.Add(this.lblpergunta);
            this.Controls.Add(this.lblpontos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grupo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpontos;
        private System.Windows.Forms.Label lblpergunta;
        private System.Windows.Forms.GroupBox grupo;
        private System.Windows.Forms.Button btproxima;
        private System.Windows.Forms.Button btiniciar;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label pontos;
    }
}

