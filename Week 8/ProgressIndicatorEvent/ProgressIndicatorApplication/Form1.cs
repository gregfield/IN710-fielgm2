using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressIndicatorApplication
{
    public partial class Form1 : Form
    {
        ProgressSubject slowWorker;

        public Form1()
        {
            InitializeComponent();

            slowWorker = new ProgressSubject();

            new ProgressBarObserver(slowWorker, progressBar1);
            new SpinBoxObserver(slowWorker, numericUpDown1);
            new TrackBarObserver(slowWorker, trackBar1);
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            numericUpDown1.Value = 0;
            trackBar1.Value = 0;

            slowWorker.SlowMethod();
        }
    }
}
