using CommandPattern.Commands;

namespace CommandPattern.Invokers
{
    public class TVControl
    {
        public ICommand FirstButton { get; set; }
        public ICommand SecondButton { get; set; }
        public ICommand ThirdButton { get; set; }

        public TVControl(
            ICommand firstButton,
            ICommand secondButton,
            ICommand thirdButton
        )
        {
            FirstButton = firstButton;
            SecondButton = secondButton;
            ThirdButton = thirdButton;
        }

        public void OnFirstButtonPressed()
        {
            FirstButton.Execute();
        }

        public void OnSecondButtonPressed()
        {
            SecondButton.Execute();
        }

        public void OnThirdButtonPressed()
        {
            ThirdButton.Execute();
        }
    }
}