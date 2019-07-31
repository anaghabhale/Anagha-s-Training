using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebAPI.Models
{
    public class WeatherData
    {
        private double lat;
        public double Lat
        {
            get
            {
                return this.lat;
            }
            set
            {
                this.lat = value;
            }
        }

        private double log;
        public double Log
        {
            get
            {
                return this.log;
            }
            set
            {
                this.log = value;
            }
        }

        private DateTime dt;
        public DateTime DT
        {
            get
            {
                return this.dt;
            }
            set
            {
                this.dt = value;
            }
        }
        private string weatherType;
        public string WeatherType
        {
            get
            {
                return this.weatherType;
            }
            set
            {
                this.weatherType = value;
            }
        }

    }
}