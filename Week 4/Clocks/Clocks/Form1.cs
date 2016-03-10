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
        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void rbtnDigital_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnAnalog_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
