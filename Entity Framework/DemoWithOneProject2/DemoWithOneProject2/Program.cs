using System;
using System.Collections.Generic;

namespace DemoWithOneProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClearAndInitDatabase();
            DisplayAllFruits();
            DisplayByCategory();
            DisplayBaskets();

        }


        private static void ClearAndInitDatabase()
        {
            var dataAccess = new DataAccess();
            dataAccess.ClearDatabase();
            dataAccess.AddCategoriesAndFruits();
        }

        private static void DisplayAllFruits()
        {
            var dataAccess = new DataAccess();
            foreach (Fruit fruit in dataAccess.GetAll()) // Include
            {
                Console.WriteLine($"{fruit.Id.ToString().PadRight(15)}{fruit.Name.PadRight(25)}{fruit.Price.ToString().PadRight(20)}{fruit.Category.Name.PadRight(15)}");
            }
        }

        private static void DisplayByCategory()
        {
            var dataAccess = new DataAccess();
            string x = "bär";
            List<Fruit> list = dataAccess.GetFruitsByCategory(x);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("BÄR");
            Console.WriteLine();

            foreach (var fruit in list)
            {
                Console.WriteLine($"{fruit.Name}");
            }
        }

        private static void DisplayBaskets()
        {
            var dataAccess = new DataAccess();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Hämtar först alla korgar från databasen
            foreach (var basket in dataAccess.GetAllBaskets())
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(basket.Name);
                Console.WriteLine("_____________________");

                //Hämtar sedan frukterna för RESP korg
                foreach (var fib in dataAccess.GetAllFruitsInBaskets(basket.Id))
                {
                    Console.WriteLine(fib.Fruit.Name);
                }
            }
        }
    }
}
