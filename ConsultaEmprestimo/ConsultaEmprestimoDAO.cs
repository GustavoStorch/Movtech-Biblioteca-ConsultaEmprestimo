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

        public List<ConsultaEmprestimoModel> BuscarEmprestimosPorItem(ConsultaEmprestimoModel consulta)
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

                command.Parameters.AddWithValue("@nomeItem", consulta.NomeItem);
                command.Parameters.AddWithValue("@nomeLeitor", consulta.NomeLeitor);
                command.Parameters.AddWithValue("@statusItem", consulta.StatusItem);

                command.CommandText = sql.ToString();

                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        buscas.Add(PopulateDrBuscaPorItem(dr));
                    }
                }
            }

            return buscas;
        }

        private ConsultaEmprestimoModel PopulateDrBuscaPorItem(SqlDataReader dr)
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

        public List<ConsultaEmprestimoModel> BuscarEmprestimosPorLeitor(ConsultaEmprestimoModel consulta)
        {
            List<ConsultaEmprestimoModel> buscas = new List<ConsultaEmprestimoModel>();

            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT r.nomeItem, i.nomeAutor, i.nomeEditora, r.statusItem, r.dataReserva, r.prazoReserva");
                sql.AppendLine("FROM mvtBibReserva r INNER JOIN mvtBibItemAcervo i ON r.codItem = i.codItem");
                sql.AppendLine("WHERE r.nomeLeitor LIKE '%' + @nomeLeitor + '%' ORDER BY r.codReserva");
                command.Parameters.AddWithValue("@nomeLeitor", consulta.NomeLeitor);

                command.CommandText = sql.ToString();

                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        buscas.Add(PopulateDrBuscaPorLeitor(dr));
                    }
                }
            }

            return buscas;
        }

        private ConsultaEmprestimoModel PopulateDrBuscaPorLeitor(SqlDataReader dr)
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