namespace DawHacks.Routines
{
    internal class Phone : Routine
    {
        internal override string CreateDescription() =>
@"You wake up in the morning to get ready for school.
You check the time on your phone.

Did you charge your phone last night?
[1] Yes
[2] No
---";

        internal override void ReceiveChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("How long did you charge it for?");
                    try
                    {
                        Game.charging = Convert.ToDouble(Console.ReadLine());
                        Game.emission = Game.charging * 0.0025;
                        Game.Transition<Breakfast>();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    Console.WriteLine("How long are you going to charge it for in the morning?");
                    try
                    {
                        Game.charging = Convert.ToDouble(Console.ReadLine());
                        Game.emission = Game.charging * 0.0025;
                        Game.Transition<Breakfast>();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    // reset
                    break;
            }
        }
    }
}