using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestMovieDatabase
{
    class MovieDictionary
    {

        SortedDictionary<int, Movie> movieTable;

        public MovieDictionary()
        {
            //creating dictionary and adding some initial data to it
            movieTable = new SortedDictionary<int, Movie>();

            Movie movie1 = new Movie(2016, "Spotlight", "Tom McCarthy");
            Movie movie2 = new Movie(2015, "Birdman", " Alejandro González Iñárritu");
            Movie movie3 = new Movie(2014, "12 Years A Slave", "Steve McQuenn");
            Movie movie4 = new Movie(2013, "Argo", "Ben Affleck");
            Movie movie5 = new Movie(2012, "The Artist", "Michel Hazanavicius");

            movieTable.Add(movie1.Year, movie1);
            movieTable.Add(movie2.Year, movie2);
            movieTable.Add(movie3.Year, movie3);
            movieTable.Add(movie4.Year, movie4);
            movieTable.Add(movie5.Year, movie5);
        }

        //adds a movie to the dictionary
        public void addMovie(int year, string title, string director)
        {
                //if the year is either to high or too small it will show an error message
                if ((year < 2020) && (year > 1900))
                {
                    //if there is no title it will show an error message
                    if (title != "")
                    {
                        //if there is no director it will show an error message
                        if (director != "")
                        {
                            Movie movie = new Movie(year, title, director);
                            movieTable.Add(movie.Year, movie);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a Director");
                        } 
                    }
                    else
                    {
                        MessageBox.Show("Please enter a Title");
                    }                    
                }
                else
                {
                    MessageBox.Show("That is not a valid Year");
                }
        }

        //deletes a movie based on the year
        public void deleteMovie(int year)
        {
            //Checks if there is a movie from that year
            if (movieTable.ContainsKey(year))
            {
                movieTable.Remove(year);
            }
            else
            {
                MessageBox.Show("The Year " + year + " was not found!");
            }
        }

        //searches for a movie based on the year
        public void searchMovie(int year, TextBox displayText)
        {
            //Checks if there is a movie from that year
            if (movieTable.ContainsKey(year))
            {
                Movie selectedMovie = movieTable[year];
                displayText.Text = selectedMovie.ToString();
            }
            else
            {
                MessageBox.Show("The Year " + year + " was not found!");
            }
        }

        //Prints all the movies to the screen
        public void printAllToScreen(ListBox printAllBox)
        {
            foreach (KeyValuePair<int, Movie> currentMovie in movieTable)
            {
                printAllBox.Items.Add("--------------------------------");
                printAllBox.Items.Add(currentMovie.Value.ToString());
            }
        }
    }
}
