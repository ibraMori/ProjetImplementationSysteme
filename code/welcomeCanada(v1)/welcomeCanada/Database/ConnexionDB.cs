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
            var config = ConfigurationManager.ConnectionStrings["DefaultConnection"];

            if (config != null)
            {
                connectionString = config.ConnectionString;
            }
            else
            {
                connectionString =
                    @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=welcomeCanDB;Integrated Security=True";
            }
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