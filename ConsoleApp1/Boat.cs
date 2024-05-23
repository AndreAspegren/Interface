using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Boat : Ivehicles
    {
        public string brand { get; set; }
        public int registration { get; set; }
        public string color { get; set; }

        public Boat(string Brand, int Registration, string Colour)
        {
            brand = Brand;
            registration = Registration;
            color = Colour;
        }
        public void Run()
        {
            Console.WriteLine($"Dette er en {brand} båt");
        }
    }
}
