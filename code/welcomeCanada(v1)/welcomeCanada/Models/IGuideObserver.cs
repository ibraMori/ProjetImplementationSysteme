using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace welcomeCanada.Models
{
    public interface IGuideObserver
    {
        DataTable Update(DataTable guides);
    }
}
