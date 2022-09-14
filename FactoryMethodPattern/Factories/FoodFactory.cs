using FactoryMethodPattern.Foods;
using FactoryMethodPattern.Persons;

namespace FactoryMethodPattern.Factories
{
    public class FoodFactory : IFoodFactory
    {
        public IFood CreateFoodByPerson(Person person)
        {
            if(person.HealthSituation != HealthSituation.Healthy)
                return new Salad();

            switch(person.Imc())
            {
                case < 24.9:
                    return new Hamburger();

                case 29.9:
                    return new Apple();

                case 39.9:
                    return new Salad();
                
                default:
                    return new RiceGrain();

            }
        }
    }
}