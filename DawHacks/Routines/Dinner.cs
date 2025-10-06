using DawHacks.Routines;

namespace DawHacks.Routines
{
    internal class Dinner : Routine
    {
        internal override string CreateDescription() =>
@"It's the evening and you're done washing yourself.

Are you eating dinner?
[1] Yes
[2] No
---";

        internal override void ReceiveChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    Game.emission += 1.5;
                    Game.Transition<Clothes>();
                    break;
                case 2:
                    Game.Transition<Clothes>();
                    break;
                default:
                    // reset
                    break;
            }
        }
    }
}
