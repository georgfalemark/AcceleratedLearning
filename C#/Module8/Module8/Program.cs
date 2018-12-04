using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Module8
{
    class Program
    {
        static void Main(string[] args)
        {

            //ChocolateException();

            //FileException();


            Run();


        }





        private static void Run()
        {

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter a list of animals: ");

                try
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    string animal = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.White;
                    var animallist = ParseAnimals(animal);
                    Console.WriteLine($"There are {animallist.Length} animals in the list");
                    return;

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static string[] ParseAnimals(string animalsString)
        {
            string[] animallist = animalsString.Split(',');

            //IF satser, kommer kopplas tillbaka

            if (string.IsNullOrWhiteSpace(animalsString))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new ArgumentException("The animal list don't contain any letters");
            }


            foreach (string animal in animallist)
            {
                if (animal.Length > 20)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new ArgumentException($"The animal: {animal} has to many letters");
                }
                if (animal.Length == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new ArgumentException($"One of the animals didn't contain any letter");
                }
                if (!Regex.IsMatch(animal, @"^[a-zA-ZåäöÅÄÖ]+$"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new ArgumentException($"Animal: {animal} contains invalid letters");
                }
            }     
            return animallist;
        }













        private static void ChocolateException()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                decimal chocolateBarPieces = 24M;

                Console.WriteLine($"The chocolate contains {chocolateBarPieces} pieces");
                Console.Write("How many want to share? ");

                Console.ForegroundColor = ConsoleColor.Green;
                decimal numberOfPerson = decimal.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;

                decimal numberOfPieces = chocolateBarPieces / numberOfPerson;
                Console.WriteLine($"Everyone get {numberOfPieces} pieces of chocolate");
            }


            catch (DivideByZeroException)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zero people can't divide a chocolate");
                Console.ForegroundColor = ConsoleColor.White;
            }


            catch (Exception)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Needs to be a number");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private static void FileException()
        {

            while (true)
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter a file name: ");


                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    string filename = Console.ReadLine();
                    File.CreateText(filename);

                    Console.WriteLine($"The file {filename} is now created");
                    break;
                }

                catch (UnauthorizedAccessException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You're not authorized to create this file");
                }

                catch (IOException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input output exception");
                }

                //catch (DirectoryNotFoundException)
                //{
                //    Console.ForegroundColor = ConsoleColor.Red;
                //    Console.WriteLine("Dictoinary ");
                //}

                //catch (ArgumentException)
                //{
                //    Console.ForegroundColor = ConsoleColor.Red;
                //    Console.WriteLine("The filename is not valid");
                //}

                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Oops something went wrong");
                }
            }

























        }
    }
}
