namespace WindowsFormsApp2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amareloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rosaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.pretoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azulToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.roxoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.personalizarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.FuncionáriosToolStripMenuItem,
            this.locaçãoToolStripMenuItem,
            this.veículoToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.clientesToolStripMenuItem.Text = "Cadastro";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
            // 
            // personalizarToolStripMenuItem
            // 
            this.personalizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fundoToolStripMenuItem,
            this.fonteToolStripMenuItem});
            this.personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            this.personalizarToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.personalizarToolStripMenuItem.Text = "Personalizar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // fundoToolStripMenuItem
            // 
            this.fundoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.azulToolStripMenuItem,
            this.amareloToolStripMenuItem,
            this.rosaToolStripMenuItem,
            this.verdeToolStripMenuItem});
            this.fundoToolStripMenuItem.Name = "fundoToolStripMenuItem";
            this.fundoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fundoToolStripMenuItem.Text = "Fundo";
            // 
            // fonteToolStripMenuItem
            // 
            this.fonteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretoToolStripMenuItem,
            this.brancoToolStripMenuItem,
            this.azulToolStripMenuItem1,
            this.roxoToolStripMenuItem});
            this.fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            this.fonteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fonteToolStripMenuItem.Text = "Fonte";
            // 
            // azulToolStripMenuItem
            // 
            this.azulToolStripMenuItem.Name = "azulToolStripMenuItem";
            this.azulToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.azulToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.azulToolStripMenuItem.Text = "Azul";
            this.azulToolStripMenuItem.Click += new System.EventHandler(this.AzulToolStripMenuItem_Click);
            // 
            // amareloToolStripMenuItem
            // 
            this.amareloToolStripMenuItem.Name = "amareloToolStripMenuItem";
            this.amareloToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.amareloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.amareloToolStripMenuItem.Text = "Amarelo";
            this.amareloToolStripMenuItem.Click += new System.EventHandler(this.AmareloToolStripMenuItem_Click);
            // 
            // rosaToolStripMenuItem
            // 
            this.rosaToolStripMenuItem.Name = "rosaToolStripMenuItem";
            this.rosaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.rosaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rosaToolStripMenuItem.Text = "Rosa";
            this.rosaToolStripMenuItem.Click += new System.EventHandler(this.RosaToolStripMenuItem_Click);
            // 
            // verdeToolStripMenuItem
            // 
            this.verdeToolStripMenuItem.Name = "verdeToolStripMenuItem";
            this.verdeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.verdeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verdeToolStripMenuItem.Text = "Verde";
            this.verdeToolStripMenuItem.Click += new System.EventHandler(this.VerdeToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.ClientesToolStripMenuItem1_Click);
            // 
            // FuncionáriosToolStripMenuItem
            // 
            this.FuncionáriosToolStripMenuItem.Name = "FuncionáriosToolStripMenuItem";
            this.FuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FuncionáriosToolStripMenuItem.Text = "Funcionários";
            this.FuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.FuncionáriosToolStripMenuItem_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(231, 202);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(342, 55);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Este é o título!";
            this.lbltitulo.Click += new System.EventHandler(this.Label1_Click);
            // 
            // pretoToolStripMenuItem
            // 
            this.pretoToolStripMenuItem.Name = "pretoToolStripMenuItem";
            this.pretoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pretoToolStripMenuItem.Text = "Preto";
            this.pretoToolStripMenuItem.Click += new System.EventHandler(this.PretoToolStripMenuItem_Click);
            // 
            // brancoToolStripMenuItem
            // 
            this.brancoToolStripMenuItem.Name = "brancoToolStripMenuItem";
            this.brancoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.brancoToolStripMenuItem.Text = "Branco";
            this.brancoToolStripMenuItem.Click += new System.EventHandler(this.BrancoToolStripMenuItem_Click);
            // 
            // azulToolStripMenuItem1
            // 
            this.azulToolStripMenuItem1.Name = "azulToolStripMenuItem1";
            this.azulToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.azulToolStripMenuItem1.Text = "Azul";
            this.azulToolStripMenuItem1.Click += new System.EventHandler(this.AzulToolStripMenuItem1_Click);
            // 
            // roxoToolStripMenuItem
            // 
            this.roxoToolStripMenuItem.Name = "roxoToolStripMenuItem";
            this.roxoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.roxoToolStripMenuItem.Text = "Roxo";
            this.roxoToolStripMenuItem.Click += new System.EventHandler(this.RoxoToolStripMenuItem_Click);
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.locaçãoToolStripMenuItem.Text = "Locação";
            this.locaçãoToolStripMenuItem.Click += new System.EventHandler(this.LocaçãoToolStripMenuItem_Click);
            // 
            // veículoToolStripMenuItem
            // 
            this.veículoToolStripMenuItem.Name = "veículoToolStripMenuItem";
            this.veículoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.veículoToolStripMenuItem.Text = "Veículo";
            this.veículoToolStripMenuItem.Click += new System.EventHandler(this.VeículoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fundoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amareloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rosaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FuncionáriosToolStripMenuItem;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.ToolStripMenuItem pretoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azulToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem roxoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículoToolStripMenuItem;
    }
}

