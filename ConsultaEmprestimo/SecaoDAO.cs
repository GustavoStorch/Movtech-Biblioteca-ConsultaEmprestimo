﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaEmprestimo
{
    public class SecaoDAO
    {
        private SqlConnection Connection { get; }

        public SecaoDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<ConsultaEmprestimoModel> GetSecoes()
        {
            List<ConsultaEmprestimoModel> secoes = new List<ConsultaEmprestimoModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT descricaoSecao FROM mvtBibSecao ORDER BY codSecao");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        secoes.Add(PopulateDrSecao(dr));
                    }
                }
            }
            return secoes;
        }

        public ConsultaEmprestimoModel PopulateDrSecao(SqlDataReader dr)
        {
            string descricaoSecao = "";

            if (DBNull.Value != dr["descricaoSecao"])
            {
                descricaoSecao = dr["descricaoSecao"] + "";
            }

            return new ConsultaEmprestimoModel()
            {
                NomeSecao = descricaoSecao
            };
        }
    }
}
