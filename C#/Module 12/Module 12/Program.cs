using System;
using System.Collections.Generic;
using System.Linq;

namespace Module_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rockstarArray = CreateArrayOfRockstars();
            List<string> rockstarList = CreateListOfRockstars();

            DisplayArrayOfRockstars(rockstarArray);
            DisplayListOfRockstars(rockstarList);

            DisplayRockstars("My rockstars: (ienumerable)", rockstarArray);
            DisplayRockstars("My rockstars: (ienumerable)", rockstarList);
        }

        private static string[] CreateArrayOfRockstars()
        {
            string[] rockstarsArray = new string[] { "Jim Morrison", "Ozzy Osborne", "Pelle Roses" };
            return rockstarsArray;
        }
        private static List<string> CreateListOfRockstars()
        {
            List<string> rockstarList = new List<string> { "Jim Morrison", "Ozzy Osborne", "Pelle Roses" };
            return rockstarList;
        }

        private static void DisplayArrayOfRockstars(string[] rockstarArray)
        {
            Console.WriteLine("My rockstars: (array)");
            foreach (var item in rockstarArray)
            {
                Console.WriteLine($"* {item}");
            }
            Console.WriteLine();
        }

        private static void DisplayListOfRockstars(List<string> rockstarList)
        {
            Console.WriteLine("My rockstars: (list)");
            foreach (var item in rockstarList)
            {
                Console.WriteLine($"* {item}");
            }
            Console.WriteLine();
        }

        private static void DisplayRockstars(string s, IEnumerable<string> rockstars)
        {
            Console.WriteLine("My rockstars: (ienumerable)");
            foreach (var item in rockstars)
            {
                Console.WriteLine($"* {item}");
            }
            Console.WriteLine();
        }
    }
}
