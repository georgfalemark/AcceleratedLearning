using System;

namespace TestCheckPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            //MultiplicationTable(3);

            //DrawSquare(3);
            //DrawSquare(7);
            //DrawSquare(5);

            //ListWithSplitApp();

            //ZumApp();

            //TimesToRepeatApp();

            //ColumnsAndRowsApp();

        }

        private static void ColumnsAndRowsApp()
        {
            Console.Write("Rows: ");
            string rows = Console.ReadLine();
            int newrows = int.Parse(rows);

            Console.Write("Columns: ");
            string columns = Console.ReadLine();
            int newcolumns = int.Parse(columns);

            string name = "Georg";

            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < newrows; i++)
            {
                for (int j = 0; j < newcolumns; j++)
                {
                    Console.Write($" {name} ");
                }
                Console.WriteLine();
            }
        }

        private static void TimesToRepeatApp()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Times to repeat: ");
            string timesToRepeat = Console.ReadLine();
            int newtimesToRepeat = int.Parse(timesToRepeat);

            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < newtimesToRepeat; i++)
            {
                Console.WriteLine($"Your name is {name}");
            }
        }

        private static void ZumApp()
        {
            Console.Write("Enter number one: ");
            string numberone = Console.ReadLine();
            int newnumberone = int.Parse(numberone);

            Console.Write("Enter number two: ");
            string numbertwo = Console.ReadLine();
            int newnumbertwo = int.Parse(numbertwo);

            int zum = newnumberone + newnumbertwo;

            Console.WriteLine($"The zum is {zum}");
        }

        private static void ListWithSplitApp()
        {
            Console.Write("Enter names in a list (like Maria, Elsa, Peter): ");
            string names = Console.ReadLine();
            string[] nameList = names.Split(',');

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (string name in nameList)
            {
                Console.WriteLine($"{name} Andersson");
            }

            Console.WriteLine();
        }

        private static void DrawSquare(int z)
        {        
            for (int x = 0; x < z; x++)
            {
                for (int y = 0; y < z; y++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void MultiplicationTable(int z)
        {
            for (int x = 1; x <= z; x++)
            {
                Console.WriteLine($"Multiplication table for: {x}");
                Console.WriteLine();
                for (int y = 1; y <= 10; y++)
                {
                    int zum = x * y;
                    Console.WriteLine($"{x}*{y} = {zum} ");
                }
                Console.WriteLine();
            }
        }
    }
}
