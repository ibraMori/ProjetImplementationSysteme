using System;
using welcomeCanada.Models;
using welcomeCanada.Services;

namespace welcomeCanada
{
    public partial class PageConnexion : System.Web.UI.Page
    {
        AuthService auth = new AuthService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConnexion_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string mdp = txtMotDePasse.Text.Trim();

            if (auth.Connexion(email, mdp))
            {
                Session["EmailUtilisateur"] = email;
                string nom = auth.GetNomByEmail(email);
                string prenom = auth.GetPrenomByEmail(email);
                TypeUtilisateur? type = auth.GetTypeUtilisateurByEmail(email);

                if (type != null)
                {
                    Session["Nom"] = nom;
                    Session["Prenom"] = prenom;
                    Session["TypeUtilisateur"] = type;
                    Response.Redirect("Home.aspx");
                }
            }
            else
            {
                lblMessage.Text = "Email ou mot de passe incorrect";
            }
        }
    }
}