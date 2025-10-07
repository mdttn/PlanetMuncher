using DawHacks.Routines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DawHacks.Routines
{
    internal class Sleep : Routine
    {
        internal override string CreateDescription() =>
@"You're (finally) about to go to sleep!

Don't forget to turn off the lights.
[1] Ok
---";

        internal override void ReceiveChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("For how long did you keep them on after getting back home?");
                    try
                    {
                        Game.lights2 = Convert.ToDouble(Console.ReadLine());
                        Game.emission += Game.lights2 * 0.043;
                        Game.Finish();
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
