using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using welcomeCanada.Models;

namespace welcomeCanada.Services
{
    public class BienvenueState : IState
    {
        public void AfficherBienvenue(HomeContext context)
        {
            context.View.AfficherMessage("Bienvenue sur Welcome Canada");
            context.View.CacherGuides();
            context.View.AfficherBoutonGuides(true);
        }

        public void AfficherGuides(HomeContext context)
        {
            context.SetState(new GuidesState());
            context.ContextGuides();
        }

        public void Logout(HomeContext context)
        {
            context.SetState(new LogoutState());
            context.ContextLogout();
        }
    }
}