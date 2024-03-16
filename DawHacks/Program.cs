using DawHacks;
using DawHacks.Routines;

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
game.Add(new Lights2());

while (!game.IsGameFinished())
{
    Console.Clear();
    Console.WriteLine(game.CurrentRoutineDescription);
    int choice = Convert.ToInt32(Console.ReadLine()?.ToLower() ?? "");
    Console.Clear();
    game.ReceiveChoice(choice);
}

if (game.IsGameFinished())
{
    Console.WriteLine("---");
    if (Game.emission <= 19.883)
    {
        Console.WriteLine($"Your carbon footprint is {Game.emission} kg/day.");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You are below average!");
        Console.ResetColor();
    }
    else if (Game.emission >= 19.883 && Game.emission <= 27.34)
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

Console.ReadKey();