using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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

        private static Dictionary<int, string> BuildProductDictionary()
        {

            Dictionary<int, string> products = new Dictionary<int, string>();

            while (true)
            {
                Console.Write("Enter product id and name: ");

                Console.ForegroundColor = ConsoleColor.Green;
                string row = Console.ReadLine();
                Console.ResetColor();

                if (string.IsNullOrWhiteSpace(row))
                {
                    return products;
                }

                String[] xxx = row.Split(',');

                if (xxx.Length != 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Invalid input, gör om gör rätt");
                    Console.ResetColor();
                    continue;
                }
                if (!Regex.IsMatch(xxx[1], @"^[a-zA-Z]+$"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Invalid input, gör om gör rätt");
                    Console.ResetColor();
                    continue;
                }

                if (!Regex.IsMatch(xxx[0], @"^[0-9]+$"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Invalid input, gör om gör rätt");
                    Console.ResetColor();
                    continue;
                }

                int productid = int.Parse(xxx[0]);

                string name = xxx[1];





                if (products.ContainsKey(productid))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The product list already contains the id {productid}");
                    Console.ResetColor();
                    continue;
                }

                //if (products.ContainsValue(name))
                //{
                //    Console.ForegroundColor = ConsoleColor.Red;
                //    Console.WriteLine($"The product list already contains the id {name}");
                //    continue;
                //}

                products.Add(productid, name);




            }
        }

        private static void DisplayProductDictionary(Dictionary<int, string> products)
        {
            foreach (var item in products)
            {
                Console.WriteLine($"Product id = {item.Key} and name = {item.Value}");
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
