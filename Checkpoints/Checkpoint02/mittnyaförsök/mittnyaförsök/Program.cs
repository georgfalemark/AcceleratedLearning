using System;
using System.Collections.Generic;

namespace mittnyaförsök
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Room> Rooms = new List<Room>();

            Console.WriteLine();
            Console.WriteLine("________________________________________");
            Console.WriteLine();

            Console.WriteLine("Ange namn på rum: ");
            string input = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            string[] FirstSplit = input.Split(" | ");

            foreach (var item in FirstSplit)
            {
                string[] SecondSplit = item.Split(" ");
                SecondSplit[1] = SecondSplit[1].Replace("m2", "");
                int newsize = int.Parse(SecondSplit[1]);

                var r = new Room();
                r.size = newsize;
                r.name = SecondSplit[0];

                Rooms.Add(r);
            }

            int maxSize = int.MinValue;
            string theName = "";
            int counter = 1;

            foreach (Room room in Rooms)
            {
                Console.WriteLine($"* Rumnamn {counter}: {room.name}");

                if (room.size > maxSize)
                {
                    maxSize = room.size;
                    theName = room.name;
                }
                counter++;
            }
            Console.WriteLine($"Det största rummet är {theName} på {maxSize} m2");
        }
    }
}
