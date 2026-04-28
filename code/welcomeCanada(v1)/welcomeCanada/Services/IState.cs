using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using welcomeCanada.Models;
namespace welcomeCanada.Services
{
    public interface IState
    {
        void AfficherBienvenue(HomeContext context);
        void AfficherGuides(HomeContext context);
        void Logout(HomeContext context);
    }
}
