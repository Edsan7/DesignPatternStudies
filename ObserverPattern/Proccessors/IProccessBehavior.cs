using System.Threading.Tasks;
using Observer.Dtos;

namespace Observer
{
    public interface IWeatherWatcherProcessBehavior
    {
        Task<WeatherInformation> ProcessWeatherByCoordinate(string latitude, string longitude);
    }
}