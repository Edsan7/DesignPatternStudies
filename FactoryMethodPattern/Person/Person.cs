using System;

namespace FactoryMethodPattern.Persons
{
    public class Person
    {
        public string Name { get; set; }

        public double Weight { get; set; }

        public double Height { get; set; }

        public HealthSituation HealthSituation { get; set; }

        public Person(string name, double weight, double height, HealthSituation healthSituation)
        {
            Name = name;
            Weight = weight;
            Height = height;
            HealthSituation = healthSituation;
        }


        public double Imc()
        {
            return Weight / Math.Pow(Height, 2);
        }
    }
}