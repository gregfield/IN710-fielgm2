using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoring
{
    public interface IWeatherObserver
    {
        void update(int currTemp, int currHumidity, int currBaroPressure);
        void display();
    }
}
