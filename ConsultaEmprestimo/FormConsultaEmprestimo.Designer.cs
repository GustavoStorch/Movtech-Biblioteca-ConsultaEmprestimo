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
            this.lblNomeItem = new System.Windows.Forms.Label();
            this.lblTipoItem = new System.Windows.Forms.Label();
            this.lblNomeLocal = new System.Windows.Forms.Label();
            this.lblNomeAutor = new System.Windows.Forms.Label();
            this.lblNomeLeitor = new System.Windows.Forms.Label();
            this.lblNomeSecao = new System.Windows.Forms.Label();
            this.lblDataEmprestimo = new System.Windows.Forms.Label();
            this.lblDataDevolucao = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.txtNomeLocal = new System.Windows.Forms.TextBox();
            this.txtNomeSecao = new System.Windows.Forms.TextBox();
            this.txtNomeLeitor = new System.Windows.Forms.TextBox();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.cbxTipoItem = new System.Windows.Forms.ComboBox();
            this.dtpDataReserva = new System.Windows.Forms.DateTimePicker();
            this.dtpDataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.cbxSituacao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // gpxDadosConsultaEmprestimo
            // 
            this.gpxDadosConsultaEmprestimo.Location = new System.Drawing.Point(12, 12);
            this.gpxDadosConsultaEmprestimo.Name = "gpxDadosConsultaEmprestimo";
            this.gpxDadosConsultaEmprestimo.Size = new System.Drawing.Size(1147, 257);
            this.gpxDadosConsultaEmprestimo.TabIndex = 0;
            this.gpxDadosConsultaEmprestimo.TabStop = false;
            this.gpxDadosConsultaEmprestimo.Text = "Dados empréstimo";
            // 
            // lblNomeItem
            // 
            this.lblNomeItem.AutoSize = true;
            this.lblNomeItem.Location = new System.Drawing.Point(152, 270);
            this.lblNomeItem.Name = "lblNomeItem";
            this.lblNomeItem.Size = new System.Drawing.Size(45, 20);
            this.lblNomeItem.TabIndex = 0;
            this.lblNomeItem.Text = "Item:";
            // 
            // lblTipoItem
            // 
            this.lblTipoItem.AutoSize = true;
            this.lblTipoItem.Location = new System.Drawing.Point(96, 302);
            this.lblTipoItem.Name = "lblTipoItem";
            this.lblTipoItem.Size = new System.Drawing.Size(101, 20);
            this.lblTipoItem.TabIndex = 1;
            this.lblTipoItem.Text = "Tipo do Item:";
            // 
            // lblNomeLocal
            // 
            this.lblNomeLocal.AutoSize = true;
            this.lblNomeLocal.Location = new System.Drawing.Point(146, 336);
            this.lblNomeLocal.Name = "lblNomeLocal";
            this.lblNomeLocal.Size = new System.Drawing.Size(51, 20);
            this.lblNomeLocal.TabIndex = 2;
            this.lblNomeLocal.Text = "Local:";
            // 
            // lblNomeAutor
            // 
            this.lblNomeAutor.AutoSize = true;
            this.lblNomeAutor.Location = new System.Drawing.Point(152, 370);
            this.lblNomeAutor.Name = "lblNomeAutor";
            this.lblNomeAutor.Size = new System.Drawing.Size(52, 20);
            this.lblNomeAutor.TabIndex = 3;
            this.lblNomeAutor.Text = "Autor:";
            // 
            // lblNomeLeitor
            // 
            this.lblNomeLeitor.AutoSize = true;
            this.lblNomeLeitor.Location = new System.Drawing.Point(144, 402);
            this.lblNomeLeitor.Name = "lblNomeLeitor";
            this.lblNomeLeitor.Size = new System.Drawing.Size(53, 20);
            this.lblNomeLeitor.TabIndex = 4;
            this.lblNomeLeitor.Text = "Leitor:";
            // 
            // lblNomeSecao
            // 
            this.lblNomeSecao.AutoSize = true;
            this.lblNomeSecao.Location = new System.Drawing.Point(138, 434);
            this.lblNomeSecao.Name = "lblNomeSecao";
            this.lblNomeSecao.Size = new System.Drawing.Size(59, 20);
            this.lblNomeSecao.TabIndex = 5;
            this.lblNomeSecao.Text = "Seção:";
            // 
            // lblDataEmprestimo
            // 
            this.lblDataEmprestimo.AutoSize = true;
            this.lblDataEmprestimo.Location = new System.Drawing.Point(67, 473);
            this.lblDataEmprestimo.Name = "lblDataEmprestimo";
            this.lblDataEmprestimo.Size = new System.Drawing.Size(137, 20);
            this.lblDataEmprestimo.TabIndex = 6;
            this.lblDataEmprestimo.Text = "Data Empréstimo:";
            // 
            // lblDataDevolucao
            // 
            this.lblDataDevolucao.AutoSize = true;
            this.lblDataDevolucao.Location = new System.Drawing.Point(70, 502);
            this.lblDataDevolucao.Name = "lblDataDevolucao";
            this.lblDataDevolucao.Size = new System.Drawing.Size(127, 20);
            this.lblDataDevolucao.TabIndex = 7;
            this.lblDataDevolucao.Text = "Data Devolução:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(519, 502);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(76, 20);
            this.lblSituacao.TabIndex = 8;
            this.lblSituacao.Text = "Situação:";
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Location = new System.Drawing.Point(249, 270);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(121, 26);
            this.txtNomeItem.TabIndex = 9;
            // 
            // txtNomeLocal
            // 
            this.txtNomeLocal.Location = new System.Drawing.Point(249, 336);
            this.txtNomeLocal.Name = "txtNomeLocal";
            this.txtNomeLocal.Size = new System.Drawing.Size(121, 26);
            this.txtNomeLocal.TabIndex = 10;
            // 
            // txtNomeSecao
            // 
            this.txtNomeSecao.Location = new System.Drawing.Point(249, 434);
            this.txtNomeSecao.Name = "txtNomeSecao";
            this.txtNomeSecao.Size = new System.Drawing.Size(121, 26);
            this.txtNomeSecao.TabIndex = 12;
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.Location = new System.Drawing.Point(249, 402);
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.Size = new System.Drawing.Size(121, 26);
            this.txtNomeLeitor.TabIndex = 13;
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(249, 370);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(121, 26);
            this.txtNomeAutor.TabIndex = 14;
            // 
            // cbxTipoItem
            // 
            this.cbxTipoItem.FormattingEnabled = true;
            this.cbxTipoItem.Location = new System.Drawing.Point(249, 302);
            this.cbxTipoItem.Name = "cbxTipoItem";
            this.cbxTipoItem.Size = new System.Drawing.Size(121, 28);
            this.cbxTipoItem.TabIndex = 15;
            // 
            // dtpDataReserva
            // 
            this.dtpDataReserva.Location = new System.Drawing.Point(249, 473);
            this.dtpDataReserva.Name = "dtpDataReserva";
            this.dtpDataReserva.Size = new System.Drawing.Size(200, 26);
            this.dtpDataReserva.TabIndex = 16;
            // 
            // dtpDataDevolucao
            // 
            this.dtpDataDevolucao.Location = new System.Drawing.Point(249, 505);
            this.dtpDataDevolucao.Name = "dtpDataDevolucao";
            this.dtpDataDevolucao.Size = new System.Drawing.Size(200, 26);
            this.dtpDataDevolucao.TabIndex = 17;
            // 
            // cbxSituacao
            // 
            this.cbxSituacao.FormattingEnabled = true;
            this.cbxSituacao.Location = new System.Drawing.Point(617, 499);
            this.cbxSituacao.Name = "cbxSituacao";
            this.cbxSituacao.Size = new System.Drawing.Size(121, 28);
            this.cbxSituacao.TabIndex = 18;
            // 
            // FormConsultaEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 531);
            this.Controls.Add(this.cbxSituacao);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lblDataDevolucao);
            this.Controls.Add(this.dtpDataDevolucao);
            this.Controls.Add(this.dtpDataReserva);
            this.Controls.Add(this.lblDataEmprestimo);
            this.Controls.Add(this.lblNomeSecao);
            this.Controls.Add(this.lblNomeLeitor);
            this.Controls.Add(this.cbxTipoItem);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.txtNomeLeitor);
            this.Controls.Add(this.txtNomeSecao);
            this.Controls.Add(this.txtNomeLocal);
            this.Controls.Add(this.txtNomeItem);
            this.Controls.Add(this.lblNomeAutor);
            this.Controls.Add(this.lblNomeLocal);
            this.Controls.Add(this.lblTipoItem);
            this.Controls.Add(this.lblNomeItem);
            this.Controls.Add(this.gpxDadosConsultaEmprestimo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsultaEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Empréstimo";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

