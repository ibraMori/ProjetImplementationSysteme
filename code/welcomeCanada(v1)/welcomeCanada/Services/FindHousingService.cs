using System.Data;
using System.Data.SqlClient;
using welcomeCanada.Database;

namespace welcomeCanada.Services
{
    public class FindHousingService
    {
        // ============================
        // FILTRAGE (ville, budget, dimension)
        // ============================
        public DataTable GetLogements(string ville = null, decimal? prixMax = null, int? dimensionMin = null)
        {
            using (var conn = ConnexionDB.Instance.GetConnection())
            {
                DataTable dt = new DataTable();

                string query = "SELECT Id, Titre, Ville, Prix, Dimension, Description FROM Logements WHERE 1=1";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                // Filtre ville
                if (!string.IsNullOrEmpty(ville))
                {
                    query += " AND Ville LIKE @Ville";
                    cmd.Parameters.AddWithValue("@Ville", "%" + ville + "%");
                }

                // Filtre prix
                if (prixMax.HasValue)
                {
                    query += " AND Prix <= @PrixMax";
                    cmd.Parameters.AddWithValue("@PrixMax", prixMax.Value);
                }

                // Filtre dimension
                if (dimensionMin.HasValue)
                {
                    query += " AND Dimension >= @DimensionMin";
                    cmd.Parameters.AddWithValue("@DimensionMin", dimensionMin.Value);
                }

                cmd.CommandText = query;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                return dt;
            }
        }

        // ============================
        // TOUS LES LOGEMENTS
        // ============================
        public DataTable GetAllLogements()
        {
            return GetLogements();
        }
    }
}