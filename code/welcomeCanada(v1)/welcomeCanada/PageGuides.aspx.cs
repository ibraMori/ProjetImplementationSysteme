using System;

namespace welcomeCanada
{
    public partial class PageGuides : System.Web.UI.Page
    {
        protected void btnLogement_Click(object sender, EventArgs e)
        {
            Response.Redirect("PageLogement.aspx");
        }

        protected void btnBanque_Click(object sender, EventArgs e)
        {
            Response.Redirect("PageBanques.aspx");
        }

        protected void btnNAS_Click(object sender, EventArgs e)
        {
            Response.Redirect("PageNAS.aspx");
        }

        protected void btnOPUS_Click(object sender, EventArgs e)
        {
            Response.Redirect("PageOPUS.aspx");
        }
    }
}