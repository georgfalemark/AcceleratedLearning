using System;

namespace checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {

            //DisplayTriangle();

            TriangleTestApp();

            //TriangleTestAppTwo();

            //TestApp();

            //TestTest();
   



        }

        private static void TestTest()
        {


            Console.WriteLine("hej ");


            int number = 5;

            for (int i = number; i >= 1; i -= 2)
            {
                string spaces = new String(' ', (number - i) / 2);
                Console.WriteLine(spaces + new String('*', i) + spaces);
            }










        }




















        private static void TestApp()
        {


            Console.Write("Enter something: ");
            string input = Console.ReadLine();
            string[] inputArray = input.Split('-');





            foreach (string item in inputArray)
            {
                Console.WriteLine(item);
            }


            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= input - i; j++)
                {
                    Console.Write("");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("0");
                }
                Console.WriteLine("");
            }
            Console.WriteLine();

























        }

        private static void TriangleTestAppTwo()
        {
            //Console.Write("Write command: ");
            //string values = Console.ReadLine();
            //int newvalues = int.Parse(values);
            //string[] brokenvalues = values.Split('-');

            //Console.Write("Enter please!!!!:  ");
            //Console.WriteLine();

            //string z = Console.ReadLine();


            //z = Convert.ToInt32());
            //string[] sdfse = z.Split(',');

            //rows = Convert.ToInt32(Console.ReadLine());




            string z = Console.ReadLine();
            string[] newnewz = z.Split('-');


            int newz = 14;


            foreach (string item in newnewz)
            {
                Console.WriteLine(item);
            }



            for (int i = 1; i <= newz; i++)
            {
                for (int j = 1; j <= newz - i; j++)
                {
                    Console.Write("");
                }
                    for (int k = 1; k <= i; k++)
                {
                        Console.Write("0");
                }
                    Console.WriteLine("");
            }
            Console.WriteLine();



          




        }






        private static void TriangleTestApp()
        {




            Console.Write("Write command: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string values = Console.ReadLine();
            string[] tokens = values.Split('-');
            int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);
            Console.ForegroundColor = ConsoleColor.White;

            int newconvertedItems = Convert.ToInt32(convertedItems);

            foreach (int z in convertedItems)
            {
                for (int i = 1; i <= z; i++)
                {
                    for (int j = 1; j <= z - i; j++)
                    {
                        Console.Write("");
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("0");
                    }
                    Console.WriteLine("");
                }
            }

            






        }

        private static void DisplayTriangle()
        {
            Console.Write("Write command: ");
            int z = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= z; i++)
            {
                for (int j = 1; j <= z-i; j++)
                {
                    Console.Write("");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("0");
                }
                Console.WriteLine("");
            }



            Console.Write("Write your next command please: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int y = x;
            for (int row = 0; row < y; row++)
            {
                for (int column = 0; column < x; column++)
                {
                    Console.Write("0");
                }

                Console.WriteLine();
                x--;

            }
        }
    }
}

