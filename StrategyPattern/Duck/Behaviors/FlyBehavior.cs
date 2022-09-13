using System;
using StrategyPattern.Ducks.Behaviors.Interfaces;

namespace StrategyPattern.Ducks.Behaviors
{
    public class FlyBehavior : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Duck is flying");
        }
    }
}
