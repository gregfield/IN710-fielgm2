using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public enum EFireCategory {MINOR, SERIOUS, INFERNO};
    public class FireAlarmEventArgs : EventArgs
    {
        public EFireCategory FireCategory { get; set; }

        public FireAlarmEventArgs(EFireCategory currentFireCategory)
        {
            FireCategory = currentFireCategory;
        }
    }
}
