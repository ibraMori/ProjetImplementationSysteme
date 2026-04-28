using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using welcomeCanada.Models;
namespace welcomeCanada.Services
{
    public class HomeContext
    {
        private IState state;

        public IHomeView View { get; private set; }

        public HomeContext(IHomeView view)
        {
            View = view;
            state = new BienvenueState();
        }

        public void SetState(IState newState)
        {
            state = newState;
        }

        public void ContextBienvenue()
        {
            state.AfficherBienvenue(this);
        }

        public void ContextGuides()
        {
            state.AfficherGuides(this);
        }

        public void ContextLogout()
        {
            state.Logout(this);
        }
    }
}