using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestMovieDatabase
{
    class Movie
    {
        public int Year { get; set; }
        public String Title { get; set; }
        public String Director { get; set; }

        public Movie(int year, string title, string director)
        {
            Year = year;
            Title = title;
            Director = director;
        }

        public override string ToString()
        {
            return "Year: " + Year.ToString() + " Title: " + Title.ToString() + " Director: " + Director.ToString();
        }
    }
}
