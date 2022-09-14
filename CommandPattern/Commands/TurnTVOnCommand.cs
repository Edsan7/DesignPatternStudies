using CommandPattern.Receivers;

namespace CommandPattern.Commands
{
    public class TurnTVOnCommand : ICommand
    {
        public TurnTVOnCommand(Television televison)
        {
            Televison = televison;
        }

        public Television Televison { get; }

        public void Execute()
        {
            Televison.TurnOn();
        }

        public void Unexcecute()
        {
            Televison.TurnOff();
        }
    }
}