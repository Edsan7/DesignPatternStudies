using CommandPattern.Receivers;

namespace CommandPattern.Commands
{
    public class IncreaseVolumeCommand : ICommand
    {
        public IncreaseVolumeCommand(Television television)
        {

            Television = television;
        }

        public Television Television { get; }

        public void Execute()
        {
            Television.IncreaseVolume();
        }

        public void Unexcecute()
        {
            Television.DecreaseVolume();
        }
    }
}