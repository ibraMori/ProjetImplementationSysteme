using System;
using System.Data.SqlClient;
using welcomeCanada.Database;
using welcomeCanada.Models;

namespace welcomeCanada.Services
{
    public class AuthService
    {
        private ConnexionDB db = ConnexionDB.Instance;

        // =========================
        // INSCRIPTION UTILISATEUR
        // =========================
        public string Inscrire(TypeUtilisateur type, string nom, string prenom, string email, string mdp)
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"INSERT INTO Utilisateurs
                                (Nom, Prenom, Email, MotDePasse, TypeUtilisateur)
                                VALUES
                                (@Nom, @Prenom, @Email, @Mdp, @Type)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Nom", nom);
                cmd.Parameters.AddWithValue("@Prenom", prenom);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Mdp", mdp);
                cmd.Parameters.AddWithValue("@Type", type.ToString());

                cmd.ExecuteNonQuery();

                return "Inscription réussie";
            }
        }

        // =========================
        // CONNEXION UTILISATEUR
        // =========================
        public bool Connexion(string email, string mdp)
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"SELECT COUNT(*) 
                                 FROM Utilisateurs 
                                 WHERE Email = @Email AND MotDePasse = @Mdp";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Mdp", mdp);

                int result = (int)cmd.ExecuteScalar();

                return result > 0;
            }
        }
        public string GetNomByEmail(string email)
        {
            using (SqlConnection db = ConnexionDB.Instance.GetConnection())
            {
                string query = "SELECT Nom FROM Utilisateurs WHERE Email = @email";

                SqlCommand cmd = new SqlCommand(query, db);
                cmd.Parameters.AddWithValue("@email", email);

                db.Open();

                object result = cmd.ExecuteScalar();

                return result != null ? result.ToString() : null;
            }
        }
        public string GetPrenomByEmail(string email)
        {
            using (SqlConnection db = ConnexionDB.Instance.GetConnection())
            {
                string query = "SELECT Prenom FROM Utilisateurs WHERE Email = @email";

                SqlCommand cmd = new SqlCommand(query, db);
                cmd.Parameters.AddWithValue("@email", email);

                db.Open();

                object result = cmd.ExecuteScalar();

                return result != null ? result.ToString() : null;
            }
        }
        public TypeUtilisateur? GetTypeUtilisateurByEmail(string email)
        {
            using (SqlConnection db = ConnexionDB.Instance.GetConnection())
            {
                string query = "SELECT TypeUtilisateur FROM Utilisateurs WHERE Email = @email";

                SqlCommand cmd = new SqlCommand(query, db);
                cmd.Parameters.AddWithValue("@email", email);

                db.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    return (TypeUtilisateur)Enum.Parse(
                        typeof(TypeUtilisateur),
                        result.ToString()
                    );
                }

                return null;
            }
        }

        // =========================
        // CONNEXION ADMIN
        // =========================
        public bool ConnexionAdmin(string adminId, string mdp)
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"SELECT COUNT(*) 
                                 FROM Admin 
                                 WHERE AdminId = @Id AND MotDePasse = @Mdp";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Id", adminId);
                cmd.Parameters.AddWithValue("@Mdp", mdp);

                int result = (int)cmd.ExecuteScalar();

                return result > 0;
            }
        }
    }
}