using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alifAcademyDeposit
{
    public static class SqlClientModel
    {
        private static string _connectionString = "Data source=localhost; initial catalog=AlifAcademy; integrated security=true";

        public static SqlConnection GetNewSqlConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
