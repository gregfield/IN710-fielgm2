/*Author: Greg Field
 *Description: Shows users links for web pages or news articles
 *based on likes and dislikes they have entered
 * 
 * Bugs:Not finding users already in the database
 *      Not Displaying Web Pages as json conversion
 *      is not completed
 *      
*/

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
    public partial class LoginForm : Form
    {
        //to access the database
        DatabaseWorker dbWorker;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //gets the username and password then calls method to check it against the database
            string username = usrnameTxtBox.Text.ToString();
            string password = passwdTxtBox.Text.ToString();

            int userID = dbWorker.checkForUserToLogin(username, password);

            //db worker will return -1 if user is not in the db
            if (userID != -1)
            {
                SelectLinkPage selectPage = new SelectLinkPage();
                selectPage.UsrID = userID;
                selectPage.Show();
                this.Hide();
                selectPage.FormClosing += selectPage_FormClosing;
                usrnameTxtBox.Clear();
                passwdTxtBox.Clear();
            }
            else 
            {
                MessageBox.Show("Username or Password invalid");
            }
        }

        //adds a new user to the database when create button is clicked
        private void createUsrBtn_Click(object sender, EventArgs e)
        {
            string passwd1 = newPasswdTxtBox.Text.ToString();
            string confirmPsswd = confirmPsswdTxtBox.Text.ToString();

            //check if the passwords match
            if (passwd1.Equals(confirmPsswd))
            {
                //make new user
                
                string username = nuewUsrTxtbox.Text.ToString();
                if (username != null)
                {
                    dbWorker.addUserToDb(username, passwd1);
                    MessageBox.Show("User created. Please Logon");
                    newPasswdTxtBox.Clear();
                    confirmPsswdTxtBox.Clear();
                    nuewUsrTxtbox.Clear();
                }
                else
                {
                    //if the passwords dont match
                    MessageBox.Show("Please enter a username");
                }
            }
            else
            {
                //if passwords dont match inform user then remove text in password text boxes
                MessageBox.Show("Passwords do not match");
                newPasswdTxtBox.Clear();
                confirmPsswdTxtBox.Clear();
            }
        }

        //initialises the db worker when the form loads
        private void LoginForm_Load(object sender, EventArgs e)
        {
            dbWorker = new DatabaseWorker();
        }

        //when the link page form is closed shows login form again
        private void selectPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
