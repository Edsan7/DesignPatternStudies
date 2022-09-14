using FactoryMethodPattern.Foods;
using FactoryMethodPattern.Persons;

namespace FactoryMethodPattern.Factories
{
    public interface IFoodFactory
    {
        IFood CreateFoodByPerson(Person person);
    }
}