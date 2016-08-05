using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fielgm2_WebNewsAggregator
{
    public partial class DisplayPage : Form
    {
        //the url for the web browser
        private string url;

        public DisplayPage()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //closes the page when the back button is clicked
            this.Close();
        }

        public string Url
        {
            set { url = value; }
        }

        private void DisplayPage_Load(object sender, EventArgs e)
        {
            //displays the url 
            webBrowser1.Navigate(url);
        }
    }
}
