using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BycycleSubjectObserver
{
    public interface IBicycleSubject
    {
        void addObserver(IBicycleObserver obj);
        void removeObserver(IBicycleObserver obj);
        void notifyObservers();
    }
}
