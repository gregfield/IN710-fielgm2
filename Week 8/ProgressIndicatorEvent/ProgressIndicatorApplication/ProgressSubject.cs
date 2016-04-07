using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProgressIndicatorApplication
{
    public class ProgressSubject
    {
        public event EventHandler ProgressEvent;

        public void SlowMethod()
        {
            for(int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                OnUpdateEvent();
            }
        }

        public void OnUpdateEvent()
        {
            EventArgs progress = new EventArgs();

            if (ProgressEvent != null)
                ProgressEvent(this, progress);
        }       
    }
}
