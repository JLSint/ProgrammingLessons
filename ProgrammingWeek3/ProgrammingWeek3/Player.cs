using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ProgrammingWeek3
{
    class Player
    {
        public string Name;
        public float HP;
        public List<Weapon> Inventory;
        public Weapon ActiveWeapon;

        public Player(string name)
        {
            Name = name;
            HP = 1.00f;
            Inventory = new List<Weapon>();
        }

        public void PickupWeapon(Weapon weapon)
        {
            Inventory.Add(weapon);
            ActiveWeapon = weapon;
        }

        public void ShowInventory()
        {
            foreach(Weapon weapon in Inventory)
            {
                Console.WriteLine(weapon.Name);
            }
        }

        public void AttackOpponent(Player opponent)
        {
            if (ActiveWeapon != null)
            {
                Console.WriteLine($"{Name} is attacking {opponent} with the {ActiveWeapon.Name} with a damage output of {ActiveWeapon.Damage}");
                opponent.HP = opponent.HP - ActiveWeapon.Damage;
            }
        }
    }
}
