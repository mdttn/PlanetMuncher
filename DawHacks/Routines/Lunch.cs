using DawHacks.Routines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DawHacks.Routines
{
    internal class Lunch : Routine
    {
        internal override string CreateDescription() =>
@"After long hours of listening and/or boredom in class, it's finally lunch time.

Are you eating lunch?
[1] Yes
[2] No
---";

        internal override void ReceiveChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    Game.emission += 1.5;
                    Game.Transition<Shower>();
                    break;
                case 2:
                    Game.Transition<Shower>();
                    break;
                default:
                    // reset
                    break;
            }
        }
    }
}
