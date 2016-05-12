using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOMakeDatabase
{
    public partial class Form1 : Form
    {
        DBMaker dbMaker;

        public Form1()
        {
            InitializeComponent();
        }

        private void mkDbBtn_Click(object sender, EventArgs e)
        {
            string passwd = passwdTxtBox.Text.ToString();
            dbMaker = new DBMaker(passwd);
            passwdTxtBox.Text = "";
            int rowsAffected = dbMaker.makeDb();

            MessageBox.Show("Database Created \n" + rowsAffected + " rows affected");
        }
    }
}
