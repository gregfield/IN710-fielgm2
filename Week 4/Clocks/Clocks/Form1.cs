using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clocks
{
    public partial class Form1 : Form
    {
        ClockController clock;

        public Form1()
        {
            InitializeComponent();

            digitalClockLabel.Hide();
            analogClock1.Hide();

            clock = new ClockController();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            clock.clockType.ClockOff();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(rbtnAnalog.Checked)
            {
                digitalClockLabel.Hide();
                clock.clockType = new AnalogClock(analogClock1);
                clock.startClock();
            }
            else if(rbtnDigital.Checked)
            {
                analogClock1.Hide();
                clock.clockType = new DigitalClock(digitalClockLabel);
                clock.startClock();
            }
        }
    }
}
