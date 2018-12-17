using System;

namespace OneToOne
{
    class Program
    {
        public enum Language
        {
            english,
            swedish
        };

        static void Main(string[] args)
        {
            putBackgroundOn();
            Language language = AskUserForLanguage();
            putBackgroundOn();
            bool upperCase = AskForUpperCaseOrNot(language);
            putBackgroundOn();
            int tal1 = AskForNumber(1, language, upperCase);
            int tal2 = AskForNumber(2, language, upperCase);
            int sum = CalculateSum(tal1, tal2);
            DisplaySum(sum, language, upperCase);
        }

        private static void putBackgroundOn()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        private static Language AskUserForLanguage()
        {
            int index = 0;
            while (true)
            {
                Console.Write("(S)wedish or (E)nglish? ");
                string language = Console.ReadLine();

                if (language == "s" || language == "s".ToUpper())
                {
                    return Language.swedish;
                }
                if (language == "e" || language == "e".ToUpper())
                {
                    return Language.english;
                }
                if (index == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Knappa in S eller E!!!!!!");
                    Console.Beep();
                    Console.ResetColor();
                }
                index++;
            }
        }

        private static bool AskForUpperCaseOrNot(Language language)
        {
            int index = 0;
            while (true)
            {
                if (Language.english == language)
                {
                    Console.Write("Uppercase letters (y/n): ");
                    string upperCaseChoice = Console.ReadLine();

                    if (upperCaseChoice == "y" || upperCaseChoice == "y".ToUpper())
                    {
                        return true;
                    }
                    else if (upperCaseChoice == "n" || upperCaseChoice == "n".ToUpper())
                    {
                        return false;
                    }
                }
                else
                {
                    Console.Write("Stora bokstäver (j/n): ");
                    string upperCaseChoice = Console.ReadLine();

                    if (upperCaseChoice == "j" || upperCaseChoice == "j".ToUpper())
                    {
                        return true;
                    }
                    else if (upperCaseChoice == "n" || upperCaseChoice == "n".ToUpper())
                    {
                        return false;
                    }
                }

                if (index == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Knappa in rätt!!!!!!");
                    Console.Beep();
                    Console.ResetColor();
                }
                index++;
            }
        }

        private static int AskForNumber(int a, Language language, bool UpperCase)
        {
            while (true)
            {
                if (UpperCase == true)
                {
                    if (Language.swedish == language)
                    {
                        try
                        {
                            Console.Write($"Ange tal {a}: ".ToUpper());
                            int x = Convert.ToInt32(Console.ReadLine());
                            return x;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Du angav inte en siffra!".ToUpper());
                        }
                    }
                    else
                    {
                        try
                        {
                            Console.Write($"Enter number {a}: ".ToUpper());
                            int x = Convert.ToInt32(Console.ReadLine());
                            return x;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("You didn't type a number!".ToUpper());
                        }
                    }
                }
                else
                {
                    if (Language.swedish == language)
                    {
                        try
                        {
                            Console.Write($"Ange tal {a}: ");
                            int x = Convert.ToInt32(Console.ReadLine());
                            return x;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Du angav inte en siffra!");
                        }
                    }
                    else
                    {
                        try
                        {
                            Console.Write($"Enter number {a}: ");
                            int x = Convert.ToInt32(Console.ReadLine());
                            return x;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("You didn't type a number!");
                        }
                    }
                }
            }
        }

        private static int CalculateSum(int tal1, int tal2)
        {
            int sum = tal1 + tal2;
            return sum;
        }

        private static void DisplaySum(int x, Language language, bool UpperCase)
        {
            if (UpperCase == true)
            {
                if (Language.swedish == language)
                {
                    Console.WriteLine($"Summan av talen är {x}".ToUpper());
                }
                else
                {
                    Console.WriteLine($"The sum is {x}".ToUpper());
                }
            }
            else
            {
                if (Language.swedish == language)
                {
                    Console.WriteLine($"Summan av talen är {x}");
                }
                else
                {
                    Console.WriteLine($"The sum is {x}");
                }
            }
        }
    }
}
