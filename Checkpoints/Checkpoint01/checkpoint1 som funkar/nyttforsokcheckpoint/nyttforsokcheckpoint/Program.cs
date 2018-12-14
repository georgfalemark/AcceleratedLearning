using System;

namespace nyttforsokcheckpoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("write command: ");
            Console.ForegroundColor = ConsoleColor.Green;

            string z = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine();

            string[] theList = z.Split('-');

            foreach (var number in theList)
            {
            int n = int.Parse(number);
                for (int i = 1; i <= n; i++)
                {
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }

            Console.WriteLine();































            ////Nummer som börjar med B
            //foreach (var number in theList)
            //{
            //    int n = int.Parse(number);
            //    for (int i = 1; i <= n; i++)
            //    {
            //        for (int j = 1; j <= n - i; j++)
            //        {
            //            Console.Write("");
            //        }
            //            for (int k = 1; k <= n; k++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine("");

            //   }
            //}
        }
    }
}
