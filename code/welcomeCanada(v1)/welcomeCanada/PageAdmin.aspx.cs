using System;
using welcomeCanada.Services;

namespace welcomeCanada
{
    public partial class PageAdmin : System.Web.UI.Page
    {
        AdminService admin = new AdminService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null || Session["Role"].ToString() != "admin")
            {
                Response.Redirect("PageConnexion.aspx");
            }

            if (!IsPostBack)
            {
                LoadUsers();
            }
        }

        protected void btnAddGuide_Click(object sender, EventArgs e)
        {
            admin.AddGuide(txtGuide.Text);
        }

        protected void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUserId.Text);
            admin.DeleteUser(id);
            LoadUsers();
        }

        private void LoadUsers()
        {
            gvUsers.DataSource = admin.GetUsers();
            gvUsers.DataBind();
        }
    }
}