using System;

namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Drive(car.Kilometers);

            car.AddFuel(car.Liters);
        }
    }
}
