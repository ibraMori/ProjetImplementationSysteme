using System;
using System.Data.SqlClient;
using welcomeCanada.Models;

namespace welcomeCanada.Services
{
    public class AuthService
    {
        private SqlConnection connection;

        public AuthService()
        {
            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=welcomeCanDB;Integrated Security=True;";
            connection = new SqlConnection(connStr);
            connection.Open();
        }

        // Inscription
        public string Inscrire(TypeUtilisateur type, string nom, string prenom, string email, string mdp)
        {
            IUtilisateur user = UtilisateurFactory.CreerUtilisateur(type);
            user.Nom = nom;
            user.Prenom = prenom;
            user.Email = email;
            user.MotDePasse = mdp;

            // Vérifier si email existe
            string checkQuery = "SELECT COUNT(*) FROM Utilisateurs WHERE Email=@Email";
            SqlCommand cmdCheck = new SqlCommand(checkQuery, connection);
            cmdCheck.Parameters.AddWithValue("@Email", user.Email);
            int count = (int)cmdCheck.ExecuteScalar();
            if (count > 0)
                return "Email déjà utilisé";

            // Ajouter utilisateur
            string insertQuery = "INSERT INTO Utilisateurs (Nom,Prenom,Email,MotDePasse,TypeUtilisateur) VALUES (@Nom,@Prenom,@Email,@MotDePasse,@TypeUtilisateur)";
            SqlCommand cmdInsert = new SqlCommand(insertQuery, connection);
            cmdInsert.Parameters.AddWithValue("@Nom", user.Nom);
            cmdInsert.Parameters.AddWithValue("@Prenom", user.Prenom);
            cmdInsert.Parameters.AddWithValue("@Email", user.Email);
            cmdInsert.Parameters.AddWithValue("@MotDePasse", user.MotDePasse);
            cmdInsert.Parameters.AddWithValue("@TypeUtilisateur", type.ToString());
            cmdInsert.ExecuteNonQuery();

            return "Inscription réussie";
        }

        // Connexion
        public bool Connexion(string email, string mdp)
        {
            string query = "SELECT COUNT(*) FROM Utilisateurs WHERE Email=@Email AND MotDePasse=@MotDePasse";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@MotDePasse", mdp);
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        public void Fermer()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
    }
}