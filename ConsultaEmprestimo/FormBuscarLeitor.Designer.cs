namespace ConsultaEmprestimo
{
    partial class FormBuscarLeitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarLeitor));
            this.txtNomeLeitor = new System.Windows.Forms.TextBox();
            this.lblNomeItemAcervo = new System.Windows.Forms.Label();
            this.dtgDadosLeitor = new System.Windows.Forms.DataGridView();
            this.colNomeLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosLeitor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeLeitor.Location = new System.Drawing.Point(63, 16);
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.Size = new System.Drawing.Size(626, 26);
            this.txtNomeLeitor.TabIndex = 3;
            this.txtNomeLeitor.TextChanged += new System.EventHandler(this.txtNomeLeitor_TextChanged);
            // 
            // lblNomeItemAcervo
            // 
            this.lblNomeItemAcervo.AutoSize = true;
            this.lblNomeItemAcervo.Location = new System.Drawing.Point(12, 19);
            this.lblNomeItemAcervo.Name = "lblNomeItemAcervo";
            this.lblNomeItemAcervo.Size = new System.Drawing.Size(45, 20);
            this.lblNomeItemAcervo.TabIndex = 2;
            this.lblNomeItemAcervo.Text = "Item:";
            // 
            // dtgDadosLeitor
            // 
            this.dtgDadosLeitor.AllowUserToAddRows = false;
            this.dtgDadosLeitor.AllowUserToDeleteRows = false;
            this.dtgDadosLeitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosLeitor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosLeitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosLeitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomeLeitor});
            this.dtgDadosLeitor.Location = new System.Drawing.Point(16, 60);
            this.dtgDadosLeitor.Name = "dtgDadosLeitor";
            this.dtgDadosLeitor.ReadOnly = true;
            this.dtgDadosLeitor.RowHeadersWidth = 62;
            this.dtgDadosLeitor.RowTemplate.Height = 28;
            this.dtgDadosLeitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosLeitor.Size = new System.Drawing.Size(673, 312);
            this.dtgDadosLeitor.TabIndex = 4;
            this.dtgDadosLeitor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosLeitor_CellDoubleClick);
            // 
            // colNomeLeitor
            // 
            this.colNomeLeitor.HeaderText = "Leitor";
            this.colNomeLeitor.MinimumWidth = 8;
            this.colNomeLeitor.Name = "colNomeLeitor";
            this.colNomeLeitor.ReadOnly = true;
            // 
            // FormBuscarLeitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 381);
            this.Controls.Add(this.dtgDadosLeitor);
            this.Controls.Add(this.txtNomeLeitor);
            this.Controls.Add(this.lblNomeItemAcervo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBuscarLeitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Leitor";
            this.Load += new System.EventHandler(this.FormBuscarLeitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosLeitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeLeitor;
        private System.Windows.Forms.Label lblNomeItemAcervo;
        private System.Windows.Forms.DataGridView dtgDadosLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeLeitor;
    }
}