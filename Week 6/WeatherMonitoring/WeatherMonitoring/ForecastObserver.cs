using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherMonitoring
{
    public class ForecastObserver : WeatherMonitoringObserver
    {
        private string forecast;
        public ForecastObserver(ListBox displayBox, WeatherMonitoringSubject subject) : base(displayBox,subject)
        {}

        public override void update(double currTemp, double currHumidity, double currBaroPressure)
        {
            if(currHumidity < 80)
            {
                forecast = "No Rain";
            }
            else
            {
                forecast = "Rain";
            }

            display();
        }

        public override void display()
        {
            displayListBox.Items.Clear();
            displayListBox.Items.Add(forecast);
        }
    }
}
