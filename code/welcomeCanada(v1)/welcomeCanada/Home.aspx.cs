using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;
using welcomeCanada.Models;
using welcomeCanada.Services;

namespace welcomeCanada
{
    public partial class Home : System.Web.UI.Page, IHomeView
    {
        private List<int> GuidesVus
        {
            get
            {
                if (Session["GuidesVus"] == null)
                    Session["GuidesVus"] = new List<int>();

                return (List<int>)Session["GuidesVus"];
            }
        }

        private DataTable GuidesData
        {
            get { return ViewState["GuidesData"] as DataTable; }
            set { ViewState["GuidesData"] = value; }
        }

        private int GuideActuelId
        {
            get { return (int)(ViewState["GuideActuelId"] ?? 0); }
            set { ViewState["GuideActuelId"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TypeUtilisateur"] == null)
            {
                Response.Redirect("PageConnexion.aspx");
                return;
            }

            AfficherInfosUtilisateur();

            if (!IsPostBack)
            {
                HomeController controller = new HomeController(this);
                controller.Bienvenue();
                MettreAJourProgression(0);
            }
        }

        private void AfficherInfosUtilisateur()
        {
            string nom = Session["Nom"] != null ? Session["Nom"].ToString() : "";
            string prenom = Session["Prenom"] != null ? Session["Prenom"].ToString() : "";

            lblNomPrenom.Text = prenom + " " + nom;
        }

        protected void btnViewGuides_Click(object sender, EventArgs e)
        {
            TypeUtilisateur typeUtilisateur = (TypeUtilisateur)Session["TypeUtilisateur"];

            HomeController controller = new HomeController(this);
            controller.Guides(typeUtilisateur);
        }

        protected void ddlCategorieGuide_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherGuideParCategorie(ddlCategorieGuide.SelectedValue);
        }

        protected void btnConfirmerGuides_Click(object sender, EventArgs e)
        {
            if (chkGuideVu.Checked && GuideActuelId != 0)
            {
                if (!GuidesVus.Contains(GuideActuelId))
                    GuidesVus.Add(GuideActuelId);
            }

            if (!chkGuideVu.Checked && GuideActuelId != 0)
            {
                if (GuidesVus.Contains(GuideActuelId))
                    GuidesVus.Remove(GuideActuelId);
            }

            if (GuidesData != null)
                MettreAJourProgression(GuidesData.Rows.Count);
        }

        protected void BtnLogement_Click(object sender, EventArgs e)
        {
            Response.Redirect("PageLogement.aspx");
        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            HomeController controller = new HomeController(this);
            controller.Logout();
        }

        public void AfficherMessage(string message)
        {
            lblBienvenue.Text = message;
        }

        public void AfficherBoutonGuides(bool visible)
        {
            btnViewGuides.Visible = visible;
        }

        public void AfficherGuides(DataTable guides)
        {
            GuidesData = guides;

            pnlGuides.Visible = true;
            btnConfirmerGuides.Visible = true;

            ddlCategorieGuide.Items.Clear();

            foreach (DataRow row in guides.Rows)
            {
                string categorie = row["Categorie"].ToString();

                if (ddlCategorieGuide.Items.FindByText(categorie) == null)
                {
                    ddlCategorieGuide.Items.Add(categorie);
                }
            }

            if (ddlCategorieGuide.Items.Count > 0)
            {
                ddlCategorieGuide.SelectedIndex = 0;
                AfficherGuideParCategorie(ddlCategorieGuide.SelectedValue);
            }
            else
            {
                lblTitreGuide.Text = "Aucun guide disponible";
                lblDescriptionGuide.Text = "";
                chkGuideVu.Checked = false;
            }

            MettreAJourProgression(guides.Rows.Count);
        }

        private void AfficherGuideParCategorie(string categorie)
        {
            if (GuidesData == null)
                return;

            string categorieSafe = categorie.Replace("'", "''");

            DataRow[] rows = GuidesData.Select("Categorie = '" + categorieSafe + "'");

            if (rows.Length > 0)
            {
                DataRow row = rows[0];

                GuideActuelId = Convert.ToInt32(row["Id"]);

                lblTitreGuide.Text = row["Titre"].ToString();
                lblDescriptionGuide.Text = row["Description"].ToString();

                chkGuideVu.Checked = GuidesVus.Contains(GuideActuelId);
            }
            else
            {
                GuideActuelId = 0;
                lblTitreGuide.Text = "Aucun guide trouvé";
                lblDescriptionGuide.Text = "";
                chkGuideVu.Checked = false;
            }
        }

        public void CacherGuides()
        {
            pnlGuides.Visible = false;
            btnConfirmerGuides.Visible = false;
        }

        private void MettreAJourProgression(int totalGuides)
        {
            if (totalGuides == 0)
            {
                progressBar.Style["width"] = "0%";
                progressBar.InnerText = "0%";
                lblProgression.Text = "0 guide visionné";
                return;
            }

            int guidesVus = 0;

            foreach (DataRow row in GuidesData.Rows)
            {
                int id = Convert.ToInt32(row["Id"]);

                if (GuidesVus.Contains(id))
                    guidesVus++;
            }

            int pourcentage = (guidesVus * 100) / totalGuides;

            progressBar.Style["width"] = pourcentage + "%";
            progressBar.InnerText = pourcentage + "%";
            lblProgression.Text = guidesVus + " / " + totalGuides + " guides visionnés";
        }

        public void RedirigerApresDelai(string url, int millisecondes)
        {
            ClientScript.RegisterStartupScript(
                GetType(),
                "redirect",
                $"setTimeout(function(){{ window.location='{url}'; }}, {millisecondes});",
                true
            );
        }

        public void DeconnecterSession()
        {
            Session.Clear();
        }
    }

}