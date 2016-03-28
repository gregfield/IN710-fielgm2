using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherMonitoring
{
    public partial class Form1 : Form
    {
        WeatherMonitoringSubject weatherSubject;

        public Form1()
        {
            InitializeComponent();

            weatherSubject = new WeatherMonitoringSubject();
            new currentValuesObserver(currListBox,weatherSubject);
            new AverageObserver(averageListBox, weatherSubject);
            new ForecastObserver(forecastListBox, weatherSubject);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            double temp = 0;
            double humidity = 0;
            double pressure = 0;

            try
            {
                temp = double.Parse(tempTxtBox.Text.ToString());
                humidity = double.Parse(humidityTxtBox.Text.ToString());
                pressure = double.Parse(baroTxtBox.Text.ToString());

                if ((temp < -100) || (temp > 65))
                {
                    MessageBox.Show("Please enter a valid Temperature");
                }
                else
                {
                    if ((humidity < 0) || (humidity > 100))
                    {
                        MessageBox.Show("Please enter a correct Humidity");
                    }
                    else
                    {
                        weatherSubject.Currtemp = temp;
                        weatherSubject.Currhumidity = humidity;
                        weatherSubject.CurrbaroPressure = pressure;
                        weatherSubject.notifyObservers();
                    }
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Please enter measurements");
            }
            catch(OverflowException)
            {
                MessageBox.Show("Please check measurements entered");
            }

            tempTxtBox.Clear();
            humidityTxtBox.Clear();
            baroTxtBox.Clear();
        }
    }
}
