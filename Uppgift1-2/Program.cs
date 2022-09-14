using System;

namespace Uppgift1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hejsan");
            Console.WriteLine("Vilken är din favoritbok?");
            string bok = Console.ReadLine();
            Console.WriteLine("Din favoribok är: " + bok);
        }
    }
}
