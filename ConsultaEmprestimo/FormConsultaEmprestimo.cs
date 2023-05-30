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
            try
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
            } catch(Exception ex)
            {
                throw ex;
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
            if (string.IsNullOrEmpty(txtNomeItem.Text))
            {
                if (string.IsNullOrEmpty(txtNomeLeitor.Text))
                {
                    MessageBox.Show("Por favor preencha os campos!");
                    return;
                } else if(string.IsNullOrEmpty(txtNomeLeitor.Text) && string.IsNullOrEmpty(txtNomeItem.Text))
                {
                    MessageBox.Show("ERROR");
                } else
                {
                    InitializeTablePorLeitor(dtgDadosEmprestimo);
                }
            } else
            {
                InitializeTablePorItem(dtgDadosEmprestimo);
            }
            //falta ajustar aqui em cima, colocando um if para verificar o txtNomeLeitor dentro do else que valida o txtNomeItem.
        }

        public void InitializeTablePorItem(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                ConsultaEmprestimoDAO dao = new ConsultaEmprestimoDAO(connection);
                List<ConsultaEmprestimoModel> emprestimos = dao.BuscarEmprestimosPorItem(new ConsultaEmprestimoModel()
                {
                    NomeItem = txtNomeItem.Text,
                    NomeLeitor = txtNomeLeitor.Text,
                    StatusItem = cbxSituacao.Text
                });

                foreach (ConsultaEmprestimoModel emprestimo in emprestimos)
                {
                    DataGridViewRow row = dataGridView.Rows[dataGridView.Rows.Add()];
                    row.Cells[colNomeItem.Index].Value = emprestimo.NomeItem;
                    row.Cells[colNomeAutor.Index].Value = emprestimo.NomeAutor;
                    row.Cells[colNomeEditora.Index].Value = emprestimo.NomeEditora;
                    row.Cells[colSituacao.Index].Value = emprestimo.StatusItem;
                    row.Cells[colDataReserva.Index].Value = emprestimo.DataReserva;
                    row.Cells[colDataRetorno.Index].Value = emprestimo.DataRetorno;
                }
            }
        }

        public void InitializeTablePorLeitor(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                ConsultaEmprestimoDAO dao = new ConsultaEmprestimoDAO(connection);
                List<ConsultaEmprestimoModel> emprestimos = dao.BuscarEmprestimosPorLeitor(new ConsultaEmprestimoModel()
                {
                    NomeLeitor = txtNomeLeitor.Text
                });

                foreach (ConsultaEmprestimoModel emprestimo in emprestimos)
                {
                    DataGridViewRow row = dataGridView.Rows[dataGridView.Rows.Add()];
                    row.Cells[colNomeItem.Index].Value = emprestimo.NomeItem;
                    row.Cells[colNomeAutor.Index].Value = emprestimo.NomeAutor;
                    row.Cells[colNomeEditora.Index].Value = emprestimo.NomeEditora;
                    row.Cells[colSituacao.Index].Value = emprestimo.StatusItem;
                    row.Cells[colDataReserva.Index].Value = emprestimo.DataReserva;
                    row.Cells[colDataRetorno.Index].Value = emprestimo.DataRetorno;
                }
            }
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

        private void txtNomeLeitor_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeLeitor.Text))
            {
                btnLimpar.Enabled = false;
            }
            else
            {
                btnLimpar.Enabled = true;
            }
        }
    }
}
