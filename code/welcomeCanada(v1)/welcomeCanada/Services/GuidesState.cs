using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using welcomeCanada.Models;
using System.Data;
namespace welcomeCanada.Services
{
    public class GuidesState : IState
    {
        private TypeUtilisateur typeUtilisateur;

        public GuidesState()
        {
        }

        public GuidesState(TypeUtilisateur typeUtilisateur)
        {
            this.typeUtilisateur = typeUtilisateur;
        }

        public void AfficherBienvenue(HomeContext context)
        {
            context.SetState(new BienvenueState());
            context.ContextBienvenue();
        }

        public void AfficherGuides(HomeContext context)
        {
            context.View.AfficherMessage("Voici les guides disponibles pour votre profil");
            context.View.AfficherBoutonGuides(false);

            GuideSubject subject = new GuideSubject();

            if (typeUtilisateur == TypeUtilisateur.Etudiant)
                subject.Register(new EtudiantGuideObserver());
            else if (typeUtilisateur == TypeUtilisateur.Travailleur)
                subject.Register(new TravailleurGuideObserver());

            GuideService service = new GuideService();
            DataTable guides = service.GetAllGuidesForObserver();

            DataTable guidesFiltres = subject.Notify(guides);

            context.View.AfficherGuides(guidesFiltres);
        }

        public void Logout(HomeContext context)
        {
            context.SetState(new LogoutState());
            context.ContextLogout();
        }
    }
}