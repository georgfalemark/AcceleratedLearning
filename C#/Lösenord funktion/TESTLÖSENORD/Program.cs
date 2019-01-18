using System;

namespace TESTLÖSENORD
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ANGE LÖSENORD: ");
            string pass = "";
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                // Backspace Should Not Work
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                    {
                        pass = pass.Substring(0, (pass.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        if (pass == "Mercado1")
                        {
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Fel, ange rätt lösenord annars blir du bannad din fillidutt!");
                            Console.ResetColor();
                            pass = "";
                        }
                    }
                }
            } while (true);



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("LYCKADES");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
