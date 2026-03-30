using System;
using welcomeCanada.Services;

namespace welcomeCanada
{
    public partial class PageConnexion : System.Web.UI.Page
    {
        AuthService auth = new AuthService();

        protected void BtnConnexion_Click(object sender, EventArgs e)
        {
            if (auth.Connexion(txtEmail.Text, txtMotDePasse.Text))
            {
                Session["EmailUtilisateur"] = txtEmail.Text;
                Response.Redirect("Home.aspx");
            }
            else
            {
                lblMessage.Text = "Email ou mot de passe incorrect";
            }
        }
    }
}