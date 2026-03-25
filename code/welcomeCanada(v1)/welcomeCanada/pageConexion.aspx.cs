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