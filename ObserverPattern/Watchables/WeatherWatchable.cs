
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Observer.ApiClient;
using Observer.Dtos;

namespace Observer
{
    public class WeatherWatchable : IWatchable<WeatherInformation>
    {
        public WeatherInformation Payload { get; set; }

        public List<IWatcher<WeatherInformation>> Observers { get; private set; } = new();

        private readonly Timer _timer;

        private readonly IWeatherWatcherProcessBehavior _weatherProcess;

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        private readonly Context _context;

        public WeatherWatchable(
            Context context,
            IWeatherWatcherProcessBehavior weatherProcess,
            string latitude,
            string longitude
        )
        {
            _weatherProcess = weatherProcess;
            _context = context;
            Latitude = latitude;
            Longitude = longitude;
            _timer = new Timer(
                async (state) => await Proccess(),
                null,
                0,
                5000
            );
        }

        private async Task Proccess()
        {
            Payload = await _weatherProcess
                .ProcessWeatherByCoordinate(Latitude, Longitude);

            Notify();
        }

        public void Add(IWatcher<WeatherInformation> observer)
        {
            Observers.Add(observer);
        }

        public void Notify()
        {
            foreach (var observer in Observers)
                observer.OnNotified(Payload, _context);
        }

        public void Remove(IWatcher<WeatherInformation> observer)
        {
            Observers.Remove(observer);
        }
    }
}