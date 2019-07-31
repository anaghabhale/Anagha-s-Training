using MvcWebAPI.ProcessUrl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Linq;

namespace MvcWebAPI.Factory
{
    public class XmlToJsonAdapter : IXmlToJson
    {
        private readonly XmlConverter _xmlConverter;

        public XmlToJsonAdapter(XmlConverter xmlConverter)
        {
            _xmlConverter = xmlConverter;
        }

        public void ConvertXmlToJson()
        {
            XDocument weatherData = _xmlConverter.GetXML();
            new JsonConverter(weatherData).ConvertToJson();
        }
    }
}
