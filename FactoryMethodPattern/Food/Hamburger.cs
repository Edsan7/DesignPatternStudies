namespace FactoryMethodPattern.Foods
{
    public class Hamburger : IFood
    {
        public bool IsHealthy()
        {
            return false;
        }
    }
}