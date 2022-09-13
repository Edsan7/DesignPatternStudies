using System.Threading;
using System.Threading.Tasks;
using Observer.ApiClient;
using Observer.Dtos;

namespace Observer
{
    public class WeatherProccess : IWeatherWatcherProcessBehavior
    {
        private readonly IWeatherApiClient _weatherApiClient;

        public WeatherProccess(IWeatherApiClient weatherApiClient)
        {
            _weatherApiClient = weatherApiClient;
        }

        public async Task<WeatherInformation> ProcessWeatherByCoordinate(string latitude, string longitude)
        {
            return await _weatherApiClient.FetchWeatherInfo(latitude, longitude);

        }
    }
}