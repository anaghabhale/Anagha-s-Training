using WeatherForcast.WebAPI.Models;
using WeatherForcast.WebAPI.ProcessUrl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace WeatherForcast.WebAPI.Factory
{
    public class clsForcast:Iweather
    {
        public string getData(WeatherData _weatherData)
        {
           
            string key = WebConfigurationManager.AppSettings["ApiUserName"];
            string strUrl = "https://api.darksky.net/forecast/" + key + "/"+_weatherData.Lat + "," + _weatherData.Log ;
            string response = null;
            try
            {
                MyWebRequest _myWebRequest = new MyWebRequest(strUrl);
                response = _myWebRequest.GetResponse();

            }
            catch (Exception err)
            {
                Console.Write(err.Message.ToString());
            }
            return response;
        }
    }
}