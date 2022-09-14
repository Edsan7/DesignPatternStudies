using CommandPattern.Receivers;

namespace CommandPattern.Commands
{
    public class DecreaseVolumeCommand : ICommand
    {
        public DecreaseVolumeCommand(Television television)
        {

            Television = television;
        }

        public Television Television { get; }

        public void Execute()
        {
            Television.DecreaseVolume();
        }

        public void Unexcecute()
        {
            Television.IncreaseVolume();
        }
    }
}