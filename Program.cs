using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Corolla");
            Showroom.Add("Malibu");
            Showroom.Add("Accord");
            Showroom.Add("Sonata");

            foreach (string car in Showroom) 
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("Number of cars in Showroom: {0}", Showroom.Count);
            HashSet<string> UsedLot = new HashSet<string>();

            UsedLot.Add("Cherokee");
            UsedLot.Add("Sentra");

            Showroom.UnionWith(UsedLot);

            Showroom.Remove("Sentra");
            Console.WriteLine("A car was sold - new Showroom");

            foreach (string car in Showroom) 
            {
                Console.WriteLine(car);
            }

            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Corolla");
            Junkyard.Add("Cherokee");
            Junkyard.Add("Rouge");

            // Junkyard.IntersectWith(Showroom);
            // Console.WriteLine("---------------------");
            // Console.WriteLine("These are cars are in the Junkyard AND the showroom");

            // foreach (string junk in Junkyard) 
            // {
            //     Console.WriteLine(junk);
            // }

            Console.WriteLine("--------------------");
            Console.WriteLine("New Showroom");
            Showroom.UnionWith(Junkyard);
            foreach (string car in Showroom) 
            {
                Console.WriteLine(car);
            }

            Showroom.Remove("Rouge");

        }
    }
}
