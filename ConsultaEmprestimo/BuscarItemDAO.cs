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

        public List<ConsultaEmprestimoModel> GetItens()
        {
            List<ConsultaEmprestimoModel> itens = new List<ConsultaEmprestimoModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT nome, tipoItem, nomeLocal, nomeAutor, secao, statusItem FROM mvtBibItemAcervo ORDER BY codItem");
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
            string tipoItem = "";
            string nomeLocal = "";
            string nomeAutor = "";
            string secao = "";
            string statusItem = "";

            if (DBNull.Value != dr["nome"])
            {
                nome = dr["nome"] + "";
            }
            if (DBNull.Value != dr["tipoItem"])
            {
                tipoItem = dr["tipoItem"] + "";
            }
            if (DBNull.Value != dr["nomeLocal"])
            {
                nomeLocal = dr["nomeLocal"] + "";
            }
            if (DBNull.Value != dr["nomeAutor"])
            {
                nomeAutor = dr["nomeAutor"] + "";
            }
            if (DBNull.Value != dr["secao"])
            {
                secao = dr["secao"] + "";
            }
            if (DBNull.Value != dr["statusItem"])
            {
                statusItem = dr["statusItem"] + "";
            }

            return new ConsultaEmprestimoModel()
            {
                NomeItem = nome,
                TipoItem = tipoItem,
                NomeLocal = nomeLocal,
                NomeAutor = nomeAutor,
                NomeSecao = secao,
                StatusItem = statusItem
            };
        }
    }
}
