namespace Aula_2_manha
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtbase = new System.Windows.Forms.TextBox();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.lblbase = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblarea = new System.Windows.Forms.Label();
            this.btcalcular = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbase
            // 
            this.txtbase.BackColor = System.Drawing.SystemColors.Info;
            this.txtbase.Location = new System.Drawing.Point(553, 125);
            this.txtbase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(132, 23);
            this.txtbase.TabIndex = 1;
            this.txtbase.Text = "0";
            // 
            // txtarea
            // 
            this.txtarea.BackColor = System.Drawing.SystemColors.Info;
            this.txtarea.Enabled = false;
            this.txtarea.Location = new System.Drawing.Point(553, 319);
            this.txtarea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(132, 23);
            this.txtarea.TabIndex = 0;
            this.txtarea.Text = "0";
            // 
            // txtaltura
            // 
            this.txtaltura.BackColor = System.Drawing.SystemColors.Info;
            this.txtaltura.Location = new System.Drawing.Point(553, 217);
            this.txtaltura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(132, 23);
            this.txtaltura.TabIndex = 0;
            this.txtaltura.Text = "0";
            // 
            // lblbase
            // 
            this.lblbase.AutoSize = true;
            this.lblbase.BackColor = System.Drawing.Color.Transparent;
            this.lblbase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbase.Location = new System.Drawing.Point(148, 132);
            this.lblbase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbase.Name = "lblbase";
            this.lblbase.Size = new System.Drawing.Size(48, 16);
            this.lblbase.TabIndex = 2;
            this.lblbase.Text = "Base:";
            this.lblbase.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.BackColor = System.Drawing.Color.Transparent;
            this.lblaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaltura.Location = new System.Drawing.Point(148, 224);
            this.lblaltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(52, 16);
            this.lblaltura.TabIndex = 2;
            this.lblaltura.Text = "Altura:";
            this.lblaltura.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.BackColor = System.Drawing.Color.Transparent;
            this.lblarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblarea.Location = new System.Drawing.Point(148, 326);
            this.lblarea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(131, 16);
            this.lblarea.TabIndex = 2;
            this.lblarea.Text = "Área do triângulo:";
            this.lblarea.Click += new System.EventHandler(this.Label3_Click);
            // 
            // btcalcular
            // 
            this.btcalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcalcular.Location = new System.Drawing.Point(260, 442);
            this.btcalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btcalcular.Name = "btcalcular";
            this.btcalcular.Size = new System.Drawing.Size(100, 28);
            this.btcalcular.TabIndex = 3;
            this.btcalcular.Text = "Calcular";
            this.btcalcular.UseVisualStyleBackColor = true;
            this.btcalcular.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btlimpar
            // 
            this.btlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpar.Location = new System.Drawing.Point(428, 442);
            this.btlimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(100, 28);
            this.btlimpar.TabIndex = 3;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(808, 554);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btcalcular);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblbase);
            this.Controls.Add(this.txtbase);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.txtaltura);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Label lblbase;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.Button btcalcular;
        private System.Windows.Forms.Button btlimpar;
    }
}