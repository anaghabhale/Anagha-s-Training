
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using AutoMapper;
//using AutoMapper.Configuration;
//using Microsoft.Practices.Unity;
using WeatherForcast.WebAPI.Factory;
using ModelData;

namespace WeatherForcast.WebAPI.ProcessUrl
{
    public class clsProcessData
    {
        static public tblWeatherDataResponse dataResponse(JObject root)
        {
           // IProcessData _iProcessData;
            try {
                // WeatherForecastEntities1 DataResponse = new WeatherForecastEntities1();
                ModelData.tblWeatherDataResponse DataResponse = new ModelData.tblWeatherDataResponse();
               DataConversionRef.DataConversion _web = new DataConversionRef.DataConversion();
                List<ModelData.tblHourly> lstHourly = new List<ModelData.tblHourly>();
                try
                {
                    DataResponse.Lat = Convert.ToDecimal(root["latitude"].ToString());
                    DataResponse.Long = Convert.ToDecimal(root["longitude"].ToString());
                    DataResponse.TimeZone = root["timezone"].ToString();
                    DataResponse.Temperature = Convert.ToDecimal(_web.farenhiteToCelsius(Convert.ToDouble(root["currently"]["temperature"].ToString())).ToString("#.##"));
                    DataResponse.UvIndex = Convert.ToInt16(root["currently"]["uvIndex"].ToString());
                    DataResponse.Humidity = Convert.ToDecimal(root["currently"]["humidity"].ToString());
                    DataResponse.Pressure = Convert.ToDecimal(root["currently"]["pressure"].ToString());
                    DataResponse.ApparentTemperature = Convert.ToDecimal(root["currently"]["apparentTemperature"].ToString());
                    DataResponse.RequestTime = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(root["currently"]["time"].ToString()));
                    DataResponse.Summary = root["currently"]["summary"].ToString();
                    DataResponse.Icon = root["currently"]["icon"].ToString();

                    try
                    {
                        dynamic objhourly = JsonConvert.DeserializeObject(root["hourly"]["data"].ToString());
                       
                        foreach (var obj in objhourly)
                        {
                            tblHourly _hourly = new tblHourly();
                            _hourly.Summary = obj.summary.ToString();
                            _hourly.Icon = obj.icon.ToString();
                            _hourly.PrecipIntensity = Convert.ToDecimal(obj.precipIntensity.ToString());
                            _hourly.precipProbability = Convert.ToDecimal(obj.precipProbability.ToString());
                            _hourly.Temperature = Convert.ToDecimal(obj.temperature.ToString());
                            _hourly.apparentTemperature = Convert.ToDecimal(obj.apparentTemperature.ToString());
                            _hourly.DewPoint = Convert.ToDecimal(obj.dewPoint.ToString());
                            _hourly.Humidity = Convert.ToDecimal(obj.humidity.ToString());
                            _hourly.Pressure = Convert.ToDecimal(obj.pressure.ToString());
                            _hourly.windSpeed = Convert.ToDecimal(obj.windSpeed.ToString());
                            _hourly.windGust = Convert.ToDecimal(obj.windGust.ToString());
                            _hourly.windBearing = Convert.ToInt16(obj.windBearing.ToString());
                            _hourly.CloudCover = Convert.ToDecimal(obj.cloudCover.ToString());
                            _hourly.UvIndex = Convert.ToInt16(obj.uvIndex.ToString());
                            _hourly.Visibility = Convert.ToDecimal(obj.visibility.ToString());
                            _hourly.Ozone = Convert.ToDecimal(obj.ozone.ToString());
                            lstHourly.Add(_hourly);
                        }
                        DataResponse.tblHourlies = lstHourly;
                    }
                    catch (Exception Err)
                    {
                        Console.Write(Err.Message.ToString());
                    }
                    try
                    {
                        dynamic objdaily = JsonConvert.DeserializeObject(root["daily"]["data"].ToString());
                        List<tblDaily> lstDaily = new List<tblDaily>();
                        foreach (var obj in objdaily)
                        {
                            tblDaily _daily = new tblDaily();
                          //  _daily.Summary = obj.summary.ToString();
                            _daily.Icon = obj.icon.ToString();
                            _daily.SunriseTime = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.sunriseTime.ToString()));
                            _daily.SunseTime = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.sunsetTime.ToString()));
                            _daily.MoonPhase = Convert.ToDecimal(obj.moonPhase.ToString());
                            _daily.PrecipIntensity = Convert.ToDecimal(obj.precipIntensity.ToString());
                            _daily.PrecipIntensityMax = Convert.ToDecimal(obj.precipIntensityMax.ToString());
                            _daily.precipIntensityMaxTime = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.precipIntensityMaxTime.ToString()));
                            _daily.precipProbability = Convert.ToDecimal(obj.precipProbability.ToString());
                            _daily.precipType =  obj.precipType!=null? obj.precipType.ToString():"";
                            _daily.temperatureHigh = Convert.ToDecimal(obj.temperatureHigh.ToString());
                            _daily.temperatureHighTime = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.temperatureHighTime.ToString()));
                            _daily.temperatureLow = Convert.ToDecimal(obj.temperatureLow.ToString());
                            _daily.temperatureLowTime = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.temperatureLowTime.ToString()));
                            _daily.apparentTemperatureHigh = Convert.ToDecimal(obj.apparentTemperatureHigh.ToString());
                            _daily.apparentTemperatureHighTime = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.apparentTemperatureHighTime.ToString()));
                            _daily.apparentTemperatureLow = Convert.ToDecimal(obj.apparentTemperatureLow.ToString());
                            _daily.apparentTemperatureLowTime = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.apparentTemperatureLowTime.ToString()));
                            _daily.DewPoint = Convert.ToDecimal(obj.dewPoint.ToString());
                            _daily.Humidity = Convert.ToDecimal(obj.humidity.ToString());
                            _daily.Pressure = Convert.ToDecimal(obj.pressure.ToString());
                            _daily.windSpeed = Convert.ToDecimal(obj.windSpeed.ToString());
                            _daily.windGust = Convert.ToDecimal(obj.windGust.ToString());
                            _daily.windBearing = Convert.ToDecimal(obj.windBearing.ToString());
                            _daily.CloudCover = Convert.ToDecimal(obj.cloudCover.ToString());
                            _daily.UvIndex = Convert.ToDecimal(obj.uvIndex.ToString());
                            _daily.uvIndexTime = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.uvIndexTime.ToString()));
                            _daily.Visibility = Convert.ToDecimal(obj.visibility.ToString());
                            _daily.Ozone = Convert.ToDecimal(obj.ozone.ToString());
                            _daily.temperatureMin = Convert.ToDecimal(obj.temperatureMin.ToString());
                            _daily.temperatureMinTime = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.temperatureMinTime.ToString()));
                            _daily.temperatureMax = Convert.ToDecimal(obj.temperatureMax.ToString());
                            _daily.temperatureMaxTime = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.temperatureMaxTime.ToString()));
                            lstDaily.Add(_daily);
                        }
                        DataResponse.tblDailies = lstDaily;
                    }
                    catch (Exception Err)
                    {
                        Console.Write(Err.Message.ToString());
                    }
                    try
                    {
                        //dynamic objalert = JsonConvert.DeserializeObject(root["alert"]["data"].ToString());
                        //List<alerts> lstAlert = new List<alerts>();
                        //foreach (var obj in objalert)
                        //{
                        //    alerts _alert = new alerts();
                        //    _alert.Title = obj.title.ToString();
                        //    _alert.Time = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.time.ToString()));
                        //    _alert.Expires = MyWebRequest.UnixTimeStampToDateTime(Convert.ToDouble(obj.expires.ToString()));
                        //    _alert.Description = obj.description.ToString();
                        //    lstAlert.Add(_alert);
                        //}
                        //DataResponse._alerts = lstAlert;
                      

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
              //  MyWebRequest _myWebRequest = new MyWebRequest("http://localhost/Conversion/DataConversion.asmx?op=saveLiveWeatherDataToDB&_tblWeatherDataResponse=" + DataResponse,"POST");
                //string response = _myWebRequest.GetResponse();
                _web.saveLiveWeatherDataToDB(DataResponse);
                return DataResponse;
            }
                catch(Exception Err)
                {
                    Console.Write(Err.Message.ToString());
                return null;
            }

        }
      
    }

    public static class JsonExtensions
    {
        public static void PopulateObject<T>(this JToken jt, T target)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Populate(jt.CreateReader(), target);
        }
    }
}