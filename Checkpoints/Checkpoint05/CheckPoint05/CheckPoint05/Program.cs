using System;
using System.Collections.Generic;

namespace CheckPoint05
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataAccess = new DataAccess();
            List<Gnome> gnomes = dataAccess.GetGnomesFromDatabase();
            DisplayGnomes(gnomes);

        }

        public static void DisplayGnomes(List<Gnome> gnomes)
        {
            Console.WriteLine("ID".PadRight(10) + "Name");
            Console.WriteLine();
            foreach (Gnome gnome in gnomes)
                Console.WriteLine($"{gnome.gnomeID.ToString().PadRight(10)}{gnome.name}");

            Console.WriteLine();

            string ja = "Ja";
            string nej = "Nej";
            Console.WriteLine("ID".PadRight(10) + "Name".PadRight(10) + "HAR SKÄGG".PadRight(15) + "ÄR OND".PadRight(13) + "TEMPERAMENT".PadRight(15) + "RAS");
            Console.WriteLine();
            foreach (Gnome gnome in gnomes)
            {
                if (gnome.beard == true && gnome.godOrEvil == true)
                {
                    Console.WriteLine($"{gnome.gnomeID.ToString().PadRight(10)}{gnome.name.PadRight(10)}{ja.PadRight(15)}{ja.PadRight(13)}{gnome.angerLevel.ToString().PadRight(15)}{gnome.ras}");
                }
                if (gnome.beard == true && gnome.godOrEvil == false)
                {
                    Console.WriteLine($"{gnome.gnomeID.ToString().PadRight(10)}{gnome.name.PadRight(10)}{ja.PadRight(15)}{nej.PadRight(13)}{gnome.angerLevel.ToString().PadRight(15)}{gnome.ras}");
                }
                if (gnome.beard == false && gnome.godOrEvil == false)
                {
                    Console.WriteLine($"{gnome.gnomeID.ToString().PadRight(10)}{gnome.name.PadRight(10)}{nej.PadRight(15)}{nej.PadRight(13)}{gnome.angerLevel.ToString().PadRight(15)}{gnome.ras}");
                }
                if (gnome.beard == false && gnome.godOrEvil == true)
                {
                    Console.WriteLine($"{gnome.gnomeID.ToString().PadRight(10)}{gnome.name.PadRight(10)}{nej.PadRight(15)}{ja.PadRight(13)}{gnome.angerLevel.ToString().PadRight(15)}{gnome.ras}");
                }
            }
        }
    }
}
