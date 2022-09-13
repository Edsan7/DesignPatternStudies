using System.Collections.Generic;
using Observer.Dtos;

namespace Observer
{
    public class Context
    {
        public List<IWatchable<WeatherInformation>> Observables { get; set; } = new();

        public IWatcher<WeatherInformation> Observer { get; set; }

        public bool DisplayObserversCallbacks { get; set; } = false;
    }
}