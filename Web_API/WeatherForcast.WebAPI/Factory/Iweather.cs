using WeatherForcast.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherForcast.WebAPI.Factory
{
   public interface Iweather
    {

       string getData(WeatherData _weatherData);
       
    }
}
