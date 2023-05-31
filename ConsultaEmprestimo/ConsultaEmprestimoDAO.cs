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

        public List<ConsultaEmprestimoModel> BuscarEmprestimos(ConsultaEmprestimoModel consulta)
        {
            List<ConsultaEmprestimoModel> buscas = new List<ConsultaEmprestimoModel>();

            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT r.nomeItem, i.nomeAutor, i.nomeEditora, r.statusItem, r.dataReserva, r.prazoReserva");
                sql.AppendLine("FROM mvtBibReserva r INNER JOIN mvtBibItemAcervo i ON r.codItem = i.codItem");
                sql.AppendLine("WHERE 1 = 1");
                if (!string.IsNullOrEmpty(consulta.NomeItem))
                {
                    sql.AppendLine($"AND r.nomeItem LIKE '%{consulta.NomeItem}%'");
                }
                if (!string.IsNullOrEmpty(consulta.NomeLeitor))
                {
                    sql.AppendLine($"AND r.nomeLeitor LIKE '%{consulta.NomeLeitor}%'");
                }
                if (!string.IsNullOrEmpty(consulta.StatusItem))
                {
                    sql.AppendLine($"AND r.statusItem LIKE '%{consulta.StatusItem}%'");
                }
                if (!string.IsNullOrEmpty(consulta.NomeAutor))
                {
                    sql.AppendLine($"AND i.nomeAutor LIKE '%{consulta.NomeAutor}%'");
                }
                if (!string.IsNullOrEmpty(consulta.NomeLocal))
                {
                    sql.AppendLine($"AND i.nomeLocal LIKE '%{consulta.NomeLocal}%'");
                }
                if (!string.IsNullOrEmpty(consulta.NomeSecao))
                {
                    sql.AppendLine($"AND i.secao LIKE '%{consulta.NomeSecao}%'");
                }

                command.CommandText = sql.ToString();

                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        buscas.Add(PopulateDrBusca(dr));
                    }
                }
            }
            return buscas;
        }

        private ConsultaEmprestimoModel PopulateDrBusca(SqlDataReader dr)
        {
            ConsultaEmprestimoModel model = new ConsultaEmprestimoModel();

            if (DBNull.Value != dr["nomeItem"])
            {
                model.NomeItem = dr["nomeItem"].ToString();
            }
            if (DBNull.Value != dr["nomeAutor"])
            {
                model.NomeAutor = dr["nomeAutor"].ToString();
            }
            if (DBNull.Value != dr["nomeEditora"])
            {
                model.NomeEditora = dr["nomeEditora"].ToString();
            }
            if (DBNull.Value != dr["statusItem"])
            {
                model.StatusItem = dr["statusItem"].ToString();
            }
            if (DBNull.Value != dr["dataReserva"])
            {
                model.DataReserva = dr["dataReserva"].ToString();
            }
            if (DBNull.Value != dr["prazoReserva"])
            {
                model.DataRetorno = dr["prazoReserva"].ToString();
            }

            return model;
        }
    }
}