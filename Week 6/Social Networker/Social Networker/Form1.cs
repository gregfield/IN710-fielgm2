using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Networker
{
    public partial class Form1 : Form
    {
        PersonSubject friendSubject;

        public Form1()
        {
            InitializeComponent();

            friendSubject = new PersonSubject();
            new mainPage(mainPageListBox, friendSubject);
            new friend1(firend1ListBox, friendSubject);
            new friend2(friend2ListBox, friendSubject);
            new friend3(friend3ListBox, friendSubject);
            new friend4(friend4ListBox, friendSubject);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            friendSubject.Status = updateStatusTxtBox.Text.ToString();
            friendSubject.notifyObsevers();
            updateStatusTxtBox.Clear();
        }
    }
}
