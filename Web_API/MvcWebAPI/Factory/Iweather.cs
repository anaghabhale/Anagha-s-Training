using MvcWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcWebAPI.Factory
{
   public interface Iweather
    {

       string getData(WeatherData _weatherData);
       
    }
}
