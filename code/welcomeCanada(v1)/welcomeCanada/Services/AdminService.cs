using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using welcomeCanada.Database;
using welcomeCanada.Models;

namespace welcomeCanada.Services
{
    public class AdminService
    {
        public DataTable GetUtilisateurs(string nom = "", string type = "")
        {
            using (SqlConnection db = ConnexionDB.Instance.GetConnection())
            {
                string query = "SELECT Id, Nom, Prenom, Email, TypeUtilisateur FROM Utilisateurs WHERE 1=1";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;

                if (!string.IsNullOrWhiteSpace(nom))
                {
                    query += " AND Nom LIKE @nom";
                    cmd.Parameters.AddWithValue("@nom", "%" + nom + "%");
                }

                if (!string.IsNullOrWhiteSpace(type))
                {
                    query += " AND TypeUtilisateur = @type";
                    cmd.Parameters.AddWithValue("@type", type);
                }

                cmd.CommandText = query;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

        public void SupprimerUtilisateur(int id)
        {
            using (SqlConnection db = ConnexionDB.Instance.GetConnection())
            {
                string query = "DELETE FROM Utilisateurs WHERE Id = @id";

                SqlCommand cmd = new SqlCommand(query, db);
                cmd.Parameters.AddWithValue("@id", id);

                db.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }


}