using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validation;
            bool validationlenght;
            string[] output;
            do
            {
                string names = GetInputFromUser();
                output = CreateArrayOfPeople(names);
                string[] CleanNames = CleanUpArray(output);
                validation = PeopleArrayIsValid(output);
                validationlenght = PeopleArrayIsValidLenght(output);

            } while (validation == true || validationlenght == true);

            RespondToUser(output, validation, validationlenght);





            //Console.WriteLine("Enter names separated by comma (e.g Maria,Peter,Lisa): ");
            //string names = Console.ReadLine();
            //string[] nameList = names.Split(',');
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine();
            //foreach (string name in nameList)
            //{
            //    Console.WriteLine($"***SUPER-{name.ToUpper()}***");
            //}
            //Console.WriteLine();

        }



        private static string GetInputFromUser()
        {
            Console.WriteLine("Enter names separated by comma (e.g Maria,Peter,Lisa): ");
            string input = Console.ReadLine();
            return input;
        }

        private static string[] CreateArrayOfPeople(string names)
        {
            string[] arrayofpeople = names.Split(',');
            return arrayofpeople;
        }

        private static string[] CleanUpArray(string[] output)
        {

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = output[i].Trim();
            }
            return output;
        }
        


        private static bool PeopleArrayIsValid(string[] output)
        {

            if (output == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The list don't contain any names");
                return true;
            }
            else
            {
                return false;
            }

        }

        private static bool PeopleArrayIsValidLenght(string[] output)
        {

            if (output.Length < 2 || output.Length > 9)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A person can only have 2 to 9 letters");
                return true;

            }
            else
            {
                return false;
            }
        }



        private static void RespondToUser(string[] peopleArray, bool Validation, bool ValidationLenght)
        {
           
                foreach (string name in peopleArray)
                {
                    Console.WriteLine($"***SUPER-{name.ToUpper()}***");
                }
            
        }
    }
}

