using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOMakeReports
{
    public partial class Form1 : Form
    {
        DBManager dbManager;
        public Form1()
        {
            InitializeComponent();
            dbManager = new DBManager(dataGridView1);
        }

        private void papersTutorsBtn_Click(object sender, EventArgs e)
        {
            dbManager.listPapersAndTutors();
        }

        private void assignments2WeeksBtn_Click(object sender, EventArgs e)
        {
            dbManager.papersDueIn2Weeks();
        }

        private void avgMarkBtn_Click(object sender, EventArgs e)
        {
            dbManager.averageGrade();
        }
    }
}
