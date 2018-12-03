using System;

namespace Module2
{
    class Program
    {
        public static void Main(string[] args)
        {
            WhatIsYourName();
        }

        private static void WhatIsYourName()
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("How old are you? ");
            string age;
            age = Console.ReadLine();
            int newage = int.Parse(age);
            int retirement = 65 - newage;

            Console.Write("What is your favorite character? ");
            string character;
            character = Console.ReadLine();
            char newcharacter = char.Parse(character);

            Console.Write("Do you have a dog? ");
            string dog = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;



            Console.WriteLine(" ");
            Console.WriteLine("Thanks");


            Console.WriteLine(" ");





            Console.WriteLine("Your name is: " + name);

            Console.ForegroundColor = ConsoleColor.Red;


            Console.WriteLine("Days until retirement: " + retirement);


            Console.ForegroundColor = ConsoleColor.Blue;



            if (char.IsNumber(newcharacter))
            {
                Console.WriteLine("You like numbers");

            }
            else
            {
                Console.WriteLine("You don't like numbers");
            }


            Console.WriteLine("Does " + name + " has a dog: " + dog);

        }
    }
}

