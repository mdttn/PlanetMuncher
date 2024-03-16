namespace DawHacks.Routines
{
    internal class Breakfast : Routine
    {
        internal override string CreateDescription() =>
@"You go to the bathroom to brush your teeth.
Then, you go to the kitchen.

Did you eat your breakfast?
[1] Yes
[2] No
---";

        internal override void ReceiveChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    Game.emission += 1.5;
                    Game.Transition<Lights>();
                    break;
                case 2:
                    Game.Transition<Lights>();
                    break;
                default:
                    // reset
                    break;
            }
        }
    }
}