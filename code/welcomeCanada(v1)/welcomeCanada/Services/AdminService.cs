using System.Data;
using System.Data.SqlClient;
using welcomeCanada.Database;

namespace welcomeCanada.Services
{
    public class AdminService
    {
        SqlConnection db = ConnexionDB.Instance.GetConnection();

        public void AddGuide(string guide)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Guides (Title) VALUES (@Title)", db);
            cmd.Parameters.AddWithValue("@Title", guide);
            db.Open();
            cmd.ExecuteNonQuery();
            db.Close();
        }

        public DataTable GetUsers()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Email, Role FROM Users", db);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void DeleteUser(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE Id=@Id", db);
            cmd.Parameters.AddWithValue("@Id", id);
            db.Open();
            cmd.ExecuteNonQuery();
            db.Close();
        }
    }
}