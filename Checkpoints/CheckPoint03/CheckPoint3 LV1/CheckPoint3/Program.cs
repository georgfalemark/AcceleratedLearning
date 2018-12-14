using System;
using System.Collections.Generic;

namespace CheckPoint3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int> { 2, 8, 3, 11 };

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Listan".ToUpper());
            Console.ResetColor();

            //Om vi hade väldigt många tal hade en foreach loop varit mer fördelaktig för utskriften
            Console.WriteLine($"{myList[0]},{myList[1]},{myList[2]},{myList[3]}");
            Console.WriteLine();

            //Metoden tar in "myList" som parameter och returnerar en lista som benämns som "resultat"
            List<int> result = MultiplyBy100AndAdd3(myList);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Multiplicera med 100 och lägg till tre".ToUpper());
            Console.ResetColor();

            //Om vi hade väldigt många tal hade en foreach loop varit mer fördelaktig för utskriften
            Console.WriteLine($"{result[0]},{result[1]},{result[2]},{result[3]}");
            Console.WriteLine();
        }

        private static List<int> MultiplyBy100AndAdd3(List<int> myList)
        {
            var result = new List<int>();
            foreach (var number in myList)
            {
                result.Add(number * 100 + 3);
            }          
            return result;
        }
    }
}
