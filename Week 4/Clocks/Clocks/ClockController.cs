using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clocks
{
    public class ClockController
    {
        public IClock clockType { get; set; }

        public ClockController()
        {
        }

        public void startClock()
        {
            clockType.ClockOn();
        }

        public void stopClock()
        {
            clockType.ClockOff();
        }
    }
}
