using WeatherForcast.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherForcast.WebAPI.Factory
{
    public class clsWeatherFactory
    {
        static clsTimeMachine _clsTimeMachine;
        static clsForcast _clsForcast;
        public clsWeatherFactory()
        {

        }
        public clsWeatherFactory(clsTimeMachine tm, clsForcast fc)
        {
            _clsTimeMachine = tm;
            _clsForcast = fc;
        }
      
        static public Iweather getData(WeatherData weatherDataType)
        {
            
            Iweather _iweather;
            if (weatherDataType.WeatherType == "TM")
            {
                _iweather = _clsTimeMachine;
                
            }
            else if (weatherDataType.WeatherType == "FC")
            {
                _iweather = _clsForcast;
            }
            else
            {
                return null;
            }
            return _iweather;
        }
        
    }
}