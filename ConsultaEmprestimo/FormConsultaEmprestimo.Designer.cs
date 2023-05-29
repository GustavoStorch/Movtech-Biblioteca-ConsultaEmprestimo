namespace ConsultaEmprestimo
{
    partial class FormConsultaEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaEmprestimo));
            this.gpxDadosConsultaEmprestimo = new System.Windows.Forms.GroupBox();
            this.btnBuscarLeitor = new System.Windows.Forms.Button();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.btnBuscarSecao = new System.Windows.Forms.Button();
            this.btnBuscarLocal = new System.Windows.Forms.Button();
            this.btnBuscarItem = new System.Windows.Forms.Button();
            this.cbxSituacao = new System.Windows.Forms.ComboBox();
            this.lblNomeItem = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.dtpDataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.lblDataDevolucao = new System.Windows.Forms.Label();
            this.lblNomeLocal = new System.Windows.Forms.Label();
            this.txtNomeLocal = new System.Windows.Forms.TextBox();
            this.dtpDataReserva = new System.Windows.Forms.DateTimePicker();
            this.lblNomeSecao = new System.Windows.Forms.Label();
            this.lblDataEmprestimo = new System.Windows.Forms.Label();
            this.txtNomeSecao = new System.Windows.Forms.TextBox();
            this.cbxTipoItem = new System.Windows.Forms.ComboBox();
            this.lblNomeLeitor = new System.Windows.Forms.Label();
            this.lblTipoItem = new System.Windows.Forms.Label();
            this.txtNomeLeitor = new System.Windows.Forms.TextBox();
            this.lblNomeAutor = new System.Windows.Forms.Label();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtgDadosEmprestimo = new System.Windows.Forms.DataGridView();
            this.colNomeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coDataReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataRetorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpxDadosConsultaEmprestimo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // gpxDadosConsultaEmprestimo
            // 
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.btnBuscarLeitor);
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.btnBuscarAutor);
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.btnBuscarSecao);
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.btnBuscarLocal);
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.btnBuscarItem);
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.cbxSituacao);
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.lblNomeItem);
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.lblSituacao);
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.txtNomeItem);
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.dtpDataDevolucao);
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.lblDataDevolucao);
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.lblNomeLocal);
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.txtNomeLocal);
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.dtpDataReserva);
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.lblNomeSecao);
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.lblDataEmprestimo);
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.txtNomeSecao);
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.cbxTipoItem);
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.lblNomeLeitor);
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.lblTipoItem);
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.txtNomeLeitor);
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.lblNomeAutor);
            this.gpxDadosConsultaEmprestimo.Controls.Add(this.txtNomeAutor);
            this.gpxDadosConsultaEmprestimo.Location = new System.Drawing.Point(12, 12);
            this.gpxDadosConsultaEmprestimo.Name = "gpxDadosConsultaEmprestimo";
            this.gpxDadosConsultaEmprestimo.Size = new System.Drawing.Size(1188, 198);
            this.gpxDadosConsultaEmprestimo.TabIndex = 0;
            this.gpxDadosConsultaEmprestimo.TabStop = false;
            this.gpxDadosConsultaEmprestimo.Text = "Dados empréstimo";
            // 
            // btnBuscarLeitor
            // 
            this.btnBuscarLeitor.FlatAppearance.BorderSize = 0;
            this.btnBuscarLeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLeitor.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBuscarLeitor.Image = global::ConsultaEmprestimo.Properties.Resources.lupa__1_;
            this.btnBuscarLeitor.Location = new System.Drawing.Point(1121, 72);
            this.btnBuscarLeitor.Name = "btnBuscarLeitor";
            this.btnBuscarLeitor.Size = new System.Drawing.Size(58, 26);
            this.btnBuscarLeitor.TabIndex = 8;
            this.btnBuscarLeitor.UseVisualStyleBackColor = true;
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.FlatAppearance.BorderSize = 0;
            this.btnBuscarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAutor.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBuscarAutor.Image = global::ConsultaEmprestimo.Properties.Resources.lupa__1_;
            this.btnBuscarAutor.Location = new System.Drawing.Point(1121, 35);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(58, 23);
            this.btnBuscarAutor.TabIndex = 4;
            this.btnBuscarAutor.UseVisualStyleBackColor = true;
            // 
            // btnBuscarSecao
            // 
            this.btnBuscarSecao.FlatAppearance.BorderSize = 0;
            this.btnBuscarSecao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarSecao.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBuscarSecao.Image = global::ConsultaEmprestimo.Properties.Resources.lupa__1_;
            this.btnBuscarSecao.Location = new System.Drawing.Point(297, 112);
            this.btnBuscarSecao.Name = "btnBuscarSecao";
            this.btnBuscarSecao.Size = new System.Drawing.Size(58, 26);
            this.btnBuscarSecao.TabIndex = 10;
            this.btnBuscarSecao.UseVisualStyleBackColor = true;
            // 
            // btnBuscarLocal
            // 
            this.btnBuscarLocal.FlatAppearance.BorderSize = 0;
            this.btnBuscarLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLocal.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBuscarLocal.Image = global::ConsultaEmprestimo.Properties.Resources.lupa__1_;
            this.btnBuscarLocal.Location = new System.Drawing.Point(297, 72);
            this.btnBuscarLocal.Name = "btnBuscarLocal";
            this.btnBuscarLocal.Size = new System.Drawing.Size(58, 26);
            this.btnBuscarLocal.TabIndex = 6;
            this.btnBuscarLocal.UseVisualStyleBackColor = true;
            // 
            // btnBuscarItem
            // 
            this.btnBuscarItem.FlatAppearance.BorderSize = 0;
            this.btnBuscarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBuscarItem.Image = global::ConsultaEmprestimo.Properties.Resources.lupa__1_;
            this.btnBuscarItem.Location = new System.Drawing.Point(297, 32);
            this.btnBuscarItem.Name = "btnBuscarItem";
            this.btnBuscarItem.Size = new System.Drawing.Size(58, 26);
            this.btnBuscarItem.TabIndex = 2;
            this.btnBuscarItem.UseVisualStyleBackColor = true;
            this.btnBuscarItem.Click += new System.EventHandler(this.btnBuscarItem_Click);
            // 
            // cbxSituacao
            // 
            this.cbxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSituacao.FormattingEnabled = true;
            this.cbxSituacao.Location = new System.Drawing.Point(1006, 155);
            this.cbxSituacao.Name = "cbxSituacao";
            this.cbxSituacao.Size = new System.Drawing.Size(173, 28);
            this.cbxSituacao.TabIndex = 14;
            // 
            // lblNomeItem
            // 
            this.lblNomeItem.AutoSize = true;
            this.lblNomeItem.Location = new System.Drawing.Point(0, 35);
            this.lblNomeItem.Name = "lblNomeItem";
            this.lblNomeItem.Size = new System.Drawing.Size(45, 20);
            this.lblNomeItem.TabIndex = 0;
            this.lblNomeItem.Text = "Item:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(924, 160);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(76, 20);
            this.lblSituacao.TabIndex = 8;
            this.lblSituacao.Text = "Situação:";
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Location = new System.Drawing.Point(67, 32);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(224, 26);
            this.txtNomeItem.TabIndex = 1;
            // 
            // dtpDataDevolucao
            // 
            this.dtpDataDevolucao.Location = new System.Drawing.Point(602, 155);
            this.dtpDataDevolucao.Name = "dtpDataDevolucao";
            this.dtpDataDevolucao.Size = new System.Drawing.Size(316, 26);
            this.dtpDataDevolucao.TabIndex = 13;
            // 
            // lblDataDevolucao
            // 
            this.lblDataDevolucao.AutoSize = true;
            this.lblDataDevolucao.Location = new System.Drawing.Point(469, 160);
            this.lblDataDevolucao.Name = "lblDataDevolucao";
            this.lblDataDevolucao.Size = new System.Drawing.Size(127, 20);
            this.lblDataDevolucao.TabIndex = 7;
            this.lblDataDevolucao.Text = "Data Devolução:";
            // 
            // lblNomeLocal
            // 
            this.lblNomeLocal.AutoSize = true;
            this.lblNomeLocal.Location = new System.Drawing.Point(0, 75);
            this.lblNomeLocal.Name = "lblNomeLocal";
            this.lblNomeLocal.Size = new System.Drawing.Size(51, 20);
            this.lblNomeLocal.TabIndex = 2;
            this.lblNomeLocal.Text = "Local:";
            // 
            // txtNomeLocal
            // 
            this.txtNomeLocal.Location = new System.Drawing.Point(71, 72);
            this.txtNomeLocal.Name = "txtNomeLocal";
            this.txtNomeLocal.Size = new System.Drawing.Size(220, 26);
            this.txtNomeLocal.TabIndex = 5;
            // 
            // dtpDataReserva
            // 
            this.dtpDataReserva.Location = new System.Drawing.Point(150, 155);
            this.dtpDataReserva.Name = "dtpDataReserva";
            this.dtpDataReserva.Size = new System.Drawing.Size(313, 26);
            this.dtpDataReserva.TabIndex = 12;
            // 
            // lblNomeSecao
            // 
            this.lblNomeSecao.AutoSize = true;
            this.lblNomeSecao.Location = new System.Drawing.Point(0, 115);
            this.lblNomeSecao.Name = "lblNomeSecao";
            this.lblNomeSecao.Size = new System.Drawing.Size(59, 20);
            this.lblNomeSecao.TabIndex = 5;
            this.lblNomeSecao.Text = "Seção:";
            // 
            // lblDataEmprestimo
            // 
            this.lblDataEmprestimo.AutoSize = true;
            this.lblDataEmprestimo.Location = new System.Drawing.Point(6, 160);
            this.lblDataEmprestimo.Name = "lblDataEmprestimo";
            this.lblDataEmprestimo.Size = new System.Drawing.Size(137, 20);
            this.lblDataEmprestimo.TabIndex = 6;
            this.lblDataEmprestimo.Text = "Data Empréstimo:";
            // 
            // txtNomeSecao
            // 
            this.txtNomeSecao.Location = new System.Drawing.Point(71, 112);
            this.txtNomeSecao.Name = "txtNomeSecao";
            this.txtNomeSecao.Size = new System.Drawing.Size(220, 26);
            this.txtNomeSecao.TabIndex = 9;
            // 
            // cbxTipoItem
            // 
            this.cbxTipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoItem.FormattingEnabled = true;
            this.cbxTipoItem.Location = new System.Drawing.Point(468, 112);
            this.cbxTipoItem.Name = "cbxTipoItem";
            this.cbxTipoItem.Size = new System.Drawing.Size(711, 28);
            this.cbxTipoItem.TabIndex = 11;
            // 
            // lblNomeLeitor
            // 
            this.lblNomeLeitor.AutoSize = true;
            this.lblNomeLeitor.Location = new System.Drawing.Point(361, 75);
            this.lblNomeLeitor.Name = "lblNomeLeitor";
            this.lblNomeLeitor.Size = new System.Drawing.Size(53, 20);
            this.lblNomeLeitor.TabIndex = 4;
            this.lblNomeLeitor.Text = "Leitor:";
            // 
            // lblTipoItem
            // 
            this.lblTipoItem.AutoSize = true;
            this.lblTipoItem.Location = new System.Drawing.Point(361, 115);
            this.lblTipoItem.Name = "lblTipoItem";
            this.lblTipoItem.Size = new System.Drawing.Size(101, 20);
            this.lblTipoItem.TabIndex = 1;
            this.lblTipoItem.Text = "Tipo do Item:";
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.Location = new System.Drawing.Point(468, 72);
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.Size = new System.Drawing.Size(647, 26);
            this.txtNomeLeitor.TabIndex = 7;
            // 
            // lblNomeAutor
            // 
            this.lblNomeAutor.AutoSize = true;
            this.lblNomeAutor.Location = new System.Drawing.Point(361, 35);
            this.lblNomeAutor.Name = "lblNomeAutor";
            this.lblNomeAutor.Size = new System.Drawing.Size(52, 20);
            this.lblNomeAutor.TabIndex = 3;
            this.lblNomeAutor.Text = "Autor:";
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(468, 32);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(647, 26);
            this.txtNomeAutor.TabIndex = 3;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(1090, 216);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(110, 33);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // dtgDadosEmprestimo
            // 
            this.dtgDadosEmprestimo.AllowUserToAddRows = false;
            this.dtgDadosEmprestimo.AllowUserToDeleteRows = false;
            this.dtgDadosEmprestimo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosEmprestimo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomeItem,
            this.colNomeAutor,
            this.colNomeEditora,
            this.colSituacao,
            this.coDataReserva,
            this.colDataRetorno});
            this.dtgDadosEmprestimo.Location = new System.Drawing.Point(13, 255);
            this.dtgDadosEmprestimo.Name = "dtgDadosEmprestimo";
            this.dtgDadosEmprestimo.ReadOnly = true;
            this.dtgDadosEmprestimo.RowHeadersWidth = 62;
            this.dtgDadosEmprestimo.RowTemplate.Height = 28;
            this.dtgDadosEmprestimo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosEmprestimo.Size = new System.Drawing.Size(1188, 401);
            this.dtgDadosEmprestimo.TabIndex = 17;
            // 
            // colNomeItem
            // 
            this.colNomeItem.HeaderText = "Item";
            this.colNomeItem.MinimumWidth = 8;
            this.colNomeItem.Name = "colNomeItem";
            this.colNomeItem.ReadOnly = true;
            // 
            // colNomeAutor
            // 
            this.colNomeAutor.HeaderText = "Autor";
            this.colNomeAutor.MinimumWidth = 8;
            this.colNomeAutor.Name = "colNomeAutor";
            this.colNomeAutor.ReadOnly = true;
            // 
            // colNomeEditora
            // 
            this.colNomeEditora.HeaderText = "Editora";
            this.colNomeEditora.MinimumWidth = 8;
            this.colNomeEditora.Name = "colNomeEditora";
            this.colNomeEditora.ReadOnly = true;
            // 
            // colSituacao
            // 
            this.colSituacao.HeaderText = "Situação";
            this.colSituacao.MinimumWidth = 8;
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.ReadOnly = true;
            // 
            // coDataReserva
            // 
            this.coDataReserva.HeaderText = "Data Reserva";
            this.coDataReserva.MinimumWidth = 8;
            this.coDataReserva.Name = "coDataReserva";
            this.coDataReserva.ReadOnly = true;
            // 
            // colDataRetorno
            // 
            this.colDataRetorno.HeaderText = "Data Retorno";
            this.colDataRetorno.MinimumWidth = 8;
            this.colDataRetorno.Name = "colDataRetorno";
            this.colDataRetorno.ReadOnly = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(974, 216);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 33);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // FormConsultaEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 668);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dtgDadosEmprestimo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.gpxDadosConsultaEmprestimo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsultaEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Empréstimo";
            this.Load += new System.EventHandler(this.FormConsultaEmprestimo_Load);
            this.gpxDadosConsultaEmprestimo.ResumeLayout(false);
            this.gpxDadosConsultaEmprestimo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosEmprestimo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpxDadosConsultaEmprestimo;
        private System.Windows.Forms.Label lblNomeItem;
        private System.Windows.Forms.Label lblTipoItem;
        private System.Windows.Forms.Label lblNomeLocal;
        private System.Windows.Forms.Label lblNomeAutor;
        private System.Windows.Forms.Label lblNomeLeitor;
        private System.Windows.Forms.Label lblNomeSecao;
        private System.Windows.Forms.Label lblDataEmprestimo;
        private System.Windows.Forms.Label lblDataDevolucao;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.TextBox txtNomeLocal;
        private System.Windows.Forms.TextBox txtNomeSecao;
        private System.Windows.Forms.TextBox txtNomeLeitor;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.ComboBox cbxTipoItem;
        private System.Windows.Forms.DateTimePicker dtpDataReserva;
        private System.Windows.Forms.DateTimePicker dtpDataDevolucao;
        private System.Windows.Forms.ComboBox cbxSituacao;
        private System.Windows.Forms.Button btnBuscarItem;
        private System.Windows.Forms.Button btnBuscarLeitor;
        private System.Windows.Forms.Button btnBuscarAutor;
        private System.Windows.Forms.Button btnBuscarSecao;
        private System.Windows.Forms.Button btnBuscarLocal;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dtgDadosEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn coDataReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataRetorno;
        private System.Windows.Forms.Button btnLimpar;
    }
}

