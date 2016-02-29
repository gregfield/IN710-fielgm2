/*
 * Author: Greg Field
 * Application: Movie Database
 * Description: Allows the user to add, delete, and search
 * for the best movie in a given year.
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

namespace BestMovieDatabase
{
    public partial class Form1 : Form
    {
        MovieDictionary movieDictionary;

        public Form1()
        {
            InitializeComponent();
            movieDictionary = new MovieDictionary();
        }

        private void movieAddBtn_Click(object sender, EventArgs e)
        {
            //adds a movie
            //if what is entered in the year field is not either a number
            //or if it is to high or to low it will show an error message
            try
            {
                int year = Convert.ToInt16(yearAdd.Text);
                string title = titleAdd.Text.ToString();
                string director = directorAdd.Text.ToString();

                movieDictionary.addMovie(year, title, director);

                yearAdd.Clear();
                titleAdd.Clear();
                directorAdd.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Year");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void movieDeleteBtn_Click(object sender, EventArgs e)
        {
            //deletes a movie
            //if what is entered in the year field is not either a number
            //or if it is to high or to low it will show an error message
            try
            {
                movieDictionary.deleteMovie(Convert.ToInt16(yearDelete.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Year");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }

            yearDelete.Clear();
        }

        private void movieSearchBtn_Click(object sender, EventArgs e)
        {
            //searches for movie
            //if what is entered in the year field is not either a number
            //or if it is to high or to low it will show an error message
            try
            {
                int year = Convert.ToInt16(yearSearch.Text);
                movieDictionary.searchMovie(year, yearSearch);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please Enter a Year");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //prints all to screen
        private void printAllBtn_Click(object sender, EventArgs e)
        {
            displayAllBox.Items.Clear();
            movieDictionary.printAllToScreen(displayAllBox);
        }
    }
}
