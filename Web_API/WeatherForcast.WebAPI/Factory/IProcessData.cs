using WeatherForcast.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForcast.WebAPI.Factory
{
    public interface IProcessData
    {
        weatherDataResponse dataResponse(Newtonsoft.Json.Linq.JObject root);
    }
}
