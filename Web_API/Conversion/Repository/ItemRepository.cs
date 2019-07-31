using ModelData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conversion.Repository
{
    public class ItemRepository
    {
        WeatherForecastEntities1 _weatherDataResponse = new WeatherForecastEntities1();
       
        public int saveWeatherDataToDB(ModelData.tblWeatherDataResponse _tblWeatherDataResponse)
        {
            int i = 0;
            try
            {
                _weatherDataResponse.tblWeatherDataResponses.Add(_tblWeatherDataResponse);
                _weatherDataResponse.SaveChanges();
            }
            catch(Exception Err)
            {
                Console.Write(Err.Message.ToString());
            }
            return i;
        }
    }
}