using DawHacks.Routines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DawHacks.Routines
{
    internal class Bathroom : Routine
    {
        internal override string CreateDescription() =>
@"After eating and drinking during the day, you must have gone to the bathroom at least once.
[1] Ok
---";

        internal override void ReceiveChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("How many plies of toilet paper did you use? (> 0)");
                    try
                    {
                        Game.toilet = Convert.ToDouble(Console.ReadLine());
                        if (Game.toilet > 0)
                        {
                            Game.emission += Game.toilet * 0.65;
                            Game.Transition<Screentime>();
                        }
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
