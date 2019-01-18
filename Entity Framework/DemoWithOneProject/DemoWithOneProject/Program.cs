using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoWithOneProject
{
    class Program
    {
        static void Main(string[] args)
        {
            FruitContext context = new FruitContext();

            //context.Database.EnsureCreated();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            //INSERT
            var f1 = new Fruit
            {
                name = "Äpple",
                color = "lila"
            };
            context.Fruits.Add(f1);
            context.SaveChanges();



            //SELECT
            foreach (var fruit in context.Fruits)
            {
                Console.WriteLine(fruit.fruitId.ToString().PadRight(10) + fruit.name.PadRight(15) + fruit.color.PadRight(10));
            }



        }
    }
}
