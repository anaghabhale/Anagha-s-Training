using MvcWebAPI.Models;
using MvcWebAPI.ProcessUrl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;

namespace MvcWebAPI.Factory
{
    public class clsTimeMachine : Iweather
    {

        //
        public string getData(WeatherData _weatherData)
        {
            long dt = MyWebRequest.ConvertToUnixTime(_weatherData.DT);
            string key = WebConfigurationManager.AppSettings["ApiUserName"];
            string strUrl = "https://api.darksky.net/forecast/" + key + "/" + _weatherData.Lat + "," + _weatherData.Log + "," + dt;
            string response = null;
            try
            {
                MyWebRequest _myWebRequest = new MyWebRequest(strUrl);
                response = _myWebRequest.GetResponse();

               
            }
            catch (Exception err)
            { }
            return response;
        }
    }
}