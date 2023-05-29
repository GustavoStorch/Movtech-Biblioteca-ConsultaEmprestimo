using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaEmprestimo
{
    public partial class FormConsultaEmprestimo : Form
    {
        public FormConsultaEmprestimo()
        {
            InitializeComponent();
        }

        private void btnBuscarItem_Click(object sender, EventArgs e)
        {
            CarregaFormBuscaItens();
        }

        public void CarregaFormBuscaItens()
        {
            FormBuscarItem formBuscaItem = new FormBuscarItem();
            formBuscaItem.ShowDialog();

            txtNomeItem.Text = formBuscaItem.nomeItem;
            cbxTipoItem.Text = formBuscaItem.tipoItem;
            txtNomeLocal.Text = formBuscaItem.nomeLocal;
            txtNomeAutor.Text = formBuscaItem.nomeAutor;
            txtNomeSecao.Text = formBuscaItem.secao;
            cbxSituacao.Text = formBuscaItem.statusItem;
        }

        private void FormConsultaEmprestimo_Load(object sender, EventArgs e)
        {

        }
    }
}
