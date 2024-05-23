using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Motorcycle : Ivehicles
    {
        public string brand { get; set; }
        public int registration { get; set; }
        public string color { get; set; }

        public Motorcycle(string Brand, int Registration, string Colour)
        {
            brand = Brand;
            registration = Registration;
            color = Colour;
        }
        public void Run()
        {
            Console.WriteLine($"Dette er en {brand} motorsykkel");
        }
    }
}
