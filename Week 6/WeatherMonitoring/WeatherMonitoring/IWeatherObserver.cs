using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoring
{
    public interface IWeatherObserver
    {
        void update(double currTemp, double currHumidity, double currBaroPressure);
        void display();
    }
}
