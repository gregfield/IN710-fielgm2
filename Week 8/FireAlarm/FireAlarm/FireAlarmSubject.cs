using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public delegate void FireAlarmEventHandler(object fireSubject, FireAlarmEventArgs fe);

    public class FireAlarmSubject
    {
        public event FireAlarmEventHandler FireEvent;

        public void OnFireEvent(EFireCategory category)
        {
            FireAlarmEventArgs fe = new FireAlarmEventArgs(category);

            if (FireEvent != null)
                FireEvent(this, fe);
        }
    }
}
