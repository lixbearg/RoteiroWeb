using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace TecWeb.Agenda.DAO
{
    class Util
    {
        public static IDbConnection ObterConexao()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["StringConexao"];
            connection.Open();

            return connection;
        }
    }
}
