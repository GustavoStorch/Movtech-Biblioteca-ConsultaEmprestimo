namespace ConsultaEmprestimo
{
    partial class FormBuscarAutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarAutor));
            this.dtgDadosAutor = new System.Windows.Forms.DataGridView();
            this.colNomeAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.lblNomeAutor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDadosAutor
            // 
            this.dtgDadosAutor.AllowUserToAddRows = false;
            this.dtgDadosAutor.AllowUserToDeleteRows = false;
            this.dtgDadosAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosAutor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosAutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomeAutor});
            this.dtgDadosAutor.Location = new System.Drawing.Point(16, 60);
            this.dtgDadosAutor.Name = "dtgDadosAutor";
            this.dtgDadosAutor.ReadOnly = true;
            this.dtgDadosAutor.RowHeadersWidth = 62;
            this.dtgDadosAutor.RowTemplate.Height = 28;
            this.dtgDadosAutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosAutor.Size = new System.Drawing.Size(673, 312);
            this.dtgDadosAutor.TabIndex = 5;
            this.dtgDadosAutor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosAutor_CellDoubleClick);
            // 
            // colNomeAutor
            // 
            this.colNomeAutor.HeaderText = "Autor";
            this.colNomeAutor.MinimumWidth = 8;
            this.colNomeAutor.Name = "colNomeAutor";
            this.colNomeAutor.ReadOnly = true;
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeAutor.Location = new System.Drawing.Point(63, 18);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(626, 26);
            this.txtNomeAutor.TabIndex = 4;
            this.txtNomeAutor.TextChanged += new System.EventHandler(this.txtNomeAutor_TextChanged);
            // 
            // lblNomeAutor
            // 
            this.lblNomeAutor.AutoSize = true;
            this.lblNomeAutor.Location = new System.Drawing.Point(12, 18);
            this.lblNomeAutor.Name = "lblNomeAutor";
            this.lblNomeAutor.Size = new System.Drawing.Size(52, 20);
            this.lblNomeAutor.TabIndex = 3;
            this.lblNomeAutor.Text = "Autor:";
            // 
            // FormBuscarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 387);
            this.Controls.Add(this.dtgDadosAutor);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.lblNomeAutor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBuscarAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Autor";
            this.Load += new System.EventHandler(this.FormBuscarAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosAutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDadosAutor;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.Label lblNomeAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeAutor;
    }
}