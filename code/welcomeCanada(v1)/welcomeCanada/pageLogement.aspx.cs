using System;
using System.Data;
using welcomeCanada.Services;

namespace welcomeCanada
{
    public partial class PageLogement : System.Web.UI.Page
    {
        FindHousingService service = new FindHousingService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ChargerTous();
            }
        }

        private void ChargerTous()
        {
            GridViewLogements.DataSource = service.GetAllLogements();
            GridViewLogements.DataBind();
        }

        protected void btnFiltrer_Click(object sender, EventArgs e)
        {
            string ville = txtVille.Text;

            decimal? prixMax = null;
            int? dimensionMin = null;

            if (!string.IsNullOrEmpty(txtPrixMax.Text))
            {
                if (decimal.TryParse(txtPrixMax.Text, out decimal prix))
                    prixMax = prix;
                else
                {
                    lblMessage.Text = "Prix invalide";
                    return;
                }
            }

            if (!string.IsNullOrEmpty(txtDimensionMin.Text))
            {
                if (int.TryParse(txtDimensionMin.Text, out int dim))
                    dimensionMin = dim;
                else
                {
                    lblMessage.Text = "Dimension invalide";
                    return;
                }
            }

            DataTable data = service.GetLogements(ville, prixMax, dimensionMin);

            lblMessage.Text = data.Rows.Count == 0 ? "Aucun résultat" : "";

            GridViewLogements.DataSource = data;
            GridViewLogements.DataBind();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtVille.Text = "";
            txtPrixMax.Text = "";
            txtDimensionMin.Text = "";

            lblMessage.Text = "";

            ChargerTous();
        }
    }
}