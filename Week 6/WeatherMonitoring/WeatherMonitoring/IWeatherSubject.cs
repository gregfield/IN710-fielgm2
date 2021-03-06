﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoring
{
    public interface IWeatherSubject
    {
        void addWeatherObserver(IWeatherObserver o);
        void removeWeatherObserver(IWeatherObserver o);
        void notifyObservers();
    }
}
