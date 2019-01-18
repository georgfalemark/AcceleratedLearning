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
            AddRavioliForSpaceship("Millennium Falcon", 1, "2017-01-01");
            AddRavioliForSpaceship("Millennium Falcon", 2, "2018-01-01");
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

        private static void AddRavioliForSpaceship(string v1, int v2, string v3)
        {
            var dataAccess = new DataAccess();
            dataAccess.AddRavioliForSpaceships(v1, v2, v3);
        }

        private static void AddSpaceship(string v)
        {
            var dataAccess = new DataAccess();
            dataAccess.AddSpaceships(v);
        }

        private static List<SpaceShip> GetAllSpaceships()
        {
            var dataAccess = new DataAccess();
            return dataAccess.GetAllSpaceships();
        }

        private static void DisplaySpaceships(List<SpaceShip> list)
        {
            foreach (var spaceship in list)
            {
                Console.WriteLine(spaceship.Name.PadRight(15));
                //DateTime packDate = DateTime.Parse(spaceship.PackDate);
                //Console.WriteLine($"PACKDATUM:      {packDate}");

                //DateTime bestFore = new DateTime(0000, 6, 15);
                //DateTime result = new DateTime(packDate.Ticks + bestFore.Ticks);
                //Console.WriteLine($"BÄSTFÖREDATUM         {result}");
            }
        }
    }
}
