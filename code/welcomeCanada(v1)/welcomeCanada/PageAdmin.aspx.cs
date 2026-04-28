using System;
using welcomeCanada.Models;
using welcomeCanada.Services;

namespace welcomeCanada
{
    public partial class PageAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCategorie.DataSource = Enum.GetNames(typeof(GuideCategorie));
                ddlCategorie.DataBind();

                ddlTypeUtilisateurGuide.DataSource = Enum.GetNames(typeof(TypeUtilisateur));
                ddlTypeUtilisateurGuide.DataBind();

                ddlTypeUser.DataSource = Enum.GetNames(typeof(TypeUtilisateur));
                ddlTypeUser.DataBind();
                ddlTypeUser.Items.Insert(0, "Tous");

                LoadGuides();
                LoadUsers();
            }
        }

        private void LoadGuides()
        {
            GuideService service = new GuideService();
            gvGuides.DataSource = service.GetGuides();
            gvGuides.DataBind();
        }

        private void LoadUsers()
        {
            AdminService service = new AdminService();
            gvUsers.DataSource = service.GetUtilisateurs();
            gvUsers.DataBind();
        }

        protected void btnAddGuide_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";

                GuideCategorie categorie = (GuideCategorie)Enum.Parse(
                    typeof(GuideCategorie),
                    ddlCategorie.SelectedValue
                );

                TypeUtilisateur typeUtilisateur = (TypeUtilisateur)Enum.Parse(
                    typeof(TypeUtilisateur),
                    ddlTypeUtilisateurGuide.SelectedValue
                );

                GuideService service = new GuideService();

                service.AjouterGuide(
                    txtTitre.Text,
                    txtDescription.Text,
                    categorie,
                    typeUtilisateur
                );

                txtTitre.Text = "";
                txtDescription.Text = "";

                LoadGuides();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        protected void gvGuides_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            gvGuides.SelectedIndex = index;

            int id = Convert.ToInt32(gvGuides.DataKeys[index].Value);

            GuideService service = new GuideService();

            if (e.CommandName == "DeleteGuide")
            {
                service.SupprimerGuide(id);
                LoadGuides();
            }
            else if (e.CommandName == "EditGuide")
            {
                Response.Redirect("PageEditGuide.aspx?id=" + id);
            }
        }

        protected void gvUsers_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            gvUsers.SelectedIndex = index;

            int id = Convert.ToInt32(gvUsers.DataKeys[index].Value);

            AdminService service = new AdminService();

            if (e.CommandName == "DeleteUser")
            {
                service.SupprimerUtilisateur(id);
                LoadUsers();
            }
        }

        protected void btnSearchUser_Click(object sender, EventArgs e)
        {
            string nom = txtSearchNom.Text;
            string type = ddlTypeUser.SelectedValue;

            if (type == "Tous")
                type = "";

            AdminService service = new AdminService();
            gvUsers.DataSource = service.GetUtilisateurs(nom, type);
            gvUsers.DataBind();
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("PageConnexion.aspx");
        }
    }
}