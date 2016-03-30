using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Networker
{
    public class mainPage : FriendObserver
    {
        public mainPage(ListBox displayBox, ISubject friendSubject) : base(displayBox, friendSubject) { }
    }
    public class friend1 : FriendObserver
    {
        public friend1(ListBox displayBox, ISubject friendSubject) : base(displayBox, friendSubject) { }
    }
    public class friend2 : FriendObserver
    {
        public friend2(ListBox displayBox, ISubject friendSubject) : base(displayBox, friendSubject) { }
    }
    public class friend3 : FriendObserver
    {
        public friend3(ListBox displayBox, ISubject friendSubject) : base(displayBox, friendSubject) { }
    }
    public class friend4 : FriendObserver
    {
        public friend4(ListBox displayBox, ISubject friendSubject) : base(displayBox, friendSubject) { }
    }
}
