
using ModelData;
using WeatherForcast.WebAPI.Factory;
using WeatherForcast.WebAPI.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WeatherForcast.WebAPI.ProcessUrl
{
    public class XmlConverter
    {
        public XDocument GetXML()
        {
            WeatherForcast.WebAPI.Models.WeatherData _weatherData = new WeatherForcast.WebAPI.Models.WeatherData();
            _weatherData.Lat = 19.99;
            _weatherData.Log = 73.78;
            _weatherData.DT = DateTime.Now;
            _weatherData.WeatherType = "TM";
            var xDocument = new XDocument();
            var xElement = new XElement("tblWeatherDataResponse");
            var xAttributes = clsWeatherFactory.getData(_weatherData);
            Iweather _iWeather;
            _iWeather = clsWeatherFactory.getData(_weatherData);
            var response = _iWeather.getData(_weatherData);
            var root = JObject.Parse(response);
            tblWeatherDataResponse _weatherdataResponse = clsProcessData.dataResponse(root);
            XmlSerializer xsSubmit = new XmlSerializer(typeof(tblWeatherDataResponse));
           // var subReq = new MyObject();
            var xml = "";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, _weatherdataResponse);
                    xml = sww.ToString(); // Your XML
                }
            }
                //.Select(m => new XElement("Manufacturer",
                //                    new XAttribute("City", m.City),
                //                    new XAttribute("Name", m.Name),
                //                    new XAttribute("Year", m.Year)));

            xElement.Add(xAttributes);
            xDocument.Add(xElement);

            Console.WriteLine(xDocument);

            return xDocument;
        }
    }
}