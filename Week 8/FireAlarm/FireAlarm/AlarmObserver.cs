using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public class AlarmObserver : FireAlarmObservers
    {
        public AlarmObserver(FireAlarmSubject subject) : base(subject)
        { }

        public override void FireAlarmHandlerMethod(object fireSubject, FireAlarmEventArgs fe)
        {
            switch(fe.FireCategory)
            {
                case EFireCategory.MINOR:
                    Beep(800, 1000);
                    break;
                case EFireCategory.SERIOUS:
                    Beep(2000, 1000);
                    break;
                case EFireCategory.INFERNO:
                    Beep(4000, 1000);
                    break;
            }
        }
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int freq, int duration);
    }
}
