using DawHacks.Routines;

namespace DawHacks.Routines
{
    internal class Screentime : Routine
    {
        internal override string CreateDescription() =>
@"You just finished brushing your teeth for the night.

Did you use your phone today?
[1] Yes
[2] No
---";

        internal override void ReceiveChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("What was your screentime?");
                    try
                    {
                        Game.screentime = Convert.ToDouble(Console.ReadLine());
                        Game.emission += Game.screentime * 0.05815 + 0.85;
                        Game.Transition<Sleep>();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    Game.emission += 0.85;
                    Game.Transition<Sleep>();
                    break;
                default:
                    // reset
                    break;
            }
        }
    }
}
