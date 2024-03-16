namespace DawHacks.Routines
{
    internal class Clothes : Routine
    {
        internal override string CreateDescription() =>
@"You have some dirty clothes sitting in a bin, but you also have a clean wardrobe ready.

Are you washing and drying your clothes today?
[1] Yes
[2] No
---";

        internal override void ReceiveChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("How long are both the washing and drying machines going to take together?");
                    try
                    {
                        Game.clothes = Convert.ToDouble(Console.ReadLine());
                        Game.emission += Game.clothes * 1.275;
                        Game.Transition<Bathroom>();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    Game.Transition<Bathroom>();
                    break;
                default:
                    // reset
                    break;
            }
        }
    }
}
