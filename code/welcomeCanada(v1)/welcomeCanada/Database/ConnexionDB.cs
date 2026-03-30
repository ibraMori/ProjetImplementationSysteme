using System.Data.SqlClient;

namespace welcomeCanada.Database
{
    public class ConnexionDB
    {
        private static ConnexionDB instance;
        private static readonly object lockObj = new object();

        private string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=welcomeCanDB;Integrated Security=True";

        private ConnexionDB() { }

        public static ConnexionDB Instance
        {
            get
            {
                lock (lockObj)
                {
                    if (instance == null)
                        instance = new ConnexionDB();
                    return instance;
                }
            }
        }

        public SqlConnection GetConnection()
        {
            var conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}