using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clocks
{
    public class AnalogClock:IClock
    {
        AnalogClockControl.AnalogClock Clock;

        public AnalogClock(AnalogClockControl.AnalogClock clock)
        {
            Clock = clock;
        }
        public void ClockOn()
        {
            Clock.Show();
            Clock.Start();
        }

        public void ClockOff()
        {
            Clock.Stop();
            Clock.Hide();
        }
    }
}
