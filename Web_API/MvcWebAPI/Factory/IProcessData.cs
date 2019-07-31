using MvcWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcWebAPI.Factory
{
    public interface IProcessData
    {
        weatherDataResponse dataResponse(Newtonsoft.Json.Linq.JObject root);
    }
}
