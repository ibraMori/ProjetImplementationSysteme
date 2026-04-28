using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using welcomeCanada.Database;
using welcomeCanada.Models;

namespace welcomeCanada.Services
{
    public class GuideService
    {
        public DataTable GetGuides()
        {
            using (SqlConnection db = ConnexionDB.Instance.GetConnection())
            {
                string query = "SELECT Id, Titre, Categorie, TypeUtilisateur FROM Guide";

                SqlDataAdapter adapter = new SqlDataAdapter(query, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

        public DataTable GetAllGuidesForObserver()
        {
            using (SqlConnection db = ConnexionDB.Instance.GetConnection())
            {
                string query = "SELECT Id, Titre, Description, Categorie, TypeUtilisateur FROM Guide";

                SqlDataAdapter adapter = new SqlDataAdapter(query, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

        public void AjouterGuide(string titre, string description, GuideCategorie categorie, TypeUtilisateur typeUtilisateur)
        {
            if (string.IsNullOrWhiteSpace(titre))
                throw new Exception("Titre obligatoire");

            if (string.IsNullOrWhiteSpace(description))
                throw new Exception("Description obligatoire");

            using (SqlConnection db = ConnexionDB.Instance.GetConnection())
            {
                string query = @"INSERT INTO Guide (Titre, Description, Categorie, TypeUtilisateur)
                                 VALUES (@titre, @description, @categorie, @typeUtilisateur)";

                SqlCommand cmd = new SqlCommand(query, db);
                cmd.Parameters.AddWithValue("@titre", titre);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@categorie", categorie.ToString());
                cmd.Parameters.AddWithValue("@typeUtilisateur", typeUtilisateur.ToString());

                db.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void SupprimerGuide(int id)
        {
            using (SqlConnection db = ConnexionDB.Instance.GetConnection())
            {
                string query = "DELETE FROM Guide WHERE Id = @id";

                SqlCommand cmd = new SqlCommand(query, db);
                cmd.Parameters.AddWithValue("@id", id);

                db.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataRow GetGuideById(int id)
        {
            using (SqlConnection db = ConnexionDB.Instance.GetConnection())
            {
                string query = "SELECT Id, Titre, Description, Categorie, TypeUtilisateur FROM Guide WHERE Id = @id";

                SqlCommand cmd = new SqlCommand(query, db);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                    return dt.Rows[0];

                return null;
            }
        }

        public void ModifierGuide(int id, string titre, string description, GuideCategorie categorie, TypeUtilisateur typeUtilisateur)
        {
            if (string.IsNullOrWhiteSpace(titre))
                throw new Exception("Titre obligatoire");

            if (string.IsNullOrWhiteSpace(description))
                throw new Exception("Description obligatoire");

            using (SqlConnection db = ConnexionDB.Instance.GetConnection())
            {
                string query = @"UPDATE Guide 
                                 SET Titre = @titre,
                                     Description = @description,
                                     Categorie = @categorie,
                                     TypeUtilisateur = @typeUtilisateur
                                 WHERE Id = @id";

                SqlCommand cmd = new SqlCommand(query, db);
                cmd.Parameters.AddWithValue("@titre", titre);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@categorie", categorie.ToString());
                cmd.Parameters.AddWithValue("@typeUtilisateur", typeUtilisateur.ToString());
                cmd.Parameters.AddWithValue("@id", id);

                db.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}