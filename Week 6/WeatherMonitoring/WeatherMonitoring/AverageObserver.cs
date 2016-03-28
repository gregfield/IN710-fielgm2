using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherMonitoring
{
    public class AverageObserver : WeatherMonitoringObserver
    {
        private double temptotal;
        private double humiditytotal;
        private double pressuretotal;
        private double numberOfReadings;

        public AverageObserver(ListBox displayBox, WeatherMonitoringSubject subject) : base(displayBox,subject)
        {
            temptotal = 0;
            humiditytotal = 0;
            pressuretotal = 0;
            numberOfReadings = 0;
        }

        public override void update(double currTemp, double currHumidity, double currBaroPressure)
        {
            numberOfReadings++;

            currtemp = currTemp;
            currhumidity = currHumidity;
            currbaroPressure = currBaroPressure;

            currcomputedtemp = (temptotal += currtemp) / numberOfReadings;
            currcomputedhumidity = (humiditytotal += currHumidity) / numberOfReadings;
            currcomputedbaroPressure = (pressuretotal += currbaroPressure) / numberOfReadings;

            display();
        }
    }
}
