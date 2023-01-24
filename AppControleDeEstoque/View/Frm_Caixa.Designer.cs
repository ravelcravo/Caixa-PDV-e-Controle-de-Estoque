namespace AppControleDeEstoque
{
    partial class Frm_Caixa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatusCaixa = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panell = new System.Windows.Forms.Panel();
            this.ListVenda = new System.Windows.Forms.ListView();
            this.txbCodBarras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txbQtd = new System.Windows.Forms.TextBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panell.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblStatusCaixa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 41);
            this.panel1.TabIndex = 0;
            // 
            // lblStatusCaixa
            // 
            this.lblStatusCaixa.BackColor = System.Drawing.Color.Teal;
            this.lblStatusCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCaixa.ForeColor = System.Drawing.Color.White;
            this.lblStatusCaixa.Location = new System.Drawing.Point(0, 0);
            this.lblStatusCaixa.Name = "lblStatusCaixa";
            this.lblStatusCaixa.Size = new System.Drawing.Size(1038, 41);
            this.lblStatusCaixa.TabIndex = 0;
            this.lblStatusCaixa.Text = "CAIXA LIVRE";
            this.lblStatusCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 588);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 44);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txbQtd);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txbCodBarras);
            this.panel3.Controls.Add(this.panell);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1038, 547);
            this.panel3.TabIndex = 2;
            // 
            // panell
            // 
            this.panell.Controls.Add(this.ListVenda);
            this.panell.Location = new System.Drawing.Point(24, 195);
            this.panell.Name = "panell";
            this.panell.Size = new System.Drawing.Size(990, 346);
            this.panell.TabIndex = 0;
            // 
            // ListVenda
            // 
            this.ListVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListVenda.HideSelection = false;
            this.ListVenda.Location = new System.Drawing.Point(0, 0);
            this.ListVenda.Name = "ListVenda";
            this.ListVenda.Size = new System.Drawing.Size(990, 346);
            this.ListVenda.TabIndex = 0;
            this.ListVenda.UseCompatibleStateImageBehavior = false;
            // 
            // txbCodBarras
            // 
            this.txbCodBarras.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txbCodBarras.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.txbCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodBarras.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txbCodBarras.Location = new System.Drawing.Point(24, 67);
            this.txbCodBarras.Multiline = true;
            this.txbCodBarras.Name = "txbCodBarras";
            this.txbCodBarras.Size = new System.Drawing.Size(483, 66);
            this.txbCodBarras.TabIndex = 1;
            this.txbCodBarras.WordWrap = false;
            this.txbCodBarras.TextChanged += new System.EventHandler(this.txbCodBarras_TextChanged_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código de Barras:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cupom fiscal:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(864, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(791, 42);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(223, 127);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "0,00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbQtd
            // 
            this.txbQtd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txbQtd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.txbQtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQtd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txbQtd.Location = new System.Drawing.Point(513, 67);
            this.txbQtd.Multiline = true;
            this.txbQtd.Name = "txbQtd";
            this.txbQtd.Size = new System.Drawing.Size(88, 66);
            this.txbQtd.TabIndex = 6;
            this.txbQtd.WordWrap = false;
            this.txbQtd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbQtd_KeyDown);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(519, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 41);
            this.label4.TabIndex = 7;
            this.label4.Text = "Qtd:";
            // 
            // Frm_Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1038, 632);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1038, 632);
            this.MinimumSize = new System.Drawing.Size(1038, 632);
            this.Name = "Frm_Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Caixa_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panell.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStatusCaixa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panell;
        private System.Windows.Forms.ListView ListVenda;
        private System.Windows.Forms.TextBox txbCodBarras;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbQtd;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}

