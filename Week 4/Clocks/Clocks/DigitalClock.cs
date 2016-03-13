using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clocks
{
    public class DigitalClock:IClock
    {
        Label Clock;

        public DigitalClock(Label clock)
        {
            Clock = clock;
        }

        public void ClockOn()
        {
            Clock.Show();
            Clock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void ClockOff()
        {
            Clock.Hide();
        }
    }
}
