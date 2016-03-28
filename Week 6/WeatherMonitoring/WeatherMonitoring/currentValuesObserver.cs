using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherMonitoring
{
    public class currentValuesObserver : WeatherMonitoringObserver
    {
        public currentValuesObserver(ListBox displayBox, WeatherMonitoringSubject subject) : base(displayBox,subject)
        {}

        public override void update(double currTemp, double currHumidity, double currBaroPressure)
        {
            currtemp = currTemp;
            currhumidity = currHumidity;
            currbaroPressure = currBaroPressure;
            currcomputedtemp = currtemp;
            currcomputedhumidity = currhumidity;
            currcomputedbaroPressure = currbaroPressure;

            display();
        }
    }
}
