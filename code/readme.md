// Folder Database ConnexionDB.CS
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

// Model Utilisateur
namespace welcomeCanada.Models
{
    public enum TypeUtilisateur { Etudiant, Travailleur }

    public interface IUtilisateur
    {
        string Nom { get; set; }
        string Prenom { get; set; }
        string Email { get; set; }
        string MotDePasse { get; set; }
    }

    public class Etudiant : IUtilisateur
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string MotDePasse { get; set; }
    }

    public class Travailleur : IUtilisateur
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string MotDePasse { get; set; }
    }

    public class UtilisateurFactory
    {
        public static IUtilisateur CreerUtilisateur(TypeUtilisateur type)
        {
            switch (type)
            {
                case TypeUtilisateur.Etudiant:
                    return new Etudiant();
                case TypeUtilisateur.Travailleur:
                    return new Travailleur();
                default:
                    throw new System.Exception("Type utilisateur inconnu");
            }
        }
    }
}

//Serveices AuthServices
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
            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=welcomeCanadaDB;Integrated Security=True";
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

// pageConexion
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pageConexion.aspx.cs" Inherits="welcomeCanada.pageConexion" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Connexion Welcome Canada</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 50px; font-family: Arial;">

            <h2>Connexion</h2>

            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
            <br /><br />

            <asp:Label ID="lblEmail" runat="server" Text="Email :"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lblMotDePasse" runat="server" Text="Mot de passe :"></asp:Label>
            <asp:TextBox ID="txtMotDePasse" runat="server" TextMode="Password"></asp:TextBox>
            <br /><br />

            <asp:Button ID="btnConnexion" runat="server" Text="Se connecter" OnClick="btnConnexion_Click" />
            <br /><br />

            <asp:Button ID="btnInscrire" runat="server" Text="S'inscrire" OnClick="btnInscrire_Click" />

        </div>
    </form>
</body>
</html>



using System;
using welcomeCanada.Models;
using welcomeCanada.Services;

namespace welcomeCanada
{
    public partial class pageConexion : System.Web.UI.Page
    {
        private AuthService auth;

        protected void Page_Load(object sender, EventArgs e)
        {
            auth = new AuthService();
        }

        // Bouton connexion
        protected void btnConnexion_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string mdp = txtMotDePasse.Text.Trim();

            bool ok = auth.Connexion(email, mdp);
            lblMessage.ForeColor = ok ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            lblMessage.Text = ok ? "Connexion réussie !" : "Email ou mot de passe incorrect";
        }

        // Bouton inscription
        protected void btnInscrire_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string mdp = txtMotDePasse.Text.Trim();

            string resultat = auth.Inscrire(
                TypeUtilisateur.Etudiant, // pour le test, on prend Etudiant
                "NomTest",
                "PrenomTest",
                email,
                mdp
            );

            lblMessage.ForeColor = System.Drawing.Color.Blue;
            lblMessage.Text = resultat;
        }
    }
}
