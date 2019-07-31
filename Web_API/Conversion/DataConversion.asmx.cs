using Conversion.Repository;
using ModelData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Conversion
{
    /// <summary>
    /// Summary description for DataConversion
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class DataConversion : System.Web.Services.WebService
    {

        [WebMethod]
        public double farenhiteToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }

        [WebMethod]
        public double celsiusTofarenhite(double celsius)
        {
            double fahrenheit = (celsius * 9) / 5 + 32;
            return fahrenheit;
        }

        [WebMethod]
        public int saveLiveWeatherDataToDB(ModelData.tblWeatherDataResponse _tblWeatherDataResponse)
        {
            ItemRepository _ItemRepository = new ItemRepository();
            int i=_ItemRepository.saveWeatherDataToDB(_tblWeatherDataResponse);
            return i;
        }

    }
}