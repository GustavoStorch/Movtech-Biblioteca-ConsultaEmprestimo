using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaEmprestimo
{
    public partial class FormBuscarLeitor : Form
    {
        public string nomeLeitor { get; set; }

        public FormBuscarLeitor()
        {
            InitializeComponent();
        }

        private void FormBuscarLeitor_Load(object sender, EventArgs e)
        {
            InitializeTable();
        }

        public void carregaTextBox()
        {;
            nomeLeitor = txtNomeLeitor.Text;
            this.Close();
        }

        private void InitializeTable()
        {
            dtgDadosLeitor.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                BuscarLeitorDAO dao = new BuscarLeitorDAO(connection);
                List<ConsultaEmprestimoModel> leitores = dao.GetLeitores();
                foreach (ConsultaEmprestimoModel leitor in leitores)
                {
                    DataGridViewRow row = dtgDadosLeitor.Rows[dtgDadosLeitor.Rows.Add()];
                    row.Cells[colNomeLeitor.Index].Value = leitor.NomeLeitor;
                }
            }
        }

        private void dtgDadosLeitor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtNomeLeitor.Text = dtgDadosLeitor.Rows[e.RowIndex].Cells[colNomeLeitor.Index].Value + "";
            }
            carregaTextBox();
        }

        private void txtNomeLeitor_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNomeLeitor.Text.Trim();

            foreach (DataGridViewRow row in dtgDadosLeitor.Rows)
            {
                string nomeAutor = row.Cells[colNomeLeitor.Index].Value.ToString().Trim();
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }
    }
}
