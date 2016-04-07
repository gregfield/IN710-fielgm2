using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressIndicatorApplication
{
    public abstract class ProgressObserver
    {
        protected ProgressSubject subject;

        public ProgressObserver(ProgressSubject subject)
        {
            this.subject = subject;

            EventHandler handler = new EventHandler(UpdateProgress);

            subject.ProgressEvent += handler;


        }

        public abstract void UpdateProgress(object updateSubject, EventArgs pe);
    }
}
