using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;

namespace welcomeCanada.Models
{
    public class GuideSubject
    {
        private readonly List<IGuideObserver> observers = new List<IGuideObserver>();

        public void Register(IGuideObserver observer)
        {
            observers.Add(observer);
        }

        public void DeRegister(IGuideObserver observer)
        {
            observers.Remove(observer);
        }

        public DataTable Notify(DataTable guides)
        {
            DataTable result = new DataTable();

            foreach (IGuideObserver observer in observers)
            {
                result = observer.Update(guides);
            }

            return result;
        }
    }
}