using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Networker
{
    public class FriendObserver :IObserver
    {
        protected string status;
        protected ISubject friendSubject;
        ListBox displayBox;

        public FriendObserver(ListBox displayBox, ISubject friendSubject)
        {
            status = "";
            this.friendSubject = friendSubject;
            this.displayBox = displayBox;
            friendSubject.addObserver(this);
        }

        public void update(string status)
        {
            this.status = status;
            display();
        }

        public void display()
        {
            displayBox.Items.Add(DateTime.Now.ToLongDateString() + " " + DateTime.Now.TimeOfDay.ToString("hh\\:mm"));
            displayBox.Items.Add(status);
        }
    }
}
