using System;
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
                Response.Redirect("PageGuides.aspx");
            }
            else
            {
                lblMessage.Text = "Email ou mot de passe incorrect";
            }
        }
    }
}