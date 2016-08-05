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
    public partial class SelectLinkPage : Form
    {
        private AggregatorWorker agworker;
        private int usrID;

        public SelectLinkPage()
        {
            InitializeComponent();
        }

        private void CreateNewUserForm_Load(object sender, EventArgs e)
        {
            agworker = new AggregatorWorker(usrID);
        }

        //when the get news button is clicked 
        private void getNewsBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();    
        
            //gets what radio button is clicked
            if(newsRbtn.Checked)
            {
                //true is for news
                agworker.HTTPandJSON(true);

                fillDatagridView();
            }
            else if(weSitesRbtn.Checked)
            {
                //false is for web
                agworker.HTTPandJSON(false);

                fillDatagridView();
            }
            else
            {
                //if neither radio button is checked shows a message
                MessageBox.Show("Please select a news or website preference");
            }
        }

        //when a cell is clicked in the datagrid view it shows the display page the hides its self
        //then sets a method to be called when the display page is closed
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //opens the display page then
            DisplayPage displayPage = new DisplayPage();
            displayPage.Url = agworker.BingResults[e.RowIndex].url;
            displayPage.Show();
            this.Hide();
            displayPage.FormClosing += displayPage_FormClosing;
        }

        //show this page when the display page is closed
        private void displayPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            //closes this page when logout button is pressed
            this.Close();
        }

        //so the user id can be passed in
        public int UsrID
        {
            set { usrID = value; }
        }

        //calls the method to add a like when the add like button is clicked
        private void addLikeBtn_Click(object sender, EventArgs e)
        {
            string like = likeTxtBox.Text.ToString();
            agworker.addLikeToDb(like);
            likeTxtBox.Clear();
        }

        //calls the method to add a dislike when the add dislike button is clicked
        private void addDislikeBtn_Click(object sender, EventArgs e)
        {
            string disLike = dislikeTxtBox.Text.ToString();
            agworker.addDislikeToDb(disLike);
            dislikeTxtBox.Clear();
        }
          
         //displays the search results in the datagrid view
        private void fillDatagridView()
        {
            foreach (SearchResult search in agworker.BingResults)
            {
                string[] rows = new string[dataGridView1.ColumnCount];
                rows[0] = search.name;
                rows[1] = search.description;
                rows[2] = search.url;

                dataGridView1.Rows.Add(rows);
            }
        }
    }
}
