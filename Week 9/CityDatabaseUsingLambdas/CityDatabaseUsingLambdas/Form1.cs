using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityDatabaseUsingLambdas
{
    public partial class Form1 : Form
    {
        Func<string, string, bool> findCities = (x,y) => x.Equals(y);
        List<City> cities;
        public Form1()
        {
            InitializeComponent();
            cities = new List<City>();
            populateList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedCountry = textBox1.Text.ToString();
            List<City> foundCities = new List<City>();
            foreach(City city in cities)
            {
                if (findCities(selectedCountry, city.CountryName))
                {
                    foundCities.Add(city);
                }
            }

            listBox1.Items.Clear();
            foreach(City city in foundCities)
            {
                listBox1.Items.Add(String.Format("{0, -15} {1,-15} {2, -15}", city.CityName, city.CountryName, city.Population));
            }
        }

        private void populateList()
        {
            cities.Add(new City("Amsterdam", "Netherlands", 780000));
            cities.Add(new City("Berlin", "Germany", 3600000));
            cities.Add(new City("Cairo", "Egypt", 7800000));
            cities.Add(new City("Dunedin", "New Zealand", 128000));
            cities.Add(new City("Christchurch", "New Zealand", 228000));
            cities.Add(new City("Wellington", "New Zealand", 300000));
            cities.Add(new City("Florence", "Italy", 362000));
            cities.Add(new City("Rome", "Italy", 27000000));
            cities.Add(new City("Venice", "Italy", 260000));
        }
    }
}
