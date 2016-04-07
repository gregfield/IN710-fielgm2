using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarm
{
    public partial class Form1 : Form
    {
        FireAlarmSubject fireSubject;
        public Form1()
        {
            InitializeComponent();
            fireSubject = new FireAlarmSubject();
            new InstructionsObserver(fireSubject);
            new AlarmObserver(fireSubject);
        }

        private void fireAlarmBtn_Click(object sender, EventArgs e)
        {
            if (minorFireRbtn.Checked)
                fireSubject.OnFireEvent(EFireCategory.MINOR);
            else if (seriousFireBtn.Checked)
                fireSubject.OnFireEvent(EFireCategory.SERIOUS);
            else if (infernoFireBtn.Checked)
                fireSubject.OnFireEvent(EFireCategory.INFERNO);
        }
    }
}
