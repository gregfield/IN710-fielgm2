using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoring
{
    public class WeatherMonitoringSubject : IWeatherSubject
    {
        private List<IWeatherObserver> weatherObserverList;
        private double currtemp;
        private double currhumidity;
        private double currbaroPressure;

        public WeatherMonitoringSubject()
        {   
            weatherObserverList = new List<IWeatherObserver>();

            currtemp = 0;
            currhumidity = 0;
            currbaroPressure = 0;            
        }

        public void addWeatherObserver(IWeatherObserver o)
        {
            weatherObserverList.Add(o);
        }

        public void removeWeatherObserver(IWeatherObserver o)
        {
            weatherObserverList.Remove(o);
        }

        public void notifyObservers()
        {
            foreach (IWeatherObserver currObserver in weatherObserverList)
            {
                currObserver.update(currtemp,currhumidity,currbaroPressure);
            }
        }

        public double Currtemp
        {
            get { return currtemp; }
            set { currtemp = value; }
        }
        public double Currhumidity
        {
            get { return currhumidity; }
            set { currhumidity = value; }
        }
        public double CurrbaroPressure
        {
            get { return currbaroPressure; }
            set { currbaroPressure = value; }
        }
    }
}
