using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Networker
{
    public interface IObserver
    {
        void update(string status);
        void display();
    }
}
