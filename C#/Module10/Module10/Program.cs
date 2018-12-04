using System;
using System.Collections.Generic;

namespace Module10
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListTestApp();








            Dictionary<int, string> products = BuildProductDictionary();

            DisplayProductDictionary(products);
















        }

        private static void DisplayProductDictionary(Dictionary<int, string> products)
        {
            









        }

        private static Dictionary<int, string> BuildProductDictionary()
        {

            Dictionary<int, string> products = new Dictionary<int, string>();


            while (true)
            {

                Console.Write("Enter product id and name: ");

                string row = Console.ReadLine();

                if (row == null)
                {
                    break;
                }

                String[] xxx = row.Split(',');

                int productid = int.Parse(xxx[0]);

                string name = xxx[1];

                products.Add(productid, name);


                

                return xxx;

            }








        }
        








        private static void ListTestApp()
        {

            List<string> names = new List<string>();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter a name: ");

                Console.ForegroundColor = ConsoleColor.Green;
                string name = Console.ReadLine();
                names.Add(name);

                if (name == "QUIT")
                {
                    break;
                }
            }

            names.Sort();
            names.RemoveAt(0);
            names.Remove("QUIT");
            names.RemoveAt(names.Count - 1);


            foreach (string name in names)
            {
                Console.WriteLine($"Name: {name}");
            }



            //List<int> listOfNumbers = new List<int>();

            //while (true)
            //{
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.Write("Enter a number: ");

            //    Console.ForegroundColor = ConsoleColor.Green;
            //    string number = Console.ReadLine();
            //    int newnumber = int.Parse(number);
            //    listOfNumbers.Add(newnumber);

            //    if (number == "QUIT")
            //    {
            //        break;
            //    }
            //}

            //listOfNumbers.Remove("QUIT");


















        }
    }
}
