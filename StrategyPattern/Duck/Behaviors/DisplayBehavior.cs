using System;
using StrategyPattern.Ducks.Behaviors.Interfaces;

namespace StrategyPattern.Ducks.Behaviors
{
    public class DisplayBehavior : IDisplayBehavior
    {
        public void Display(Duck duck)
        {
            Console.WriteLine($"Displaying information about the duck: {duck.Name}");
        }
    }
}