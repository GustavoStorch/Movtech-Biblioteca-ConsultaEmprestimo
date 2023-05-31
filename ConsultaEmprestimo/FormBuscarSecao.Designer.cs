namespace ConsultaEmprestimo
{
    partial class FormBuscarSecao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarSecao));
            this.dtgDadosSecao = new System.Windows.Forms.DataGridView();
            this.colCodSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNomeSecao = new System.Windows.Forms.TextBox();
            this.lblNomeSecao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosSecao)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDadosSecao
            // 
            this.dtgDadosSecao.AllowUserToAddRows = false;
            this.dtgDadosSecao.AllowUserToDeleteRows = false;
            this.dtgDadosSecao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosSecao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosSecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosSecao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodSecao,
            this.colNomeSecao});
            this.dtgDadosSecao.Location = new System.Drawing.Point(16, 53);
            this.dtgDadosSecao.Name = "dtgDadosSecao";
            this.dtgDadosSecao.ReadOnly = true;
            this.dtgDadosSecao.RowHeadersWidth = 62;
            this.dtgDadosSecao.RowTemplate.Height = 28;
            this.dtgDadosSecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosSecao.Size = new System.Drawing.Size(673, 312);
            this.dtgDadosSecao.TabIndex = 11;
            this.dtgDadosSecao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosSecao_CellDoubleClick);
            // 
            // colCodSecao
            // 
            this.colCodSecao.FillWeight = 15F;
            this.colCodSecao.HeaderText = "Código";
            this.colCodSecao.MinimumWidth = 8;
            this.colCodSecao.Name = "colCodSecao";
            this.colCodSecao.ReadOnly = true;
            // 
            // colNomeSecao
            // 
            this.colNomeSecao.HeaderText = "Seção";
            this.colNomeSecao.MinimumWidth = 8;
            this.colNomeSecao.Name = "colNomeSecao";
            this.colNomeSecao.ReadOnly = true;
            // 
            // txtNomeSecao
            // 
            this.txtNomeSecao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeSecao.Location = new System.Drawing.Point(77, 12);
            this.txtNomeSecao.Name = "txtNomeSecao";
            this.txtNomeSecao.Size = new System.Drawing.Size(612, 26);
            this.txtNomeSecao.TabIndex = 10;
            this.txtNomeSecao.TextChanged += new System.EventHandler(this.txtNomeSecao_TextChanged);
            // 
            // lblNomeSecao
            // 
            this.lblNomeSecao.AutoSize = true;
            this.lblNomeSecao.Location = new System.Drawing.Point(12, 15);
            this.lblNomeSecao.Name = "lblNomeSecao";
            this.lblNomeSecao.Size = new System.Drawing.Size(59, 20);
            this.lblNomeSecao.TabIndex = 9;
            this.lblNomeSecao.Text = "Seção:";
            // 
            // FormBuscarSecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 378);
            this.Controls.Add(this.dtgDadosSecao);
            this.Controls.Add(this.txtNomeSecao);
            this.Controls.Add(this.lblNomeSecao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBuscarSecao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Seção";
            this.Load += new System.EventHandler(this.FormBuscarSecao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosSecao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDadosSecao;
        private System.Windows.Forms.TextBox txtNomeSecao;
        private System.Windows.Forms.Label lblNomeSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeSecao;
    }
}