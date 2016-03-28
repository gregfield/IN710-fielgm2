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
        public ForecastObserver(ListBox displayBox, WeatherMonitoringSubject subject) : base(displayBox,subject)
        {}

        public override void update(int currTemp, int currHumidity, int currBaroPressure)
        {
            throw new NotImplementedException();
        }
    }
}
