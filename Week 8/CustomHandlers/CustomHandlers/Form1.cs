using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomHandlers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            new CustomHandler(testHandlersBtn, random.Next(100));
            new CustomHandler(testHandlersBtn, random.Next(100));
        }

        private void testHandlersBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the form's handler");
        }
    }
}
