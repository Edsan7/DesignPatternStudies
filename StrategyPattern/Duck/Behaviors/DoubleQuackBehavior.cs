using System;
using StrategyPattern.Ducks.Behaviors.Interfaces;

namespace StrategyPattern.Ducks.Behaviors
{
    public class DoubleQuackBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("duck is double quacking");
        }
    }
}