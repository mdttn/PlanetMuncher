using DawHacks.Routines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DawHacks.Routines
{
    internal class Shower : Routine
    {
        internal override string CreateDescription() =>
@"After your classes are over for the day, you go back home through the same means of transportation.

Now that you're back home, are you taking a shower or a bath?
[1] Shower
[2] Bath
---";

        internal override void ReceiveChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    int shower;
                label1:
                    Console.Clear();
                    Console.WriteLine("Are you taking a hot or cold shower?");
                    Console.WriteLine("[1] Hot");
                    Console.WriteLine("[2] Cold");
                    Console.WriteLine("---");
                    try
                    {
                        shower = Convert.ToInt32(Console.ReadLine());
                        if (shower == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("For how long are you running the water?");
                            try
                            {
                                Game.shower = Convert.ToDouble(Console.ReadLine());
                                Game.emission += Game.shower * 10.287;
                                Game.Transition<Dinner>();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                goto label1;
                            }
                        }
                        else if (shower == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("For how long are you running the water?");
                            try
                            {
                                Game.shower = Convert.ToDouble(Console.ReadLine());
                                Game.emission += Game.shower * 9;
                                Game.Transition<Dinner>();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                goto label1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                            goto label1;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    Game.emission += 2.57;
                    Game.Transition<Dinner>();
                    break;
                default:
                    // reset
                    break;
            }
        }
    }
}
