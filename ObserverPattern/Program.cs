using System;
using System.Collections.Generic;
using System.Threading;
using Observer.ApiClient;
using Observer.Dtos;

namespace Observer
{
    class Program
    {

        private static Context _context;

        public static Context Context
        {
            get
            {
                if (_context is null)
                    _context = new Context();

                return _context;
            }
            set
            {
                _context = value;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Context.Observer = new WeatherWatcher();

            string choice = string.Empty;

            while (string.IsNullOrEmpty(choice))
            {
                DisplayMenu();

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddObservable();
                        break;
                    case "2":
                        DisplayObserverCallbacks();
                        break;
                    default:
                        return;
                }

                choice = string.Empty;

            }

        }

        static void DisplayMenu()
        {
            Console.Clear();

            Console.WriteLine("Weather Station");
            Console.WriteLine("\n--------------- MENU ---------------");
            Console.WriteLine("Digite 1 para adicionar um observador");
            Console.WriteLine("Digite 2 para visualizar os observadores");
        }

        static void DisplayObserverCallbacks()
        {
            Console.Clear();

            Context.DisplayObserversCallbacks = true;

            Console.WriteLine("Digite qualquer tecla para parar a visualização...");

            Console.ReadLine();

            Context.DisplayObserversCallbacks = false;

        }

        static void AddObservable()
        {
            Console.Clear();

            Console.WriteLine("Adicionar observador");

            string latitude = string.Empty;
            string longitude = string.Empty;

            while (string.IsNullOrEmpty(latitude))
            {
                Console.Write("Digite a latitude do local a ser observado: ");

                latitude = Console.ReadLine();
            }

            while (string.IsNullOrEmpty(longitude))
            {
                Console.Write("Digite a longitude do local a ser observado: ");

                longitude = Console.ReadLine();
            }

            IWatchable<WeatherInformation> watchable = new WeatherWatchable(
                Context,
                new WeatherProccess(new WeatherApiClient()),
                latitude: latitude,
                longitude: longitude
            );

            watchable.Add(Context.Observer);

            Context.Observables.Add(watchable);

            Console.WriteLine("Local adicionado com sucesso");
            Console.Clear();

        }
    }
}
