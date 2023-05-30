using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaEmprestimo
{
    public class BuscarLeitorDAO
    {
        private SqlConnection Connection { get; }

        public BuscarLeitorDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<ConsultaEmprestimoModel> GetLeitores()
        {
            List<ConsultaEmprestimoModel> leitores = new List<ConsultaEmprestimoModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT nomeLeitor FROM mvtBibLeitor ORDER BY codLeitor");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        leitores.Add(PopulateDrLeitor(dr));
                    }
                }
            }
            return leitores;
        }

        public ConsultaEmprestimoModel PopulateDrLeitor(SqlDataReader dr)
        {
            string nomeLeitor = "";

            if (DBNull.Value != dr["nomeLeitor"])
            {
                nomeLeitor = dr["nomeLeitor"] + "";
            }

            return new ConsultaEmprestimoModel()
            {
                NomeLeitor = nomeLeitor
            };
        }
    }
}
