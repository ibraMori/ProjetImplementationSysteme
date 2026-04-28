using System.Data.SqlClient;
using System.Configuration;

namespace welcomeCanada.Database
{
    public class ConnexionDB
    {
        private static ConnexionDB instance;
        private string connectionString;

        private ConnexionDB()
        {
            connectionString = ConfigurationManager
                .ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public static ConnexionDB Instance
        {
            get
            {
                if (instance == null)
                    instance = new ConnexionDB();

                return instance;
            }
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}