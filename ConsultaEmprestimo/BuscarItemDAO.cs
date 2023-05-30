using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaEmprestimo
{
    public class BuscarItemDAO
    {
        private SqlConnection Connection { get; }

        public BuscarItemDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public string GetNomeAutor(ConsultaEmprestimoModel consultaEmprestimo)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT nomeAutor FROM mvtBibItemAcervo WHERE codItem = @codItem");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codItem", consultaEmprestimo.CodItem);
                string result = Convert.ToString(command.ExecuteScalar());

                if (result != null)
                {
                    return result.ToString();
                }
            }
            return string.Empty;
        }

        public string GetNomeLocal(ConsultaEmprestimoModel consultaEmprestimo)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT nomeLocal FROM mvtBibItemAcervo WHERE codItem = @codItem");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codItem", consultaEmprestimo.CodItem);
                string result = Convert.ToString(command.ExecuteScalar());

                if (result != null)
                {
                    return result.ToString();
                }
            }
            return string.Empty;
        }

        public string GetNomeSecao(ConsultaEmprestimoModel consultaEmprestimo)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT secao FROM mvtBibItemAcervo WHERE codItem = @codItem");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codItem", consultaEmprestimo.CodItem);
                string result = Convert.ToString(command.ExecuteScalar());

                if (result != null)
                {
                    return result.ToString();
                }
            }
            return string.Empty;
        }

        public string GetTipoItem(ConsultaEmprestimoModel consultaEmprestimo)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT tipoItem FROM mvtBibItemAcervo WHERE codItem = @codItem");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codItem", consultaEmprestimo.CodItem);
                string result = Convert.ToString(command.ExecuteScalar());

                if (result != null)
                {
                    return result.ToString();
                }
            }
            return string.Empty;
        }

        public List<ConsultaEmprestimoModel> GetItens()
        {
            List<ConsultaEmprestimoModel> itens = new List<ConsultaEmprestimoModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codItem, nome FROM mvtBibItemAcervo ORDER BY codItem");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        itens.Add(PopulateDrItem(dr));
                    }
                }
            }
            return itens;
        }

        public ConsultaEmprestimoModel PopulateDrItem(SqlDataReader dr)
        {
            string nome = "";
            string codItem = "";

            if (DBNull.Value != dr["nome"])
            {
                nome = dr["nome"] + "";
            }
            if (DBNull.Value != dr["codItem"])
            {
                codItem = dr["codItem"] + "";
            }

            return new ConsultaEmprestimoModel()
            {
                NomeItem = nome,
                CodItem = codItem
            };
        }
    }
}
