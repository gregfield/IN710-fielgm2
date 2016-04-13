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
        Func<string, List<City>, List<City>> findCities = (selectedCountry, cities) => cities.FindAll(City => selectedCountry.Equals(City.CountryName));
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

            foundCities = findCities(selectedCountry, cities);

            listBox1.Items.Clear();
            foreach(City city in foundCities)
            {
                listBox1.Items.Add(String.Format("{0, -14}{1, -14}{2:n0}", city.CityName, city.CountryName, city.Population));
            }

            textBox1.Text = "";
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
            cities.Add(new City("Rome", "Italy", 2700000));
            cities.Add(new City("Venice", "Italy", 260000));
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            cities.ForEach(currentCity => currentCity.Population = currentCity.Population * 3);
            cities.ForEach(currentCity => listBox1.Items.Add(String.Format("{0, -14}{1, -14}{2:n0}", currentCity.CityName, currentCity.CountryName, currentCity.Population)));
        }
    }
}
