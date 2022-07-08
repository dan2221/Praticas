namespace lista
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
            this.cblegumes = new System.Windows.Forms.ComboBox();
            this.lstfrutas = new System.Windows.Forms.ListBox();
            this.bttamanho = new System.Windows.Forms.Button();
            this.btindice = new System.Windows.Forms.Button();
            this.btitem = new System.Windows.Forms.Button();
            this.btadicionar = new System.Windows.Forms.Button();
            this.btremover = new System.Windows.Forms.Button();
            this.btremovertudo = new System.Windows.Forms.Button();
            this.lblitem = new System.Windows.Forms.Label();
            this.lblindice = new System.Windows.Forms.Label();
            this.lbltamanho = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfruta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Legumes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frutas";
            // 
            // cblegumes
            // 
            this.cblegumes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblegumes.FormattingEnabled = true;
            this.cblegumes.Items.AddRange(new object[] {
            "cenoura",
            "beterraba",
            "batata",
            "chuchu",
            "alface",
            "agrião",
            "jiló",
            "quiabo",
            "mandioca"});
            this.cblegumes.Location = new System.Drawing.Point(49, 70);
            this.cblegumes.Name = "cblegumes";
            this.cblegumes.Size = new System.Drawing.Size(109, 23);
            this.cblegumes.TabIndex = 2;
            // 
            // lstfrutas
            // 
            this.lstfrutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstfrutas.FormattingEnabled = true;
            this.lstfrutas.ItemHeight = 15;
            this.lstfrutas.Items.AddRange(new object[] {
            "abacaxi",
            "banana",
            "cereja",
            "jaca",
            "laranja",
            "limão",
            "maçã",
            "mamão",
            "manga",
            "morango",
            "uva"});
            this.lstfrutas.Location = new System.Drawing.Point(238, 70);
            this.lstfrutas.Name = "lstfrutas";
            this.lstfrutas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstfrutas.Size = new System.Drawing.Size(120, 94);
            this.lstfrutas.Sorted = true;
            this.lstfrutas.TabIndex = 3;
            this.lstfrutas.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // bttamanho
            // 
            this.bttamanho.BackColor = System.Drawing.Color.Transparent;
            this.bttamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttamanho.Location = new System.Drawing.Point(49, 194);
            this.bttamanho.Name = "bttamanho";
            this.bttamanho.Size = new System.Drawing.Size(75, 23);
            this.bttamanho.TabIndex = 4;
            this.bttamanho.Text = "Tamanho";
            this.bttamanho.UseVisualStyleBackColor = false;
            this.bttamanho.Click += new System.EventHandler(this.Bttamanho_Click);
            // 
            // btindice
            // 
            this.btindice.BackColor = System.Drawing.Color.Transparent;
            this.btindice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btindice.Location = new System.Drawing.Point(49, 231);
            this.btindice.Name = "btindice";
            this.btindice.Size = new System.Drawing.Size(75, 23);
            this.btindice.TabIndex = 5;
            this.btindice.Text = "Índice";
            this.btindice.UseVisualStyleBackColor = false;
            this.btindice.Click += new System.EventHandler(this.Btindice_Click);
            // 
            // btitem
            // 
            this.btitem.BackColor = System.Drawing.Color.Transparent;
            this.btitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btitem.Location = new System.Drawing.Point(49, 270);
            this.btitem.Name = "btitem";
            this.btitem.Size = new System.Drawing.Size(75, 23);
            this.btitem.TabIndex = 6;
            this.btitem.Text = "Item";
            this.btitem.UseVisualStyleBackColor = false;
            this.btitem.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btadicionar
            // 
            this.btadicionar.BackColor = System.Drawing.Color.Transparent;
            this.btadicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadicionar.Location = new System.Drawing.Point(49, 305);
            this.btadicionar.Name = "btadicionar";
            this.btadicionar.Size = new System.Drawing.Size(75, 23);
            this.btadicionar.TabIndex = 7;
            this.btadicionar.Text = "Adicionar";
            this.btadicionar.UseVisualStyleBackColor = false;
            this.btadicionar.Click += new System.EventHandler(this.Btadicionar_Click);
            // 
            // btremover
            // 
            this.btremover.BackColor = System.Drawing.Color.Transparent;
            this.btremover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btremover.Location = new System.Drawing.Point(49, 344);
            this.btremover.Name = "btremover";
            this.btremover.Size = new System.Drawing.Size(75, 23);
            this.btremover.TabIndex = 8;
            this.btremover.Text = "Remover";
            this.btremover.UseVisualStyleBackColor = false;
            this.btremover.Click += new System.EventHandler(this.Button5_Click);
            // 
            // btremovertudo
            // 
            this.btremovertudo.BackColor = System.Drawing.Color.Transparent;
            this.btremovertudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btremovertudo.Location = new System.Drawing.Point(49, 379);
            this.btremovertudo.Name = "btremovertudo";
            this.btremovertudo.Size = new System.Drawing.Size(116, 23);
            this.btremovertudo.TabIndex = 9;
            this.btremovertudo.Text = "Remover Tudo";
            this.btremovertudo.UseVisualStyleBackColor = false;
            this.btremovertudo.Click += new System.EventHandler(this.Button6_Click);
            // 
            // lblitem
            // 
            this.lblitem.AutoSize = true;
            this.lblitem.BackColor = System.Drawing.Color.Transparent;
            this.lblitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitem.Location = new System.Drawing.Point(235, 275);
            this.lblitem.Name = "lblitem";
            this.lblitem.Size = new System.Drawing.Size(19, 15);
            this.lblitem.TabIndex = 10;
            this.lblitem.Text = "...";
            // 
            // lblindice
            // 
            this.lblindice.AutoSize = true;
            this.lblindice.BackColor = System.Drawing.Color.Transparent;
            this.lblindice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblindice.Location = new System.Drawing.Point(235, 236);
            this.lblindice.Name = "lblindice";
            this.lblindice.Size = new System.Drawing.Size(19, 15);
            this.lblindice.TabIndex = 11;
            this.lblindice.Text = "...";
            // 
            // lbltamanho
            // 
            this.lbltamanho.AutoSize = true;
            this.lbltamanho.BackColor = System.Drawing.Color.Transparent;
            this.lbltamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltamanho.Location = new System.Drawing.Point(235, 199);
            this.lbltamanho.Name = "lbltamanho";
            this.lbltamanho.Size = new System.Drawing.Size(19, 15);
            this.lbltamanho.TabIndex = 12;
            this.lbltamanho.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Dig. a Fruta:";
            // 
            // txtfruta
            // 
            this.txtfruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfruta.Location = new System.Drawing.Point(327, 307);
            this.txtfruta.Name = "txtfruta";
            this.txtfruta.Size = new System.Drawing.Size(100, 21);
            this.txtfruta.TabIndex = 14;
            this.txtfruta.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lista.Properties.Resources.apples_g193534066_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.txtfruta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltamanho);
            this.Controls.Add(this.lblindice);
            this.Controls.Add(this.lblitem);
            this.Controls.Add(this.btremovertudo);
            this.Controls.Add(this.btremover);
            this.Controls.Add(this.btadicionar);
            this.Controls.Add(this.btitem);
            this.Controls.Add(this.btindice);
            this.Controls.Add(this.bttamanho);
            this.Controls.Add(this.lstfrutas);
            this.Controls.Add(this.cblegumes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cblegumes;
        private System.Windows.Forms.ListBox lstfrutas;
        private System.Windows.Forms.Button bttamanho;
        private System.Windows.Forms.Button btindice;
        private System.Windows.Forms.Button btitem;
        private System.Windows.Forms.Button btadicionar;
        private System.Windows.Forms.Button btremover;
        private System.Windows.Forms.Button btremovertudo;
        private System.Windows.Forms.Label lblitem;
        private System.Windows.Forms.Label lblindice;
        private System.Windows.Forms.Label lbltamanho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfruta;
    }
}

