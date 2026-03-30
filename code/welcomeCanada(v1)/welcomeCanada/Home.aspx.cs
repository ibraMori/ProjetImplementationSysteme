using System;

namespace welcomeCanada
{
    public partial class Home : System.Web.UI.Page
    {
        // ======================
        // STATE PATTERN
        // ======================
        interface IUserState
        {
            void Handle(Home page);
        }

        class LoggedInState : IUserState
        {
            public void Handle(Home page)
            {
                page.lblBienvenue.Text = "Connecté : " + page.Session["EmailUtilisateur"];
            }
        }

        class LoggedOutState : IUserState
        {
            public void Handle(Home page)
            {
                page.Response.Redirect("PageConnexion.aspx");
            }
        }

        // ======================
        // PAGE LOAD
        // ======================
        protected void Page_Load(object sender, EventArgs e)
        {
            IUserState state;

           
            if (Session["EmailUtilisateur"] == null)
            {
                state = new LoggedOutState();
            }
            else
            {
                state = new LoggedInState();
            }

            state.Handle(this);
        }

        // ======================
        // LOGOUT
        // ======================
        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("PageConnexion.aspx");
        }

        // ======================
        // NAVIGATION LOGEMENT
        // ======================
        protected void BtnLogement_Click(object sender, EventArgs e)
        {
            Response.Redirect("PageLogement.aspx");
        }
    }
}