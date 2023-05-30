using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaEmprestimo
{
    public class ConsultaEmprestimoDAO
    {
        private SqlConnection Connection { get; }

        public ConsultaEmprestimoDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public void BuscarEmprestimosPorItem(ConsultaEmprestimoModel consultaEmprestimo)
        {
            List<ConsultaEmprestimoModel> buscas = new List<ConsultaEmprestimoModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT TOP 1 r.nomeItem, i.nomeAutor, i.nomeEditora, r.statusItem, r.dataReserva, r.prazoReserva");
                sql.AppendLine("FROM mvtBibReserva r INNER JOIN mvtBibItemAcervo i ON r.codItem = i.codItem");
                sql.AppendLine("WHERE r.nomeItem LIKE '%' + @nomeItem + '%'");
                sql.AppendLine("OR r.nomeLeitor LIKE '%' + @nomeLeitor + '%'");
                sql.AppendLine("AND r.statusItem = @statusItem ORDER BY codReserva desc");
 
                command.Parameters.AddWithValue("@nomeItem", consultaEmprestimo.NomeItem);
                command.Parameters.AddWithValue("@nomeLeitor", consultaEmprestimo.NomeLeitor);
                command.Parameters.AddWithValue("@statusItem", consultaEmprestimo.StatusItem);

                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        buscas.Add(PopulateDrBusca1(dr));
                        FormConsultaEmprestimo teste = new FormConsultaEmprestimo();
                        DataGridViewRow row = teste.dtgDadosEmprestimo.Rows[teste.dtgDadosEmprestimo.Rows.Add()];
                        row.Cells[teste.colNomeItem.Index].Value = dr["nomeItem"].ToString();
                        row.Cells[teste.colNomeEditora.Index].Value = dr["nomeEditora"].ToString();
                        row.Cells[teste.colSituacao.Index].Value = dr["statusItem"].ToString();
                        row.Cells[teste.colNomeAutor.Index].Value = dr["nomeAutor"].ToString();
                        row.Cells[teste.colDataReserva.Index].Value = dr["dataReserva"].ToString();
                        row.Cells[teste.colDataRetorno.Index].Value = dr["prazoReserva"].ToString();
                    }
                }
            }
        }

        public ConsultaEmprestimoModel PopulateDrBusca1(SqlDataReader dr)
        {
            string nomeItem = "";
            string nomeAutor = "";
            string nomeEditora = "";
            string statusItem = "";
            string dataReserva = "";
            string prazoReserva = "";

            if (DBNull.Value != dr["nomeItem"])
            {
                nomeItem = dr["nomeItem"] + "";
            }
            if (DBNull.Value != dr["nomeAutor"])
            {
                nomeAutor = dr["nomeAutor"] + "";
            }
            if (DBNull.Value != dr["nomeEditora"])
            {
                nomeEditora = dr["nomeEditora"] + "";
            }
            if (DBNull.Value != dr["statusItem"])
            {
                statusItem = dr["statusItem"] + "";
            }
            if (DBNull.Value != dr["dataReserva"])
            {
                dataReserva = dr["dataReserva"] + "";
            }
            if (DBNull.Value != dr["prazoReserva"])
            {
                prazoReserva = dr["prazoReserva"] + "";
            }
            return new ConsultaEmprestimoModel()
            {
                NomeItem = nomeItem,
                NomeAutor = nomeAutor,
                nomeEditora = nomeEditora,
                StatusItem = statusItem,
                DataReserva = dataReserva,
                DataRetorno = prazoReserva
            };
        }
    }
}
