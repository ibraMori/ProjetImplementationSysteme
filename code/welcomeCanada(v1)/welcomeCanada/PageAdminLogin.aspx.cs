using System;
using welcomeCanada.Services;

namespace welcomeCanada
{
    public partial class PageAdminLogin : System.Web.UI.Page
    {
        AuthService auth = new AuthService();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtAdminId.Text.Trim();
            string mdp = txtPassword.Text.Trim();

            if (auth.ConnexionAdmin(id, mdp))
            {
                Session["Role"] = "admin";
                Response.Redirect("PageAdmin.aspx");
            }
            else
            {
                lblError.Text = "Accès refusé";
            }
        }
    }
}