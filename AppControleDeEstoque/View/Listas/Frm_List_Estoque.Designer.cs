namespace AppControleDeEstoque.View
{
    partial class Frm_List_Estoque
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
            this.btBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.btNovo = new System.Windows.Forms.Button();
            this.GridResultado = new ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btBuscar.Location = new System.Drawing.Point(922, 549);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(104, 41);
            this.btBuscar.TabIndex = 3;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Produtos encontrados:";
            // 
            // lblTotalRows
            // 
            this.lblTotalRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRows.Location = new System.Drawing.Point(230, 47);
            this.lblTotalRows.Name = "lblTotalRows";
            this.lblTotalRows.Size = new System.Drawing.Size(221, 24);
            this.lblTotalRows.TabIndex = 6;
            this.lblTotalRows.Text = "000";
            this.lblTotalRows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btNovo.Location = new System.Drawing.Point(805, 549);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(111, 41);
            this.btNovo.TabIndex = 7;
            this.btNovo.Text = "Adicionar Produto";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // GridResultado
            // 
            this.GridResultado.AutoGenerateContextFilters = true;
            this.GridResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResultado.DateWithTime = false;
            this.GridResultado.Location = new System.Drawing.Point(16, 74);
            this.GridResultado.Name = "GridResultado";
            this.GridResultado.Size = new System.Drawing.Size(1010, 469);
            this.GridResultado.TabIndex = 8;
            this.GridResultado.TimeFilter = false;
            // 
            // Frm_List_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1038, 632);
            this.Controls.Add(this.GridResultado);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.lblTotalRows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1038, 632);
            this.MinimumSize = new System.Drawing.Size(1038, 632);
            this.Name = "Frm_List_Estoque";
            this.Text = "Frm_List_Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.GridResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalRows;
        private System.Windows.Forms.Button btNovo;
        private ADGV.AdvancedDataGridView GridResultado;
    }
}