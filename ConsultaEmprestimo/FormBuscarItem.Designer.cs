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
            this.colCodItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumExemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodItem = new System.Windows.Forms.TextBox();
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
            this.dtgDadosItemAcervo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosItemAcervo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosItemAcervo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodItemAcervo,
            this.colNomeItem,
            this.colNumExemplar});
            this.dtgDadosItemAcervo.Location = new System.Drawing.Point(16, 54);
            this.dtgDadosItemAcervo.Name = "dtgDadosItemAcervo";
            this.dtgDadosItemAcervo.ReadOnly = true;
            this.dtgDadosItemAcervo.RowHeadersWidth = 62;
            this.dtgDadosItemAcervo.RowTemplate.Height = 28;
            this.dtgDadosItemAcervo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosItemAcervo.Size = new System.Drawing.Size(673, 312);
            this.dtgDadosItemAcervo.TabIndex = 2;
            this.dtgDadosItemAcervo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosItemAcervo_CellDoubleClick);
            // 
            // colCodItemAcervo
            // 
            this.colCodItemAcervo.FillWeight = 15F;
            this.colCodItemAcervo.HeaderText = "Código";
            this.colCodItemAcervo.MinimumWidth = 8;
            this.colCodItemAcervo.Name = "colCodItemAcervo";
            this.colCodItemAcervo.ReadOnly = true;
            // 
            // colNomeItem
            // 
            this.colNomeItem.HeaderText = "Item Acervo";
            this.colNomeItem.MinimumWidth = 8;
            this.colNomeItem.Name = "colNomeItem";
            this.colNomeItem.ReadOnly = true;
            // 
            // colNumExemplar
            // 
            this.colNumExemplar.HeaderText = "NumExemplar";
            this.colNumExemplar.MinimumWidth = 8;
            this.colNumExemplar.Name = "colNumExemplar";
            this.colNumExemplar.ReadOnly = true;
            this.colNumExemplar.Visible = false;
            // 
            // txtCodItem
            // 
            this.txtCodItem.Enabled = false;
            this.txtCodItem.Location = new System.Drawing.Point(695, 352);
            this.txtCodItem.Name = "txtCodItem";
            this.txtCodItem.Size = new System.Drawing.Size(10, 26);
            this.txtCodItem.TabIndex = 3;
            this.txtCodItem.Visible = false;
            // 
            // FormBuscarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 380);
            this.Controls.Add(this.txtCodItem);
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
        private System.Windows.Forms.TextBox txtCodItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumExemplar;
    }
}