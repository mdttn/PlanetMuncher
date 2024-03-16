using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DawHacks.Routines
{
    internal class Transport : Routine
    {
        internal override string CreateDescription() =>
@"You're now on your way to school.

How do you get there?
[1] Car
[2] Public transport
[3] Walking/biking
---";

        internal override void ReceiveChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("How long is the drive?");
                    try
                    {
                        Game.car = Convert.ToDouble(Console.ReadLine());
                        Game.emission += Game.car * 3.36;
                        Game.Transition<Lunch>();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    Console.WriteLine("How many km do you need to commute for?");
                    try
                    {
                        Game.stm = Convert.ToDouble(Console.ReadLine());
                        Game.emission += Game.stm * 0.049 * 2;
                        Game.Transition<Lunch>();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 3:
                    Game.Transition<Lunch>();
                    break;
                default:
                    // reset
                    break;
            }
        }
    }
}
