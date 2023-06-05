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
                sql.AppendLine("SELECT DISTINCT i.nome, i.nomeAutor, i.nomeEditora, r.statusItem, i.secao, i.tipoItem, i.nomeLocal, r.nomeLeitor, r.dataReserva, r.prazoReserva");                
                sql.AppendLine("FROM mvtBibReserva r INNER JOIN mvtBibItemAcervo i ON r.codItem = i.codItem");
                sql.AppendLine("WHERE 1 = 1");
                if (!string.IsNullOrEmpty(consulta.NomeItem))
                {
                    sql.AppendLine($"AND i.nome LIKE '%' + @NomeItem + '%'");
                    command.Parameters.AddWithValue("@NomeItem", consulta.NomeItem);
                }
                if (!string.IsNullOrEmpty(consulta.NomeLeitor))
                {
                    sql.AppendLine($"AND r.nomeLeitor LIKE '%' + @nomeLeitor + '%'");
                    command.Parameters.AddWithValue("@nomeLeitor", consulta.NomeLeitor);
                }
                if (!string.IsNullOrEmpty(consulta.StatusItem))
                {
                    sql.AppendLine($"AND r.statusItem LIKE '%' + @statusItem + '%'");
                    command.Parameters.AddWithValue("@statusItem", consulta.StatusItem);
                }
                if (!string.IsNullOrEmpty(consulta.NomeAutor))
                {
                    sql.AppendLine($"AND i.nomeAutor LIKE '%' + @nomeAutor + '%'");
                    command.Parameters.AddWithValue("@nomeAutor", consulta.NomeAutor);
                }
                if (!string.IsNullOrEmpty(consulta.NomeLocal))
                {
                    sql.AppendLine($"AND i.nomeLocal LIKE '%' + @nomeLocal + '%'");
                    command.Parameters.AddWithValue("@nomeLocal", consulta.NomeLocal);
                }
                if (!string.IsNullOrEmpty(consulta.NomeSecao))
                {
                    sql.AppendLine($"AND i.secao LIKE '%' + @secao + '%'");
                    command.Parameters.AddWithValue("@secao", consulta.NomeSecao);
                }
                if (!string.IsNullOrEmpty(consulta.TipoItem))
                {
                    sql.AppendLine($"AND i.tipoItem LIKE '%' + @tipoItem + '%'");
                    command.Parameters.AddWithValue("@tipoItem", consulta.TipoItem);
                }
                if (!string.IsNullOrEmpty(consulta.DataReserva) && !string.IsNullOrEmpty(consulta.DataRetorno))
                {
                    sql.AppendLine($"AND r.prazoReserva >= @DataInicio AND r.prazoReserva <= @DataFim");
                    command.Parameters.AddWithValue("@DataInicio", consulta.DataReserva);
                    command.Parameters.AddWithValue("@DataFim", consulta.DataRetorno);
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

            if (DBNull.Value != dr["nome"])
            {
                model.NomeItem = dr["nome"].ToString();
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
            if (DBNull.Value != dr["nomeLeitor"])
            {
                model.NomeLeitor = dr["nomeLeitor"].ToString();
            }
            if (DBNull.Value != dr["nomeLocal"])
            {
                model.NomeLocal = dr["nomeLocal"].ToString();
            }
            if (DBNull.Value != dr["secao"])
            {
                model.NomeSecao = dr["secao"].ToString();
            }
            if (DBNull.Value != dr["tipoItem"])
            {
                model.TipoItem = dr["tipoItem"].ToString();
            }

            return model;
        }
    }
}