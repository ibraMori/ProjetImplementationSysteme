using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace welcomeCanada.Services
{
    public interface IHomeView
    {
        void AfficherMessage(string message);
        void AfficherBoutonGuides(bool visible);
        void AfficherGuides(DataTable guides);
        void CacherGuides();
        void RedirigerApresDelai(string url, int millisecondes);
        void DeconnecterSession();
    }
}
