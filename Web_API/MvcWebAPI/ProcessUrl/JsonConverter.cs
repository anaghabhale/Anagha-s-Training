using ModelData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MvcWebAPI.ProcessUrl
{
    public class JsonConverter
    {

        private XDocument _weatherDataResponse;

        public JsonConverter(XDocument weatherDataResponse)
            {
                _weatherDataResponse = weatherDataResponse;
            }

            public void ConvertToJson()
            {
                var jsonManufacturers = JsonConvert.SerializeObject(_weatherDataResponse, Formatting.Indented);

                Console.WriteLine("\nPrinting JSON list\n");
                Console.WriteLine(jsonManufacturers);
            }
        } 
    }