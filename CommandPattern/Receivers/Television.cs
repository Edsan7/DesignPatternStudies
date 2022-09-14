namespace CommandPattern.Receivers
{
    public class Television
    {
        public bool IsOn { private get; set; }

        public int CurrentVolume { private get; set; } = 5;

        public int MaxVolume { private get; init; } = 10;

        public void TurnOn()
        {
            if (!IsOn)
            {
                IsOn = true;
                System.Console.WriteLine("Television turned on");
                return;
            }

            System.Console.WriteLine("Television is already on");

        }

        public void TurnOff()
        {
            IsOn = false;
        }

        public void IncreaseVolume()
        {
            if (CurrentVolume == MaxVolume)
            {
                System.Console.WriteLine("Max volume reached");
                return;
            }

            CurrentVolume++;

            System.Console.WriteLine($"TV volume set to: {CurrentVolume}");
        }

        public void DecreaseVolume()
        {
            if (CurrentVolume == 0)
            {
                System.Console.WriteLine("Min volume reached");
                return;
            }

            CurrentVolume--;
            System.Console.WriteLine($"TV volume set to: {CurrentVolume}");
        }


    }
}