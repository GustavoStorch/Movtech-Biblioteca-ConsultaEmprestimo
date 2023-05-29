namespace ConsultaEmprestimo
{
    partial class FormBuscarItem
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
            this.lblNomeItemAcervo = new System.Windows.Forms.Label();
            this.txtNomeItemAcervo = new System.Windows.Forms.TextBox();
            this.dtgDadosItemAcervo = new System.Windows.Forms.DataGridView();
            this.colNomeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosItemAcervo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeItemAcervo
            // 
            this.lblNomeItemAcervo.AutoSize = true;
            this.lblNomeItemAcervo.Location = new System.Drawing.Point(12, 15);
            this.lblNomeItemAcervo.Name = "lblNomeItemAcervo";
            this.lblNomeItemAcervo.Size = new System.Drawing.Size(45, 20);
            this.lblNomeItemAcervo.TabIndex = 0;
            this.lblNomeItemAcervo.Text = "Item:";
            // 
            // txtNomeItemAcervo
            // 
            this.txtNomeItemAcervo.Location = new System.Drawing.Point(63, 12);
            this.txtNomeItemAcervo.Name = "txtNomeItemAcervo";
            this.txtNomeItemAcervo.Size = new System.Drawing.Size(626, 26);
            this.txtNomeItemAcervo.TabIndex = 1;
            this.txtNomeItemAcervo.TextChanged += new System.EventHandler(this.txtNomeItemAcervo_TextChanged);
            // 
            // dtgDadosItemAcervo
            // 
            this.dtgDadosItemAcervo.AllowUserToAddRows = false;
            this.dtgDadosItemAcervo.AllowUserToDeleteRows = false;
            this.dtgDadosItemAcervo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosItemAcervo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomeItem,
            this.colTipoItem,
            this.colNomeLocal,
            this.colNomeAutor,
            this.colStatusItem,
            this.colNomeSecao});
            this.dtgDadosItemAcervo.Location = new System.Drawing.Point(16, 54);
            this.dtgDadosItemAcervo.Name = "dtgDadosItemAcervo";
            this.dtgDadosItemAcervo.ReadOnly = true;
            this.dtgDadosItemAcervo.RowHeadersWidth = 62;
            this.dtgDadosItemAcervo.RowTemplate.Height = 28;
            this.dtgDadosItemAcervo.Size = new System.Drawing.Size(673, 312);
            this.dtgDadosItemAcervo.TabIndex = 2;
            this.dtgDadosItemAcervo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosItemAcervo_CellDoubleClick);
            // 
            // colNomeItem
            // 
            this.colNomeItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNomeItem.HeaderText = "Item Acervo";
            this.colNomeItem.MinimumWidth = 8;
            this.colNomeItem.Name = "colNomeItem";
            this.colNomeItem.ReadOnly = true;
            // 
            // colTipoItem
            // 
            this.colTipoItem.HeaderText = "Tipo Item";
            this.colTipoItem.MinimumWidth = 8;
            this.colTipoItem.Name = "colTipoItem";
            this.colTipoItem.ReadOnly = true;
            this.colTipoItem.Visible = false;
            this.colTipoItem.Width = 150;
            // 
            // colNomeLocal
            // 
            this.colNomeLocal.HeaderText = "Local";
            this.colNomeLocal.MinimumWidth = 8;
            this.colNomeLocal.Name = "colNomeLocal";
            this.colNomeLocal.ReadOnly = true;
            this.colNomeLocal.Visible = false;
            this.colNomeLocal.Width = 150;
            // 
            // colNomeAutor
            // 
            this.colNomeAutor.HeaderText = "Autor";
            this.colNomeAutor.MinimumWidth = 8;
            this.colNomeAutor.Name = "colNomeAutor";
            this.colNomeAutor.ReadOnly = true;
            this.colNomeAutor.Visible = false;
            this.colNomeAutor.Width = 150;
            // 
            // colStatusItem
            // 
            this.colStatusItem.HeaderText = "Status Item";
            this.colStatusItem.MinimumWidth = 8;
            this.colStatusItem.Name = "colStatusItem";
            this.colStatusItem.ReadOnly = true;
            this.colStatusItem.Visible = false;
            this.colStatusItem.Width = 150;
            // 
            // colNomeSecao
            // 
            this.colNomeSecao.HeaderText = "Secao";
            this.colNomeSecao.MinimumWidth = 8;
            this.colNomeSecao.Name = "colNomeSecao";
            this.colNomeSecao.ReadOnly = true;
            this.colNomeSecao.Visible = false;
            this.colNomeSecao.Width = 150;
            // 
            // FormBuscarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 380);
            this.Controls.Add(this.dtgDadosItemAcervo);
            this.Controls.Add(this.txtNomeItemAcervo);
            this.Controls.Add(this.lblNomeItemAcervo);
            this.Name = "FormBuscarItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Item do Acervo";
            this.Load += new System.EventHandler(this.FormBuscarItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosItemAcervo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeItemAcervo;
        private System.Windows.Forms.TextBox txtNomeItemAcervo;
        private System.Windows.Forms.DataGridView dtgDadosItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeSecao;
    }
}