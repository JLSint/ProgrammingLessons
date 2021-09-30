using System;

namespace ProgrammingWeek3
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon sword = new Weapon("Sword", 0.15f);
            Weapon crossbow = new Weapon("Crossbow", 0.10f);

            Console.WriteLine($"Your sword has {sword.Damage} damage points.");
            Console.WriteLine($"Your crossbow has {crossbow.Damage} damage points");

            Player player1 = new Player("Harold");
            Player player2 = new Player("Osman");

            player1.PickupWeapon(sword);
            Console.WriteLine($"\nplayer 1 has {player1.ActiveWeapon.Name} as active weapon");

            player2.PickupWeapon(crossbow);
            player2.PickupWeapon(sword);
            Console.WriteLine($"\nplayer 2 has {player2.ActiveWeapon.Name} as active weapon");

            Console.WriteLine($"\nPlayer 1 inventory: ");
            player1.ShowInventory();
            Console.WriteLine($"\nPlayer 2 inventory: ");
            player2.ShowInventory();

            Console.WriteLine($"\nPlayer 1 has {player1.HP} hp.");
            player2.AttackOpponent(player1);
            Console.WriteLine($"{player2.Name} attacked {player1.Name}!");
            Console.WriteLine($"Player 1 has {player1.HP} hp.");
        }
    }
}
