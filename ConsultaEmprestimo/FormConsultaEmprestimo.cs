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
    public partial class FormConsultaEmprestimo : Form
    {
        public string codItemAcervo { get; set; }

        public FormConsultaEmprestimo()
        {
            InitializeComponent();
        }

        private void FormConsultaEmprestimo_Load(object sender, EventArgs e)
        {
            btnLimpar.Enabled = false;
        }

        private void btnBuscarItem_Click(object sender, EventArgs e)
        {
            CarregaFormBuscaItens();
        }

        private void btnBuscarLeitor_Click(object sender, EventArgs e)
        {
            CarregaFormBuscaLeitores();
        }

        public void CarregaFormBuscaLeitores()
        {
            FormBuscarLeitor formBuscarLeitor = new FormBuscarLeitor();
            formBuscarLeitor.ShowDialog();
            txtNomeLeitor.Text = formBuscarLeitor.nomeLeitor;
        }

        public void CarregaFormBuscaItens()
        {
            FormBuscarItem formBuscaItem = new FormBuscarItem();
            formBuscaItem.ShowDialog();

            txtNomeItem.Text = formBuscaItem.nomeItem;
            codItemAcervo = formBuscaItem.codItem;

            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                BuscarItemDAO dao = new BuscarItemDAO(connection);

                txtNomeAutor.Text = dao.GetNomeAutor(new ConsultaEmprestimoModel()
                {
                    CodItem = codItemAcervo
                });

                txtNomeLocal.Text = dao.GetNomeLocal(new ConsultaEmprestimoModel()
                {
                    CodItem = codItemAcervo
                });

                txtNomeSecao.Text = dao.GetNomeSecao(new ConsultaEmprestimoModel()
                {
                    CodItem = codItemAcervo
                });

                cbxTipoItem.Text = dao.GetTipoItem(new ConsultaEmprestimoModel()
                {
                    CodItem = codItemAcervo
                });
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeItem.Text = String.Empty;
            txtNomeAutor.Text = String.Empty;
            txtNomeLocal.Text = String.Empty;
            txtNomeLeitor.Text = String.Empty;
            txtNomeSecao.Text = String.Empty;
            cbxTipoItem.SelectedIndex = -1;
            dtpDataReserva.Text = String.Empty;
            dtpDataDevolucao.Text = String.Empty;
            cbxSituacao.SelectedIndex = -1;
            dtgDadosEmprestimo.Rows.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DateTime dataReserva = dtpDataReserva.Value;
            DateTime dataDevolucao = dtpDataDevolucao.Value;

            using (SqlConnection connection = DaoConnection.GetConexao())
            {

                string query = "SELECT TOP 1 r.nomeItem, i.nomeAutor, i.nomeEditora, r.statusItem, r.dataReserva, r.prazoReserva " +
                               "FROM mvtBibReserva r " +
                               "INNER JOIN mvtBibItemAcervo i ON r.codItem = i.codItem " +
                               "WHERE r.nomeItem LIKE '%' + @nomeItem + '%' " +
                               "OR r.nomeLeitor LIKE '%' + @nomeLeitor + '%' " +
                               "AND r.statusItem = @statusItem ORDER BY codReserva desc";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nomeItem", txtNomeItem.Text);
                command.Parameters.AddWithValue("@nomeLeitor", txtNomeLeitor.Text);
                command.Parameters.AddWithValue("@statusItem", cbxSituacao.Text);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dtgDadosEmprestimo.Rows.Clear();

                    while (reader.Read())
                    {
                        DataGridViewRow row = dtgDadosEmprestimo.Rows[dtgDadosEmprestimo.Rows.Add()];
                        row.Cells[colNomeItem.Index].Value = reader["nomeItem"].ToString();
                        //row.Cells[colNomeAutor.Index].Value = reader["tipoItem"].ToString(); (PRECISA DE INNER JOIN)
                        row.Cells[colNomeEditora.Index].Value = reader["nomeEditora"].ToString();
                        row.Cells[colSituacao.Index].Value = reader["statusItem"].ToString();
                        row.Cells[colNomeAutor.Index].Value = reader["nomeAutor"].ToString();
                        row.Cells[colDataReserva.Index].Value = reader["dataReserva"].ToString();
                        row.Cells[colDataRetorno.Index].Value = reader["prazoReserva"].ToString();
                    }
                }
            }

            /*try
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    ConsultaEmprestimoDAO dao = new ConsultaEmprestimoDAO(connection);

                    dao.BuscarEmprestimosPorItem(new ConsultaEmprestimoModel()
                    {
                        NomeItem = txtNomeItem.Text,
                        StatusItem = cbxSituacao.Text,
                        NomeLeitor = txtNomeLeitor.Text
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao realizar a consulta!\n{ex.Message}");
            }*/
        }

        private void txtNomeItem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeItem.Text))
            {
                btnLimpar.Enabled = false;
                txtNomeAutor.ReadOnly = false;
                txtNomeLocal.ReadOnly = false;
                txtNomeSecao.ReadOnly = false;
                cbxTipoItem.Enabled = true;
                btnBuscarAutor.Enabled = true;
                btnBuscarLocal.Enabled = true;
                btnBuscarSecao.Enabled = true;
            }
            else
            {
                btnLimpar.Enabled = true;
                txtNomeAutor.ReadOnly = true;
                txtNomeLocal.ReadOnly = true;
                txtNomeSecao.ReadOnly = true;
                cbxTipoItem.Enabled = false;
                btnBuscarAutor.Enabled = false;
                btnBuscarLocal.Enabled = false;
                btnBuscarSecao.Enabled = false;
            }
        }
    }
}
