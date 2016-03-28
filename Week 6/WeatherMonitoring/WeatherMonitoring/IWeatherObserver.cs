using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoring
{
    public interface IWeatherObserver
    {
        void update(int data0, int data1, int data2);
        void display();
    }
}
