using System;
using System.Data;
using System.Data.SqlClient;
using welcomeCanada.Database;

namespace welcomeCanada.Services
{
    public class FindHousingService
    {
        private ConnexionDB db = ConnexionDB.Instance;

        // =========================
        // TOUS LES LOGEMENTS
        // =========================
        public DataTable GetAllLogements()
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = "SELECT * FROM Logements";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        // =========================
        // FILTRAGE AVANCÉ
        // =========================
        public DataTable GetLogements(string ville, decimal? prixMax, int? dimensionMin)
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"SELECT * FROM Logements WHERE 1=1";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                // filtre ville
                if (!string.IsNullOrEmpty(ville))
                {
                    query += " AND Ville LIKE @Ville";
                    cmd.Parameters.AddWithValue("@Ville", "%" + ville + "%");
                }

                // filtre prix max
                if (prixMax.HasValue)
                {
                    query += " AND Prix <= @PrixMax";
                    cmd.Parameters.AddWithValue("@PrixMax", prixMax.Value);
                }

                // filtre dimension min
                if (dimensionMin.HasValue)
                {
                    query += " AND Dimension >= @DimMin";
                    cmd.Parameters.AddWithValue("@DimMin", dimensionMin.Value);
                }

                cmd.CommandText = query;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }
    }
}