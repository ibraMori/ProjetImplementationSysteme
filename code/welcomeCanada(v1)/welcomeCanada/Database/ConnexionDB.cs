using System.Data.SqlClient;

namespace welcomeCanada.Database
{
    public class ConnexionDB
    {
        private static ConnexionDB instance = null;
        private readonly SqlConnection connection;

        private ConnexionDB()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=welcomeCanadaDB;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
    }
}