using System;

namespace Observer.Dtos
{
    public class WeatherInformation
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public double Elevation { get; set; }

        public string CurrentTemperature { get; set; }

        public DateTime DateTime { get; set; }

        public string TimeZone { get; set; }
    }
}