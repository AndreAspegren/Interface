using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        public static void Main()
        {
            new App().Run();
        }
    }

    class App
    {
        public void Run()
        {
            var vehicles = new List<Ivehicles>
            {
                new Car("Toyota", 123456, "Red"),
                new Motorcycle("Harley", 222, "Black"),
                new Motorcycle("Vroom", 3423423, "Pink"),
                new Boat("Yamaha", 987654, "White"),
            };

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.brand}");
                Console.WriteLine($"{vehicle.registration}");
                Console.WriteLine($"{vehicle.color}");
                vehicle.Run();
                Console.WriteLine("");
            }
        }
    }
}