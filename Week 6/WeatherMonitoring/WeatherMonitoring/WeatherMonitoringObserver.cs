using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherMonitoring
{
    public abstract class WeatherMonitoringObserver : IWeatherObserver
    {
        protected ListBox displayListBox;
        protected double currtemp;
        protected double currhumidity;
        protected double currbaroPressure;
        protected double currcomputedtemp;
        protected double currcomputedhumidity;
        protected double currcomputedbaroPressure;

        public WeatherMonitoringObserver(ListBox displayListBox, IWeatherSubject weatherSubject)
        {
            this.displayListBox = displayListBox;

            currtemp = 0;
            currhumidity = 0;
            currbaroPressure = 0;
            currcomputedtemp = 0;
            currcomputedhumidity = 0;
            currcomputedbaroPressure = 0;

            weatherSubject.addWeatherObserver(this);
        }

        public abstract void update(double currTemp, double currHumidity, double currBaroPressure);

        public virtual void display()
        {
            displayListBox.Items.Clear();
            displayListBox.Items.Add("Temperature: \t" + currcomputedtemp.ToString("F2"));
            displayListBox.Items.Add("Humidity: \t" + currcomputedhumidity.ToString("F2"));
            displayListBox.Items.Add("Pressure: \t" + currcomputedbaroPressure.ToString("F2"));
        }
    }
}
