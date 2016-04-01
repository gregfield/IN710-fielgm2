using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizNightScorer
{
    public delegate int ScoreDelegate(int ocrrect, int incorrect);
    public partial class Form1 : Form
    {
        ScoreDelegate scoreComputer;
        public Form1()
        {
            InitializeComponent();
        }

        private void displayScoresBtn_Click(object sender, EventArgs e)
        {
            if (adultsRbtn.Checked)
                scoreComputer = new ScoreDelegate(Scorers.Adults);
            if (kidsRbtn.Checked)
                scoreComputer = new ScoreDelegate(Scorers.Children);

            string score = scoreComputer(Convert.ToInt32(correctTxtBox.Text.ToString()), Convert.ToInt32(incorrectTxtBox.Text.ToString())).ToString();

            scoreLbl.Text = "Score = " + score;
        }
    }
}
