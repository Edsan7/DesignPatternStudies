using System;
using CommandPattern.Commands;
using CommandPattern.Invokers;
using CommandPattern.Receivers;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var tv = new Television();

            var controlTv = new TVControl(
                firstButton: new TurnTVOnCommand(tv),
                secondButton: new IncreaseVolumeCommand(tv),
                thirdButton: new DecreaseVolumeCommand(tv)
            );

            controlTv.OnFirstButtonPressed();

            controlTv.OnSecondButtonPressed();

            controlTv.OnThirdButtonPressed();
        }
    }
}
