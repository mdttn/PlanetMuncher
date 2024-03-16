using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DawHacks.Routines
{
    internal class Lights : Routine
    {
        internal override string CreateDescription() =>
@"You're about to leave the house.
There's a light switch next to the door.

Did you turn on the lights while getting ready?
[1] Yes
[2] No
---";

        internal override void ReceiveChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("How long did you keep them on for?");
                    try
                    {
                        Game.lights = Convert.ToDouble(Console.ReadLine());
                        Game.emission += Game.lights * 0.043;
                        Game.Transition<Transport>();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    Game.Transition<Transport>();
                    break;
                default:
                    // reset
                    break;
            }
        }
    }
}