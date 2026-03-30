using System;
using welcomeCanada.Models;
using welcomeCanada.Services;

namespace welcomeCanada
{
    public partial class PageInscription : System.Web.UI.Page
    {
        AuthService auth = new AuthService();

        protected void BtnInscrire_Click(object sender, EventArgs e)
        {
            var result = auth.Inscrire(
                ddlTypeUtilisateur.SelectedValue == "Etudiant"
                ? TypeUtilisateur.Etudiant
                : TypeUtilisateur.Travailleur,
                txtNom.Text,
                txtPrenom.Text,
                txtEmail.Text,
                txtMotDePasse.Text
            );

            lblMessage.Text = result;
        }
    }
}