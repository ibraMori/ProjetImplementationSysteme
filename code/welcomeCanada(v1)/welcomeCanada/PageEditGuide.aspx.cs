using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using welcomeCanada.Models;
using welcomeCanada.Services;
namespace welcomeCanada
{
    public partial class PageEditGuide : System.Web.UI.Page
    {
        private int GuideId
        {
            get { return (int)(ViewState["GuideId"] ?? 0); }
            set { ViewState["GuideId"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCategorie.DataSource = Enum.GetNames(typeof(GuideCategorie));
                ddlCategorie.DataBind();

                ddlTypeUtilisateur.DataSource = Enum.GetNames(typeof(TypeUtilisateur));
                ddlTypeUtilisateur.DataBind();

                if (Request.QueryString["id"] != null)
                {
                    GuideId = Convert.ToInt32(Request.QueryString["id"]);
                    LoadGuide();
                }
                else
                {
                    Response.Redirect("PageAdmin.aspx");
                }
            }
        }

        private void LoadGuide()
        {
            GuideService service = new GuideService();
            var row = service.GetGuideById(GuideId);

            if (row != null)
            {
                txtTitre.Text = row["Titre"].ToString();
                txtDescription.Text = row["Description"].ToString();
                ddlCategorie.SelectedValue = row["Categorie"].ToString();
                ddlTypeUtilisateur.SelectedValue = row["TypeUtilisateur"].ToString();
            }
            else
            {
                Response.Redirect("PageAdmin.aspx");
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";
                lblMessage.Text = "";

                GuideCategorie categorie = (GuideCategorie)Enum.Parse(
                    typeof(GuideCategorie),
                    ddlCategorie.SelectedValue
                );

                TypeUtilisateur typeUtilisateur = (TypeUtilisateur)Enum.Parse(
                    typeof(TypeUtilisateur),
                    ddlTypeUtilisateur.SelectedValue
                );

                GuideService service = new GuideService();

                service.ModifierGuide(
                    GuideId,
                    txtTitre.Text,
                    txtDescription.Text,
                    categorie,
                    typeUtilisateur
                );

                lblMessage.Text = "Guide modifié avec succès";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        protected void btnRetour_Click(object sender, EventArgs e)
        {
            Response.Redirect("PageAdmin.aspx");
        }
    }
}