using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using welcomeCanada.Models;
namespace welcomeCanada.Services
{
    public class LogoutState : IState
    {
        public void AfficherBienvenue(HomeContext context)
        {
            context.SetState(new BienvenueState());
            context.ContextBienvenue();
        }

        public void AfficherGuides(HomeContext context)
        {
            // Rien à faire pendant la déconnexion
        }

        public void Logout(HomeContext context)
        {
            context.View.AfficherMessage("Déconnexion en cours...");
            context.View.CacherGuides();
            context.View.AfficherBoutonGuides(false);

            context.View.DeconnecterSession();
            context.View.RedirigerApresDelai("PageConnexion.aspx", 2000);
        }
    }
}