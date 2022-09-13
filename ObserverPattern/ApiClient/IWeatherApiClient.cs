using System.Collections.Generic;
using System.Threading.Tasks;
using Observer.Dtos;

namespace Observer.ApiClient
{
    public interface IWeatherApiClient
    {
        Task<WeatherInformation> FetchWeatherInfo(string latitude, string longitude);
    }
}