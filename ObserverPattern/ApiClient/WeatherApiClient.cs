using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using Observer.Dtos;

namespace Observer.ApiClient
{
    public class WeatherApiClient : IWeatherApiClient
    {
        private readonly ApiCommunication _apiClient;

        public WeatherApiClient()
        {
            _apiClient = new ApiCommunication("https://api.open-meteo.com/v1/");
        }


        public async Task<WeatherInformation> FetchWeatherInfo(string latitude, string longitude)
        {
            try
            {

                var queryParams = new Dictionary<string, string>()
                {
                    { "latitude", latitude },
                    { "longitude", longitude },
                    { "hourly", "temperature_2m" },
                    { "timezone", "auto"},
                };


                var response = await _apiClient.SendGet<WeatherDto>("forecast?", queryParams);

                if (response is null)
                    return null;

                var now = DateTime.Now;
                var timeNow = DateTime.Now.TimeOfDay;
                TimeSpan time;

                if (timeNow.Minutes > 30)
                    time = new TimeSpan(timeNow.Hours + 1, 0, 0);
                else
                    time = new TimeSpan(timeNow.Hours, 0, 0);

                var currentTime = response
                    .Hourly
                    .Time
                    .FirstOrDefault(
                        x => x.Split("T")[1] == 
                        string.Format(
                            "{0:00}:{1:00}", 
                            time.Hours, 
                            time.Minutes
                        )
                    );

                var currentTimeIndex = response
                    .Hourly
                    .Time
                    .IndexOf(currentTime);


                var weatherInformation = new WeatherInformation
                {
                    DateTime = DateTime.Now,
                    CurrentTemperature = response.Hourly.Temperature2m[currentTimeIndex].ToString(),
                    TimeZone = response.Timezone,
                    Elevation = response.Elevation,
                    Latitude = response.Latitude,
                    Longitude = response.Longitude
                };

                return weatherInformation;

            }
            catch (System.Exception)
            {
                Console.WriteLine("Um erro ocorreu");
            }

            return null;
        }
    }
}