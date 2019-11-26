using WeatherForcast.WebAPI.Models;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Web;
using WeatherForcast.WebAPI.ProcessUrl;
using Newtonsoft.Json;

namespace WeatherForcast.WebAPI.Factory
{
    public class clsJsonToObject : IProcessData
    {
        weatherDataResponse DataResponse;
        public clsJsonToObject(weatherDataResponse _dataResponse)
        {
            DataResponse = _dataResponse;
        }
        public weatherDataResponse dataResponse(JObject root)
        {

            //var DataResponse = new weatherDataResponse();
          //  localhost.DataConversion _web = new localhost.DataConversion();
            try
            {
                DataResponse.Lat = Convert.ToDouble(root["latitude"].ToString());
                DataResponse.Log = Convert.ToDouble(root["longitude"].ToString());
                DataResponse.TimeZone = root["timezone"].ToString();
               // DataResponse.Temperature = _web.farenhiteToCelsius(Convert.ToDouble(root["currently"]["temperature"].ToString()));
                DataResponse.UvIndex = Convert.ToInt16(root["currently"]["uvIndex"].ToString());
                DataResponse.Humidity = Convert.ToDouble(root["currently"]["humidity"].ToString());
                DataResponse.Pressure = Convert.ToDouble(root["currently"]["pressure"].ToString());
                DataResponse.ApparentTemperature = Convert.ToDouble(root["currently"]["apparentTemperature"].ToString());
                DataResponse.Time = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(root["currently"]["time"].ToString()));
                DataResponse.Summary = root["currently"]["summary"].ToString();
                DataResponse.Icon = root["currently"]["icon"].ToString();

                try
                {
                    dynamic objhourly = JsonConvert.DeserializeObject(root["hourly"]["data"].ToString());
                    List<hourly> lstHourly = new List<hourly>();
                    foreach (var obj in objhourly)
                    {
                        hourly _hourly = new hourly();
                        _hourly.Summary = obj.summary.ToString();
                        _hourly.Icon = obj.icon.ToString();
                        _hourly.PrecipIntensity = Convert.ToDouble(obj.precipIntensity.ToString());
                        _hourly.precipProbability = Convert.ToDouble(obj.precipProbability.ToString());
                        _hourly.Temperature = Convert.ToDouble(obj.temperature.ToString());
                        _hourly.apparentTemperature = Convert.ToDouble(obj.apparentTemperature.ToString());
                        _hourly.DewPoint = Convert.ToDouble(obj.dewPoint.ToString());
                        _hourly.Humidity = Convert.ToDouble(obj.humidity.ToString());
                        _hourly.Pressure = Convert.ToDouble(obj.pressure.ToString());
                        _hourly.windSpeed = Convert.ToDouble(obj.windSpeed.ToString());
                        _hourly.windGust = Convert.ToDouble(obj.windGust.ToString());
                        _hourly.windBearing = Convert.ToInt16(obj.windBearing.ToString());
                        _hourly.CloudCover = Convert.ToDouble(obj.cloudCover.ToString());
                        _hourly.UvIndex = Convert.ToInt16(obj.uvIndex.ToString());
                        _hourly.Visibility = Convert.ToDouble(obj.visibility.ToString());
                        _hourly.Ozone = Convert.ToDouble(obj.ozone.ToString());
                        lstHourly.Add(_hourly);
                    }
                    DataResponse._hourly = lstHourly;
                }
                catch (Exception Err)
                {
                    Console.Write(Err.Message.ToString());
                }
                try
                {
                    dynamic objdaily = JsonConvert.DeserializeObject(root["daily"]["data"].ToString());
                    List<daily> lstDaily = new List<daily>();
                    foreach (var obj in objdaily)
                    {
                        daily _daily = new daily();
                        _daily.Summary = obj.summary.ToString();
                        _daily.Icon = obj.icon.ToString();
                        _daily.SunriseTime = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.sunriseTime.ToString()));
                        _daily.SunseTime = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.sunsetTime.ToString()));
                        _daily.MoonPhase = Convert.ToDouble(obj.moonPhase.ToString());
                        _daily.PrecipIntensity = Convert.ToDouble(obj.precipIntensity.ToString());
                        _daily.PrecipIntensityMax = Convert.ToDouble(obj.precipIntensityMax.ToString());
                        _daily.precipIntensityMaxTime = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.precipIntensityMaxTime.ToString()));
                        _daily.precipProbability = Convert.ToDouble(obj.precipProbability.ToString());
                        _daily.precipType = obj.precipType.ToString();
                        _daily.temperatureHigh = Convert.ToDouble(obj.temperatureHigh.ToString());
                        _daily.temperatureHighTime = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.temperatureHighTime.ToString()));
                        _daily.temperatureLow = Convert.ToDouble(obj.temperatureLow.ToString());
                        _daily.temperatureLowTime = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.temperatureLowTime.ToString()));
                        _daily.apparentTemperatureHigh = Convert.ToDouble(obj.apparentTemperatureHigh.ToString());
                        _daily.apparentTemperatureHighTime = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.apparentTemperatureHighTime.ToString()));
                        _daily.apparentTemperatureLow = Convert.ToDouble(obj.apparentTemperatureLow.ToString());
                        _daily.apparentTemperatureLowTime = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.apparentTemperatureLowTime.ToString()));
                        _daily.DewPoint = Convert.ToDouble(obj.dewPoint.ToString());
                        _daily.Humidity = Convert.ToDouble(obj.humidity.ToString());
                        _daily.Pressure = Convert.ToDouble(obj.pressure.ToString());
                        _daily.windSpeed = Convert.ToDouble(obj.windSpeed.ToString());
                        _daily.windGust = Convert.ToInt16(obj.windGust.ToString());
                        _daily.windBearing = Convert.ToInt16(obj.windBearing.ToString());
                        _daily.CloudCover = Convert.ToDouble(obj.cloudCover.ToString());
                        _daily.UvIndex = Convert.ToInt16(obj.uvIndex.ToString());
                        _daily.uvIndexTime = Convert.ToDateTime(obj.uvIndexTime.ToString());
                        _daily.Visibility = Convert.ToInt16(obj.visibility.ToString());
                        _daily.Ozone = Convert.ToDouble(obj.ozone.ToString());
                        _daily.temperatureMin = Convert.ToDouble(obj.temperatureMin.ToString());
                        _daily.temperatureMinTime = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.temperatureMinTime.ToString()));
                        _daily.temperatureMax = Convert.ToDouble(obj.temperatureMax.ToString());
                        _daily.temperatureMaxTime = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.temperatureMaxTime.ToString()));
                        lstDaily.Add(_daily);
                    }
                    DataResponse._daily = lstDaily;
                }
                catch (Exception Err)
                {
                    Console.Write(Err.Message.ToString());
                }
                try
                {
                    dynamic objalert = JsonConvert.DeserializeObject(root["alert"]["data"].ToString());
                    List<alerts> lstAlert = new List<alerts>();
                    foreach (var obj in objalert)
                    {
                        alerts _alert = new alerts();
                        _alert.Title = obj.title.ToString();
                        _alert.Time = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.time.ToString()));
                        _alert.Expires = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.expires.ToString()));
                        _alert.Description = obj.description.ToString();
                        lstAlert.Add(_alert);
                    }
                    DataResponse._alerts = lstAlert;

                }
                catch (Exception Err)
                {
                    Console.Write(Err.Message.ToString());
                }
            }
            catch (Exception Err)
            {
                Console.Write(Err.Message.ToString());
            }
            return DataResponse;
        }
    }
}