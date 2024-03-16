using DawHacks.Routines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DawHacks.Routines
{
    internal class Start : Routine
    {
        internal override string CreateDescription()
        {
            Console.Clear();
            return
@"██████╗ ██╗      █████╗ ███╗   ██╗███████╗████████╗    ███╗   ███╗██╗   ██╗███╗   ██╗ ██████╗██╗  ██╗███████╗██████╗ 
██╔══██╗██║     ██╔══██╗████╗  ██║██╔════╝╚══██╔══╝    ████╗ ████║██║   ██║████╗  ██║██╔════╝██║  ██║██╔════╝██╔══██╗
██████╔╝██║     ███████║██╔██╗ ██║█████╗     ██║       ██╔████╔██║██║   ██║██╔██╗ ██║██║     ███████║█████╗  ██████╔╝
██╔═══╝ ██║     ██╔══██║██║╚██╗██║██╔══╝     ██║       ██║╚██╔╝██║██║   ██║██║╚██╗██║██║     ██╔══██║██╔══╝  ██╔══██╗
██║     ███████╗██║  ██║██║ ╚████║███████╗   ██║       ██║ ╚═╝ ██║╚██████╔╝██║ ╚████║╚██████╗██║  ██║███████╗██║  ██║
╚═╝     ╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝╚══════╝   ╚═╝       ╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═══╝ ╚═════╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝

Where do you stand on the scale of carbon footprint? START to find out!

> INSTRUCTIONS: Type out one of the options given in brackets + ENTER.
> NOTES: You can type decimal numbers (e.g.: 4.5).
         The time is calculated in HOURS.

[1] Start
[2] Quit
---";
        }

        internal override void ReceiveChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    Game.Transition<Phone>();
                    break;
                case 2:
                    Console.WriteLine("Click twice to quit.");
                    Game.Quit();
                    break;
                default:
                    // reset
                    break;
            }
        }
    }
}
