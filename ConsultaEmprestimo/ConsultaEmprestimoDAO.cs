using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaEmprestimo
{
    public class ConsultaEmprestimoDAO
    {
        private SqlConnection Connection { get; }

        public ConsultaEmprestimoDAO(SqlConnection connection)
        {
            Connection = connection;
        }


    }
}
