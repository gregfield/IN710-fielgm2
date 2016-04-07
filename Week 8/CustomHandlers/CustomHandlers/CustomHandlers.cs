using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomHandlers
{
    public class CustomHandler
    {
        Button button;
        int code;

        public CustomHandler(Button button, int code)
        {
            this.button = button;
            this.code = code;

            button.Click += new EventHandler(OnClickEvent);
        }
        public void OnClickEvent(object sender, EventArgs e)
        {
            String message = "";

            message += "This is a custom handler. \n";
            message += "My code number is " + code + ". \n";
            message += "My type is CustomHandlers.CustomHandler. \n";
            message += "I am responding to buttons: testHandlersBtn.";

            MessageBox.Show(message);
        }
    }
}
