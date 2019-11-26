using MvcWebAPI.Factory;
using MvcWebAPI.Models;
using MvcWebAPI.ProcessUrl;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ModelData;
namespace MvcWebAPI.Controllers
{
    public class ValuesController : ApiController
    {

        //GET api/values
        public void Get()
        {
            var xmlConverter = new XmlConverter();
            var adapter = new XmlToJsonAdapter(xmlConverter);
            adapter.ConvertXmlToJson();
            //Iweather _iWeather;
            //WeatherData _weatherData = new WeatherData();
            //_weatherData.Lat = 19.99;
            //_weatherData.Log = 73.78;
            //_weatherData.DT = DateTime.Now;
            //_weatherData.WeatherType = "TM";

            //_iWeather = clsWeatherFactory.getData(_weatherData);
            //var response = _iWeather.getData(_weatherData);
            //var root = JObject.Parse(response);
            //tblWeatherDataResponse _weatherdataResponse = clsProcessData.dataResponse(root);
            //return _weatherdataResponse;
        }

        // GET api/values/?lat=5.5&log=67.87
        public tblWeatherDataResponse Get(double lat, double log)
        {
            Iweather _iWeather;
            MvcWebAPI.Models.WeatherData _weatherData = new MvcWebAPI.Models.WeatherData();
            _weatherData.Lat = lat;//19.99;
            _weatherData.Log = log;// 73.78;
            _weatherData.DT = DateTime.Now;
            _weatherData.WeatherType = "TM";

            _iWeather = clsWeatherFactory.getData(_weatherData);
            var response = _iWeather.getData(_weatherData);
            var root = JObject.Parse(response);
            tblWeatherDataResponse _weatherdataResponse = clsProcessData.dataResponse(root);
            return _weatherdataResponse;
        }

        public tblWeatherDataResponse Get(string cityName)
        {
            
                 Iweather _iWeather;
            MvcWebAPI.Models.WeatherData _weatherData = MyWebRequest.GetCoordinates(cityName);
            //_weatherData.Lat = lat;//19.99;
            //_weatherData.Log = log;// 73.78;
            _weatherData.DT = DateTime.Now;
            _weatherData.WeatherType = "TM";

            _iWeather = clsWeatherFactory.getData(_weatherData);
            var response = _iWeather.getData(_weatherData);
            var root = JObject.Parse(response);
            tblWeatherDataResponse _weatherdataResponse = clsProcessData.dataResponse(root);
            return _weatherdataResponse;
        }

      //  POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}