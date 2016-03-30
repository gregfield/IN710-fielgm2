using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Networker
{
    public class PersonSubject : ISubject
    {
        private List<IObserver> friends;
        private string status;

        public PersonSubject()
        {
            friends = new List<IObserver>();
        }

        public void addObserver(IObserver obj)
        {
            friends.Add(obj);
        }

        public void removeObserver(IObserver obj)
        {
            friends.Remove(obj);
        }

        public void notifyObsevers()
        {
            foreach (IObserver currObserver in friends)
            {
                currObserver.update(status);
            }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
