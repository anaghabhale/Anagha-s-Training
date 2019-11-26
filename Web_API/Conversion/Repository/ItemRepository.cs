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
                foreach (tblHourly obj in _tblWeatherDataResponse.tblHourlies)
                {
                    _weatherDataResponse.tblHourlies.Add(obj);
                }
                _weatherDataResponse.SaveChanges();
            }
            catch(Exception Err)
            {
                Console.Write(Err.Message.ToString());
            }
            return i;
        }

        public tblDaily getWeatherDataFromDB(WeatherData _weatherData)
        {
            tblDaily daily=null;
            try
            {
                using (var context = new WeatherForecastEntities1())
                {
                    var query = from st in context.tblDailies
                                where st.tblWeatherDataResponse.Lat == Convert.ToDecimal(_weatherData.Lat) && st.tblWeatherDataResponse.Long == Convert.ToDecimal(_weatherData.Log) && st.tblWeatherDataResponse.RequestTime == _weatherData.DT
                               select st;

                    daily = query.FirstOrDefault<tblDaily>();
                }
            }
            catch (Exception Err)
            {
                Console.Write(Err.Message.ToString());
            }
            return daily;
        }
    }
}