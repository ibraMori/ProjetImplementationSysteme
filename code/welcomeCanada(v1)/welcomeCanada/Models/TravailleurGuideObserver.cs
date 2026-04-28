using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace welcomeCanada.Models
{
    public class TravailleurGuideObserver : IGuideObserver
    {
        public DataTable Update(DataTable guides)
        {
            DataView view = guides.DefaultView;
            view.RowFilter = "TypeUtilisateur = 'Travailleur'";
            return view.ToTable();
        }
    }
}