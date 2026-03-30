using System.Data.SqlClient;
using welcomeCanada.Database;
using welcomeCanada.Models;

namespace welcomeCanada.Services
{
    public class AuthService
    {
        public string Inscrire(TypeUtilisateur type, string nom, string prenom, string email, string mdp)
        {
            using (var conn = ConnexionDB.Instance.GetConnection())
            {
                SqlCommand check = new SqlCommand(
                    "SELECT COUNT(*) FROM Utilisateurs WHERE Email=@Email", conn);

                check.Parameters.AddWithValue("@Email", email);

                if ((int)check.ExecuteScalar() > 0)
                    return "Email déjà utilisé";

                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Utilisateurs 
                    (Nom, Prenom, Email, MotDePasse, TypeUtilisateur)
                    VALUES (@Nom,@Prenom,@Email,@Mdp,@Type)", conn);

                cmd.Parameters.AddWithValue("@Nom", nom);
                cmd.Parameters.AddWithValue("@Prenom", prenom);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Mdp", mdp);
                cmd.Parameters.AddWithValue("@Type", type.ToString());

                cmd.ExecuteNonQuery();
            }

            return "Inscription réussie";
        }

        public bool Connexion(string email, string mdp)
        {
            using (var conn = ConnexionDB.Instance.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Utilisateurs WHERE Email=@Email AND MotDePasse=@Mdp", conn);

                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Mdp", mdp);

                return (int)cmd.ExecuteScalar() > 0;
            }
        }
    }
}