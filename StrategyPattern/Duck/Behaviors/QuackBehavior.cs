using System;
using StrategyPattern.Ducks.Behaviors.Interfaces;

namespace StrategyPattern.Ducks.Behaviors
{
    public class QuackBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Duck is quacking");
        }
    }
}