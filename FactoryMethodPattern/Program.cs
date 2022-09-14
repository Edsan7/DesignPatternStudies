using System;
using FactoryMethodPattern.Factories;
using FactoryMethodPattern.Persons;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IFoodFactory foodFactory = new FoodFactory();

            var seuZe = new Person
            (
                "Zézinho",
                80,
                180,
                HealthSituation.Healthy
            );

            var seuZeFood = foodFactory.CreateFoodByPerson(seuZe);

            var maria = new Person
            (
                "Maria",
                90,
                165,
                HealthSituation.Sick
            );

            var mariaFood = foodFactory.CreateFoodByPerson(maria);

        }
    }
}
