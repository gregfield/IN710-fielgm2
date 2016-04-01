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

    public delegate void FeedbackDelegate();

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateSpinBox()
        {
            numericUpDown1.Value++;
        }
        public void UpdateProgressBar()
        {
            progressBar1.PerformStep();
        }
        public void UpdateTrackBar()
        {
            trackBar1.Value++;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            FeedbackDelegate feedBackDelegate = null;

            numericUpDown1.Value = 0;
            progressBar1.Value = 0;
            trackBar1.Value = 0;

            if (spinBoxRbtn.Checked)
                feedBackDelegate = new FeedbackDelegate(UpdateSpinBox);
            else if (progBarRbtn.Checked)
                feedBackDelegate = new FeedbackDelegate(UpdateProgressBar);
            else if (trackBarRbtn.Checked)
                feedBackDelegate = new FeedbackDelegate(UpdateTrackBar);
            try
            {
                SlowMethod(feedBackDelegate);
            }
            catch(NullReferenceException)
            {

            }
        }

        private void SlowMethod(FeedbackDelegate progDelegate)
        {
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(500);
                progDelegate();
                //needed to get the spinBox to work
                Application.DoEvents();
            }
        }
    }
}
