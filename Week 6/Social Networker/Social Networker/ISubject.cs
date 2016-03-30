using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Networker
{
    public interface ISubject
    {
        void addObserver(IObserver obj);
        void removeObserver(IObserver obj);
        void notifyObsevers();
    }
}
