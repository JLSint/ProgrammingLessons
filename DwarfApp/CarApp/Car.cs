using System;
using System.Collections.Generic;
using System.Text;

namespace CarApp
{
    class Car
    {
        public double Fuel = 40;
        public double Kilometers = 240;
        public double Liters = 12;
        public void Drive(double x)
        {
            Console.WriteLine($"Your fuel tank is at {Fuel} liters.");
            Fuel = Fuel - 0.05 * x;
            Console.WriteLine($"You drove {Kilometers} kilometers.");
        }
        public void AddFuel(double x)
        {
            Console.WriteLine($"\nOh no, you have {Fuel} liters of fuel left.");
            Console.WriteLine($"Time to tank!");
            Fuel = Fuel + x;
            Console.WriteLine($"\nYou added {Liters} liters of fuel to your tank.");
            Console.WriteLine($"Your tank is now at {Fuel} liters of fuel");
        }
    }
}
