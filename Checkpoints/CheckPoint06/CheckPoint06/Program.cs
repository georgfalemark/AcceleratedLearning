using System;
using System.Collections.Generic;

namespace CheckPoint06
{
    class Program
    {
        static void Main(string[] args)
        {
            RecreateDatabase();

            AddSpaceship("USS Enterprise");
            AddSpaceship("Millenium Falcon");
            AddSpaceship("Cylon Raider");

            AddRavioliForSpaceship("Cylon Raider", 1, "2018-04-19");
            AddRavioliForSpaceship("Millenium Falcon", 1, "2017-01-01");
            AddRavioliForSpaceship("Millenium Falcon", 2, "2018-01-01");
            AddRavioliForSpaceship("Nalle Puh", 99, "1950-01-01");

            List<SpaceShip> list = GetAllSpaceships();
            DisplaySpaceships(list);
        }

        private static void RecreateDatabase()
        {
            using (var context = new SpaceShipContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }

        private static void AddSpaceship(string v)
        {
            var dataAccess = new DataAccess();
            dataAccess.AddSpaceships(v);
        }

        private static void AddRavioliForSpaceship(string v1, int v2, string v3)
        {
            var dataAccess = new DataAccess();
            dataAccess.AddRavioliForSpaceships(v1, v2, v3);
        }

        private static List<SpaceShip> GetAllSpaceships()
        {
            var dataAccess = new DataAccess();
            return dataAccess.GetAllSpaceships();
        }

        private static void DisplaySpaceships(List<SpaceShip> list)
        {
            var dataAccess = new DataAccess();

            foreach (var spaceship in list)
            {
                Console.WriteLine(spaceship.Name.PadRight(15));
                if (spaceship.raviolis.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Slut på ravioli :( ");
                    Console.ResetColor();
                }

                foreach (var ravioli in spaceship.raviolis)
                {
                    DateTime packingDate = DateTime.Parse(ravioli.PackDate);
                    DateTime bestFore = packingDate.AddYears(0).AddMonths(6).AddDays(15);

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("RAVIOLI".PadRight(15) + "Packdatum: " + ravioli.PackDate.ToString().PadRight(20) + "Bästföre: " + bestFore.ToString().PadRight(20));
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}
