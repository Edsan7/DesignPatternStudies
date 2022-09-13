using System;
using StrategyPattern.Ducks.Behaviors.Interfaces;

namespace StrategyPattern.Ducks
{
    public class Duck
    {
        public string Name { get; set; }

        public Duck(
            string name,
            IQuackBehavior quackBehavior = null,
            IFlyBehavior flyBehavior = null,
            IDisplayBehavior displayBehavior = null)
        {
            Name = name;
            _quackBehavior = quackBehavior;
            _flyBehavior = flyBehavior;
            _displayBehavior = displayBehavior;
        }

        private readonly IQuackBehavior _quackBehavior;

        private readonly IFlyBehavior _flyBehavior;

        private readonly IDisplayBehavior _displayBehavior;


        public void Quack()
        {
            Console.WriteLine($"Trying to make {Name} quack...");

            try
            {
                if (_quackBehavior is null)
                    throw new ArgumentNullException(nameof(_quackBehavior));


                _quackBehavior.Quack();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"An error occurred when making {Name} quack {ex.Message}");
            }
        }

        public void Fly()
        {
            Console.WriteLine($"Trying to make {Name} fly...");

            try
            {
                if (_flyBehavior is null)
                    throw new ArgumentNullException(nameof(_flyBehavior));

                _flyBehavior.Fly();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"An error occurred when making {Name} fly {ex.Message}");
            }

        }

        public void Display()
        {
            Console.WriteLine($"Trying to display {Name} ...");

            try
            {
                if (_displayBehavior is null)
                    throw new ArgumentNullException(nameof(_displayBehavior));

                _displayBehavior.Display(this);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"An error occurred when making {Name} fly {ex.Message}");
            }
        }

    }
}