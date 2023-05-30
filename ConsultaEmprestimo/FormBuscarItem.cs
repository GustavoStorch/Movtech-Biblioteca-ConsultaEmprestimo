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
    public partial class FormBuscarItem : Form
    {
        public string codItem { get; set; }

        public string nomeItem { get; set; }


        public FormBuscarItem()
        {
            InitializeComponent();
        }

        private void FormBuscarItem_Load(object sender, EventArgs e)
        {
            InitializeTable();
        }

        public void carregaTextBox()
        {
            codItem = txtCodItem.Text;
            nomeItem = txtNomeItemAcervo.Text;
            this.Close();
        }

        private void InitializeTable()
        {
            dtgDadosItemAcervo.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                BuscarItemDAO dao = new BuscarItemDAO(connection);
                List<ConsultaEmprestimoModel> itens = dao.GetItens();
                foreach (ConsultaEmprestimoModel item in itens)
                {
                    DataGridViewRow row = dtgDadosItemAcervo.Rows[dtgDadosItemAcervo.Rows.Add()];
                    row.Cells[colNomeItem.Index].Value = item.NomeItem;
                    row.Cells[colCodItemAcervo.Index].Value = item.CodItem;
                }
            }
        }

        private void dtgDadosItemAcervo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtNomeItemAcervo.Text = dtgDadosItemAcervo.Rows[e.RowIndex].Cells[colNomeItem.Index].Value + "";
                txtCodItem.Text = dtgDadosItemAcervo.Rows[e.RowIndex].Cells[colCodItemAcervo.Index].Value + "";
            }
            carregaTextBox();
        }

        private void txtNomeItemAcervo_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNomeItemAcervo.Text.Trim();

            foreach (DataGridViewRow row in dtgDadosItemAcervo.Rows)
            {
                string nomeAutor = row.Cells[colNomeItem.Index].Value.ToString().Trim();
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }
    }
}
