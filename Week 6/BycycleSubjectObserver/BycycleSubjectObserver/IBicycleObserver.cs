using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BycycleSubjectObserver
{
    public interface IBicycleObserver
    {
        void Update(int data);
        void Display();
    }
}
