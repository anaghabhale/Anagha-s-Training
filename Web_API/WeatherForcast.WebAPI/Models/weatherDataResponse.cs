using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherForcast.WebAPI.Models
{
    public class weatherDataResponse
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

        private string timezone;
        public string TimeZone
        {
            get
            {
                return this.timezone;
            }
            set
            {
                this.timezone = value;
            }
        }
        private double apparenttemperature;
        public double ApparentTemperature
        {
            get
            {
                return this.apparenttemperature;
            }
            set
            {
                this.apparenttemperature = value;
            }
        }

        private double pressure;
        public double Pressure
        {
            get
            {
                return this.pressure;
            }
            set
            {
                this.pressure = value;
            }
        }

        private double cloudcover;
        public double CloudCover
        {
            get
            {
                return this.cloudcover;
            }
            set
            {
                this.cloudcover = value;
            }
        }

        private double dewpoint;
        public double DewPoint
        {
            get
            {
                return this.dewpoint;
            }
            set
            {
                this.dewpoint = value;
            }
        }

        private double humidity;
        public double Humidity
        {
            get
            {
                return this.humidity;
            }
            set
            {
                this.humidity = value;
            }
        }

        private double precipintensity;
        public double PrecipIntensity
        {
            get
            {
                return this.precipintensity;
            }
            set
            {
                this.precipintensity = value;
            }
        }

        private double moonphase;
        public double MoonPhase
        {
            get
            {
                return this.moonphase;
            }
            set
            {
                this.moonphase = value;
            }
        }

        private double ozone;
        public double Ozone
        {
            get
            {
                return this.ozone;
            }
            set
            {
                this.ozone = value;
            }
        }
        private double precipprobability;
        public double PrecipProbability
        {
            get
            {
                return this.precipprobability;
            }
            set
            {
                this.precipprobability = value;
            }
        }

        private DateTime sunrisetime;
        public DateTime SunriseTime
        {
            get
            {
                return this.sunrisetime;
            }
            set
            {
                this.sunrisetime = value;
            }
        }

        private DateTime sunsetime;
        public DateTime SunseTime
        {
            get
            {
                return this.sunsetime;
            }
            set
            {
                this.sunsetime = value;
            }
        }

        private DateTime time;
        public DateTime Time
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }

        private double temperature;
        public double Temperature
        {
            get
            {
                return this.temperature;
            }
            set
            {
                this.temperature = value;
            }
        }

        private int uvindex;
        public int UvIndex
        {
            get
            {
                return this.uvindex;
            }
            set
            {
                this.uvindex = value;
            }
        }

       
        private string summary;
        public string Summary
        {
            get
            {
                return this.summary;
            }
            set
            {
                this.summary = value;
            }
        }
        private string icon;
        public string Icon
        {
            get
            {
                return this.icon;
            }
            set
            {
                this.icon = value;
            }
        }

        public List<minutely> _minutely;
        private List<minutely> Minutely
        {
            get
            {
                return this._minutely;
            }
            set
            {
                this._minutely = value;
            }
        }

        public List<hourly> _hourly;
        private List<hourly> Hourly
        {
            get
            {
                return this._hourly;
            }
            set
            {
                this._hourly = value;
            }
        }

        public List<daily> _daily;
        private List<daily> Daily
        {
            get
            {
                return this._daily;
            }
            set
            {
                this._daily = value;
            }
        }

        public List<alerts> _alerts;
        private List<alerts> Alerts
        {
            get
            {
                return this._alerts;
            }
            set
            {
                this._alerts = value;
            }
        }

    }

    public class minutely
    {
        private string summary;
        public string Summary
        {
            get
            {
                return this.summary;
            }
            set
            {
                this.summary = value;
            }
        }

        private string icon;
        public string Icon
        {
            get
            {
                return this.icon;
            }
            set
            {
                this.icon = value;
            }
        }

        private double precipintensity;
        public double PrecipIntensity
        {
            get
            {
                return this.precipintensity;
            }
            set
            {
                this.precipintensity = value;
            }
        }

        private double precipintensityerror;
        public double PrecipIntensityError
        {
            get
            {
                return this.precipintensityerror;
            }
            set
            {
                this.precipintensityerror = value;
            }
        }

        private double precipprobability;
        public double precipProbability
        {
            get
            {
                return this.precipprobability;
            }
            set
            {
                this.precipprobability = value;
            }
        }

        private double preciptype;
        public double precipType
        {
            get
            {
                return this.preciptype;
            }
            set
            {
                this.preciptype = value;
            }
        }

    }

    public class hourly 
    {
        private string summary;
        public string Summary
        {
            get
            {
                return this.summary;
            }
            set
            {
                this.summary = value;
            }
        }

        private string icon;
        public string Icon
        {
            get
            {
                return this.icon;
            }
            set
            {
                this.icon = value;
            }
        }

        private double precipintensity;
        public double PrecipIntensity
        {
            get
            {
                return this.precipintensity;
            }
            set
            {
                this.precipintensity = value;
            }
        }

        private double precipprobability;
        public double precipProbability
        {
            get
            {
                return this.precipprobability;
            }
            set
            {
                this.precipprobability = value;
            }
        }

        private double preciptype;
        public double precipType
        {
            get
            {
                return this.preciptype;
            }
            set
            {
                this.preciptype = value;
            }
        }

        private double temperature;
        public double Temperature
        {
            get
            {
                return this.temperature;
            }
            set
            {
                this.temperature = value;
            }
        }

        private double apparenttemperature;
        public double apparentTemperature
        {
            get
            {
                return this.apparenttemperature;
            }
            set
            {
                this.apparenttemperature = value;
            }
        }


        private double dewpoint;
        public double DewPoint
        {
            get
            {
                return this.dewpoint;
            }
            set
            {
                this.dewpoint = value;
            }
        }

        private double humidity;
        public double Humidity
        {
            get
            {
                return this.humidity;
            }
            set
            {
                this.humidity = value;
            }
        }

        private double pressure;
        public double Pressure
        {
            get
            {
                return this.pressure;
            }
            set
            {
                this.pressure = value;
            }
        }

        private double windspeed;
        public double windSpeed
        {
            get
            {
                return this.windspeed;
            }
            set
            {
                this.windspeed = value;
            }
        }

        private double windgust;
        public double windGust
        {
            get
            {
                return this.windgust;
            }
            set
            {
                this.windgust = value;
            }
        }

        private int windbearing;
        public int windBearing
        {
            get
            {
                return this.windbearing;
            }
            set
            {
                this.windbearing = value;
            }
        }

        private int uvindex;
        public int UvIndex
        {
            get
            {
                return this.uvindex;
            }
            set
            {
                this.uvindex = value;
            }
        }

        private double cloudcover;
        public double CloudCover
        {
            get
            {
                return this.cloudcover;
            }
            set
            {
                this.cloudcover = value;
            }
        }

        private double visibility;
        public double Visibility
        {
            get
            {
                return this.visibility;
            }
            set
            {
                this.visibility = value;
            }
        }

        private double ozone;
        public double Ozone
        {
            get
            {
                return this.ozone;
            }
            set
            {
                this.ozone = value;
            }
        }

    }

    public class daily
    {
        private string summary;
        public string Summary
        {
            get
            {
                return this.summary;
            }
            set
            {
                this.summary = value;
            }
        }

        private string icon;
        public string Icon
        {
            get
            {
                return this.icon;
            }
            set
            {
                this.icon = value;
            }
        }

        private DateTime sunrisetime;
        public DateTime SunriseTime
        {
            get
            {
                return this.sunrisetime;
            }
            set
            {
                this.sunrisetime = value;
            }
        }

        private DateTime sunsetime;
        public DateTime SunseTime
        {
            get
            {
                return this.sunsetime;
            }
            set
            {
                this.sunsetime = value;
            }
        }

        private double moonphase;
        public double MoonPhase
        {
            get
            {
                return this.moonphase;
            }
            set
            {
                this.moonphase = value;
            }
        }

        private double precipintensity;
        public double PrecipIntensity
        {
            get
            {
                return this.precipintensity;
            }
            set
            {
                this.precipintensity = value;
            }
        }

        private double precipintensitymax;
        public double PrecipIntensityMax
        {
            get
            {
                return this.precipintensitymax;
            }
            set
            {
                this.precipintensitymax = value;
            }
        }

        private DateTime precipintensitymaxtime;
        public DateTime precipIntensityMaxTime
        {
            get
            {
                return this.precipintensitymaxtime;
            }
            set
            {
                this.precipintensitymaxtime = value;
            }
        }

        private double precipprobability;
        public double precipProbability
        {
            get
            {
                return this.precipprobability;
            }
            set
            {
                this.precipprobability = value;
            }
        }

        private double preciptype;
        public double precipType
        {
            get
            {
                return this.preciptype;
            }
            set
            {
                this.preciptype = value;
            }
        }

        private double temperaturehigh;
        public double temperatureHigh
        {
            get
            {
                return this.temperaturehigh;
            }
            set
            {
                this.temperaturehigh = value;
            }
        }

        private DateTime temperaturehightime;
        public DateTime temperatureHighTime
        {
            get
            {
                return this.temperaturehightime;
            }
            set
            {
                this.temperaturehightime = value;
            }
        }

        private double temperaturelow;
        public double temperatureLow
        {
            get
            {
                return this.temperaturelow;
            }
            set
            {
                this.temperaturelow = value;
            }
        }

        private DateTime temperaturelowtime;
        public DateTime temperatureLowTime
        {
            get
            {
                return this.temperaturelowtime;
            }
            set
            {
                this.temperaturelowtime = value;
            }
        }

        private double apparenttemperaturehigh;
        public double apparentTemperatureHigh
        {
            get
            {
                return this.apparenttemperaturehigh;
            }
            set
            {
                this.apparenttemperaturehigh = value;
            }
        }

        private DateTime apparenttemperaturehightime;
        public DateTime apparentTemperatureHighTime
        {
            get
            {
                return this.apparenttemperaturehightime;
            }
            set
            {
                this.apparenttemperaturehightime = value;
            }
        }

        private double apparenttemperaturelow;
        public double apparentTemperatureLow
        {
            get
            {
                return this.apparenttemperaturelow;
            }
            set
            {
                this.apparenttemperaturelow = value;
            }
        }

        private DateTime apparenttemperaturelowtime;
        public DateTime apparentTemperatureLowTime
        {
            get
            {
                return this.apparenttemperaturelowtime;
            }
            set
            {
                this.apparenttemperaturelowtime = value;
            }
        }

        private double dewpoint;
        public double DewPoint
        {
            get
            {
                return this.dewpoint;
            }
            set
            {
                this.dewpoint = value;
            }
        }

        private double humidity;
        public double Humidity
        {
            get
            {
                return this.humidity;
            }
            set
            {
                this.humidity = value;
            }
        }

        private double pressure;
        public double Pressure
        {
            get
            {
                return this.pressure;
            }
            set
            {
                this.pressure = value;
            }
        }

        private double windspeed;
        public double windSpeed
        {
            get
            {
                return this.windspeed;
            }
            set
            {
                this.windspeed = value;
            }
        }

        private double windgust;
        public double windGust
        {
            get
            {
                return this.windgust;
            }
            set
            {
                this.windgust = value;
            }
        }

        private DateTime windgusttime;
        public DateTime windGustTime
        {
            get
            {
                return this.windgusttime;
            }
            set
            {
                this.windgusttime = value;
            }
        }

        private int windbearing;
        public int windBearing
        {
            get
            {
                return this.windBearing;
            }
            set
            {
                this.windBearing = value;
            }
        }

        private int uvindex;
        public int UvIndex
        {
            get
            {
                return this.uvindex;
            }
            set
            {
                this.uvindex = value;
            }
        }

        private double cloudcover;
        public double CloudCover
        {
            get
            {
                return this.cloudcover;
            }
            set
            {
                this.cloudcover = value;
            }
        }

        private DateTime uvindextime;
        public DateTime uvIndexTime
        {
            get
            {
                return this.uvindextime;
            }
            set
            {
                this.uvindextime = value;
            }
        }

        private int visibility;
        public int Visibility
        {
            get
            {
                return this.visibility;
            }
            set
            {
                this.visibility = value;
            }
        }

        private double ozone;
        public double Ozone
        {
            get
            {
                return this.ozone;
            }
            set
            {
                this.ozone = value;
            }
        }

        private double temperaturemin;
        public double temperatureMin
        {
            get
            {
                return this.temperaturemin;
            }
            set
            {
                this.temperaturemin = value;
            }
        }

        private DateTime temperaturemintime;
        public DateTime temperatureMinTime
        {
            get
            {
                return this.temperaturemintime;
            }
            set
            {
                this.temperaturemintime = value;
            }
        }

        private double temperaturemax;
        public double temperatureMax
        {
            get
            {
                return this.temperaturemax;
            }
            set
            {
                this.temperaturemax = value;
            }
        }

        private DateTime temperaturemaxtime;
        public DateTime temperatureMaxTime
        {
            get
            {
                return this.temperaturemaxtime;
            }
            set
            {
                this.temperaturemaxtime = value;
            }
        }

        private double apparenttemperaturemin;
        public double apparentTemperatureMin
        {
            get
            {
                return this.apparenttemperaturemin;
            }
            set
            {
                this.apparenttemperaturemin = value;
            }
        }

        private DateTime apparenttemperaturemintime;
        public DateTime apparentTemperatureMinTime
        {
            get
            {
                return this.apparenttemperaturemintime;
            }
            set
            {
                this.apparenttemperaturemintime = value;
            }
        }

        private double apparenttemperaturemax;
        public double apparentTemperatureMax
        {
            get
            {
                return this.apparenttemperaturemax;
            }
            set
            {
                this.apparenttemperaturemax = value;
            }
        }

        private DateTime apparenttemperaturemaxtime;
        public DateTime apparentTemperatureMaxTime
        {
            get
            {
                return this.apparenttemperaturemaxtime;
            }
            set
            {
                this.apparenttemperaturemaxtime = value;
            }
        }

    }

    public class alerts
    {
        private string title;
        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }

        private DateTime time;
        public DateTime Time
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }

        private DateTime expires;
        public DateTime Expires
        {
            get
            {
                return this.expires;
            }
            set
            {
                this.expires = value;
            }
        }

        private string description;
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }
    }
}