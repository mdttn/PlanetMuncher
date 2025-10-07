using DawHacks;
using DawHacks.Routines;
using System.Reflection.Emit;

var game = new Game();
game.Add(new Start());
game.Add(new Phone());
game.Add(new Breakfast());
game.Add(new Lights());
game.Add(new Transport());
game.Add(new Lunch());
game.Add(new Bathroom());
game.Add(new Dinner());
game.Add(new Shower());
game.Add(new Clothes());
game.Add(new Screentime());
game.Add(new Sleep());

while (!game.IsGameFinished() && !game.HasQuit())
{
Label:
    Console.Clear();
    Console.WriteLine(game.CurrentRoutineDescription);
    try
    {
        int choice = Convert.ToInt32(Console.ReadLine()?.ToLower() ?? "");
        game.ReceiveChoice(choice);
    }
    catch
    {
        goto Label;
    }
    Console.Clear();
}

if (game.IsGameFinished())
{
    Console.WriteLine("---");
    if (Game.emission < 20) // aprox.
    {
        Console.WriteLine($"Your carbon footprint is {Game.emission} kg/day.");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You are below average!");
        Console.ResetColor();
    }
    else if (Game.emission < 27.35) // approx.
    {
        Console.WriteLine($"Your carbon footprint is {Game.emission} kg/day.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("You are average!");
        Console.ResetColor();
    }
    else
    {
        Console.WriteLine($"Your carbon footprint is {Game.emission} kg/day.");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You are above average!");
        Console.ResetColor();
        Console.WriteLine("*plays sad horn sound*");
    }
}

else if (game.HasQuit())
{
    Console.WriteLine("---");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("EXIT");
    Console.ResetColor();
}

Console.ReadKey();