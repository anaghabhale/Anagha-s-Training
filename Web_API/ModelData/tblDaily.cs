//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelData
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDaily
    {
        public int Id { get; set; }
        public int weatherDataResponseId { get; set; }
        public string Summary { get; set; }
        public string Icon { get; set; }
        public Nullable<System.DateTime> SunriseTime { get; set; }
        public Nullable<System.DateTime> SunseTime { get; set; }
        public Nullable<decimal> MoonPhase { get; set; }
        public Nullable<decimal> PrecipIntensity { get; set; }
        public Nullable<decimal> PrecipIntensityMax { get; set; }
        public Nullable<System.DateTime> precipIntensityMaxTime { get; set; }
        public Nullable<decimal> precipProbability { get; set; }
        public string precipType { get; set; }
        public Nullable<decimal> temperatureHigh { get; set; }
        public Nullable<System.DateTime> temperatureHighTime { get; set; }
        public Nullable<decimal> temperatureLow { get; set; }
        public Nullable<System.DateTime> temperatureLowTime { get; set; }
        public Nullable<decimal> apparentTemperatureHigh { get; set; }
        public Nullable<System.DateTime> apparentTemperatureHighTime { get; set; }
        public Nullable<decimal> apparentTemperatureLow { get; set; }
        public Nullable<System.DateTime> apparentTemperatureLowTime { get; set; }
        public Nullable<decimal> DewPoint { get; set; }
        public Nullable<decimal> Humidity { get; set; }
        public Nullable<decimal> Pressure { get; set; }
        public Nullable<decimal> windSpeed { get; set; }
        public Nullable<decimal> windGust { get; set; }
        public Nullable<System.DateTime> windGustTime { get; set; }
        public Nullable<decimal> windBearing { get; set; }
        public Nullable<decimal> UvIndex { get; set; }
        public Nullable<decimal> CloudCover { get; set; }
        public Nullable<System.DateTime> uvIndexTime { get; set; }
        public Nullable<decimal> Visibility { get; set; }
        public Nullable<decimal> Ozone { get; set; }
        public Nullable<decimal> temperatureMin { get; set; }
        public Nullable<System.DateTime> temperatureMinTime { get; set; }
        public Nullable<decimal> temperatureMax { get; set; }
        public Nullable<System.DateTime> temperatureMaxTime { get; set; }
        public Nullable<decimal> apparentTemperatureMin { get; set; }
        public Nullable<System.DateTime> apparentTemperatureMinTime { get; set; }
        public Nullable<decimal> apparentTemperatureMax { get; set; }
        public Nullable<System.DateTime> apparentTemperatureMaxTime { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual tblWeatherDataResponse tblWeatherDataResponse { get; set; }
    }
}