using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarm
{
    public class InstructionsObserver : FireAlarmObservers
    {
        public InstructionsObserver(FireAlarmSubject subject) : base(subject)
        { }

        public override void FireAlarmHandlerMethod(object fireSubject, FireAlarmEventArgs fe)
        {
            String message = "Fire is " + fe.FireCategory.ToString() + ". ";
            switch(fe.FireCategory)
            {
                case EFireCategory.MINOR:
                    message += "Use a fire extinguisher";
                    break;
                case EFireCategory.SERIOUS:
                    message += "Call the fire department";
                    break;
                case EFireCategory.INFERNO:
                    message += "Evacuate Immediately";
                    break;
            }
            MessageBox.Show(message);
        }
    }
}
