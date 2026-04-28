using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using welcomeCanada.Models;
namespace welcomeCanada.Services
{
    public class HomeController
    {
        private HomeContext context;

        public HomeController(IHomeView view)
        {
            context = new HomeContext(view);
        }

        public void Bienvenue()
        {
            context.ContextBienvenue();
        }

        public void Guides(TypeUtilisateur typeUtilisateur)
        {
            context.SetState(new GuidesState(typeUtilisateur));
            context.ContextGuides();
        }

        public void Logout()
        {
            context.ContextLogout();
        }
    }
}