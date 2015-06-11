using System.Data;
using System.Data.SqlClient;

namespace TecWeb.WS.DAO
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
