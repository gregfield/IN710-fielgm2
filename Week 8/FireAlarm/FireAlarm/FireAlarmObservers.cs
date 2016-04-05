using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public abstract class FireAlarmObservers
    {
        protected FireAlarmSubject fireSubject;

        public FireAlarmObservers(FireAlarmSubject subject)
        {
            fireSubject = subject;

            FireAlarmEventHandler handler = new FireAlarmEventHandler(FireAlarmHandlerMethod);

            subject.FireEvent += handler;
        }

        public abstract void FireAlarmHandlerMethod(object fireSubject, FireAlarmEventArgs fe);
    }
}
