using System;
using StrategyPattern.Ducks;
using StrategyPattern.Ducks.Behaviors;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /// O Strategy é um padrão de projeto comportamental 
            /// que transforma um conjunto de comportamentos em objetos 
            /// e os torna intercambiáveis dentro do objeto de contexto original.


            var flyingDuck = new Duck(
                "The flying duck",
                flyBehavior: new FlyBehavior()
            );

            flyingDuck.Fly();
            flyingDuck.Quack();

            var quackingDuck = new Duck(
                "The simple quack duck",
                quackBehavior: new QuackBehavior()
            );

            quackingDuck.Quack();
            quackingDuck.Display();
            quackingDuck.Fly();

            var doubleQuackDuck = new Duck(
                "The double quack duck",
                quackBehavior: new DoubleQuackBehavior(),
                displayBehavior: new DisplayBehavior()
            );

            doubleQuackDuck.Quack();
            doubleQuackDuck.Display();

        }
    }
}
