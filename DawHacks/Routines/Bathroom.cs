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
@"After eating and drinking during the day, you must have gone to the bathroom.

Did you use any toilet paper today?
[1] Yes
[2] No
---";

        internal override void ReceiveChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("How many plies of toilet paper did you use?");
                    try
                    {
                        Game.toilet = Convert.ToDouble(Console.ReadLine());
                        Game.emission =+ Game.toilet * 0.65;
                        Game.Transition<Screentime>();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    Game.Transition<Screentime>();
                    break;
                default:
                    // reset
                    break;
            }
        }
    }
}
