namespace FactoryMethodPattern.Foods
{
    public class RiceGrain : IFood
    {
        public bool IsHealthy()
        {
            return true;
        }
    }
}