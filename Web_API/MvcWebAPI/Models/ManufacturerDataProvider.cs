using ModelData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebAPI.Models
{
    public class ManufacturerDataProvider
    {

    public List<tblWeatherDataResponse> GetData() =>
       new List<tblWeatherDataResponse>
       {
            new tblWeatherDataResponse { ApparentTemperature = "Italy", Name = "Alfa Romeo", Year = 2016 },
            new tblWeatherDataResponse { City = "UK", Name = "Aston Martin", Year = 2018 },
            new tblWeatherDataResponse { City = "USA", Name = "Dodge", Year = 2017 },
            new tblWeatherDataResponse { City = "Japan", Name = "Subaru", Year = 2016 },
            new tblWeatherDataResponse { City = "Germany", Name = "BMW", Year = 2015 }
       };
    }
}
