
using System;

namespace SquirrelTard
{
    class Program
    {
        static void Main(string[] args)
        {
            Grid grid = new Grid(10, 10);
            Food Acorn = new Food();
            Food Shroom = new Food();
            Squirrel Player = new Squirrel(grid, 0, 0);

            Random rnd = new Random();

            Acorn.foodHealthiness = 0.15f;
            Acorn.foodName = "Acorn";
            Acorn.xPosFood = rnd.Next(1, 10);
            Acorn.yPosFood = rnd.Next(1, 10);

            Shroom.foodHealthiness = -0.20f;
            Shroom.foodName = "Shroom";
            Shroom.xPosFood = rnd.Next(1, 10);
            Shroom.yPosFood = rnd.Next(1, 10);

            grid.foodInGrid.Add(Acorn);
            grid.foodInGrid.Add(Shroom);

            Console.WriteLine($"Hey, you are at {Player.squirrelHeatlh} hp.");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Acorn at x position of {Acorn.xPosFood} and y position of {Acorn.yPosFood}.");
            Console.WriteLine($"Shroom at x position of {Shroom.xPosFood} and y position of {Shroom.yPosFood}.");
            Console.ResetColor();
            Console.WriteLine($"\nWhere do you want to go?");
            Console.WriteLine($"x position: ");
            int moveToX = int.Parse(Console.ReadLine());
            Console.WriteLine($"y position: ");
            int moveToY = int.Parse(Console.ReadLine());
            Player.SquirrelMove(moveToX, moveToY);
            if(Player.squirrelPosX == Acorn.xPosFood && Player.squirrelPosY == Acorn.yPosFood)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nYou ate an {Acorn.foodName}.");
                Console.ResetColor();
            } else if (Player.squirrelPosX == Shroom.xPosFood && Player.squirrelPosY == Shroom.yPosFood)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nYou ate a {Shroom.foodName}!");
                Console.ResetColor();
            }
            
            Console.WriteLine($"\nYou are at {Player.squirrelHeatlh} hp.");
        }
    }
}
