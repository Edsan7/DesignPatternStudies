
using System;
using Observer.Dtos;

namespace Observer
{
    public class WeatherWatcher : IWatcher<WeatherInformation>
    {
        public Guid Guid { get; set; } = Guid.NewGuid();

        public void OnNotified(WeatherInformation payload, Context context)
        {
            if (!context.DisplayObserversCallbacks) return;

            if (payload is null)
            {
                Console.WriteLine("Um erro ocorreu ao ler os dados retornados");
                return;
            }

            Console.WriteLine();
            System.Console.WriteLine($"Observer {Guid} notified!");

            Console.WriteLine($"Latitude: {payload.Latitude}");
            Console.WriteLine($"Longitude: {payload.Longitude}");
            Console.WriteLine($"Elevation: {payload.Elevation}");

            Console.WriteLine($"Timezone: {payload.TimeZone}");
            Console.WriteLine($"Date: {payload.DateTime.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Current temperature: {payload.CurrentTemperature}");

        }
    }
}