using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressIndicatorApplication
{
    public class ProgressBarObserver : ProgressObserver
    {
        ProgressBar progressBar;

        public ProgressBarObserver(ProgressSubject subject, ProgressBar inputProgressBar)
            : base(subject)
        {
            progressBar = inputProgressBar;
        }

        public override void UpdateProgress(object o, EventArgs e)
        {
            progressBar.PerformStep();
        }
    }

    public class SpinBoxObserver : ProgressObserver
    {
        NumericUpDown spinBox;

        public SpinBoxObserver(ProgressSubject subject, NumericUpDown inputSpinBox)
            : base(subject)
        {
            spinBox = inputSpinBox;
        }

        public override void UpdateProgress(object o, EventArgs e)
        {
            spinBox.Value++;
            spinBox.Refresh();
        }
    }

    public class TrackBarObserver : ProgressObserver
    {
        TrackBar trackBar;

        public TrackBarObserver(ProgressSubject subject, TrackBar inputTrackBar)
            : base(subject)
        {
            trackBar = inputTrackBar;
        }

        public override void UpdateProgress(object o, EventArgs e)
        {
            trackBar.Value++;
        }
    }
}
