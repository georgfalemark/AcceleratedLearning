using System;
using System.Data;

namespace Module3
{
    class Program
    {

        static void Main(string[] args)
        {

            // FruitApp();
            //SleepApp();
            //RepeatApp();
            //ForLoopApp();
            //ForEachLoopApp();
            //ForEachLoopAppWithZelda();
            //IfStatementApp();
            ConditionalOperator();
        
        }







        private static void ConditionalOperator()
        {


            Console.Write("Enter a number: ");
            string number = Console.ReadLine();
            int newnumber = int.Parse(number);

            string message = (newnumber < 20) ? "Lower than 20" : (newnumber > 20) ? "Higher than 20" : "Equal to 20";

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message); 




            //Console.Write("Enter a number: ");
            //string number = Console.ReadLine();
            //int newnumber = int.Parse(number);

            //string message = (newnumber < 20 && newnumber > 14) ? "Between 14 & 20" : (newnumber > 20 && newnumber < 60) ? "Between 20 & 60" : (newnumber > 61) ? "Higher than 61" : "Equal to 20";

            //Console.WriteLine(message);

























        }

        private static void IfStatementApp()
        {

            Console.Write("Enter a comparenumber: ");
            string comparenumber = Console.ReadLine();
            int newcomparenumer = int.Parse(comparenumber);


            Console.Write("Enter a number: ");
            string number = Console.ReadLine();
            int newnumber = int.Parse(number);


            if (newnumber < newcomparenumer)
            {
                Console.WriteLine("Lower than " + comparenumber);
            }
            else if (newnumber > newcomparenumer)
            {
                Console.WriteLine("Higher than " + comparenumber);
            }
            else
            {
                Console.WriteLine("Equal to " + comparenumber);
            }


            Console.WriteLine("\n");


            Console.Write("Enter your gender: ");
            string gender = Console.ReadLine();

            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            int newage = int.Parse(age);

            Console.WriteLine();

            if (gender == "male" && newage < 20)
            {
                Console.WriteLine("You are a male teenager");
            }
            else if (gender == "male" && newage > 21 && newage < 60)
            {
                Console.WriteLine("You are a male adult");
            }
            else if (gender == "male" && newage > 61)
            {
                Console.WriteLine("You are a old, old man!");
            }
            else if (gender == "female" && newage < 20)
            {
                Console.WriteLine("You are a female teenager");
            }
            else if (gender == "female" && newage > 21 && newage < 60)
            {
                Console.WriteLine("You are a female adult");
            }
            else if (gender == "female" && newage > 61)
            {
                Console.WriteLine("You are a old, old female!");
            }
            else if (gender == "nogender" && newage < 20)
            {
                Console.WriteLine("You are a nogender teenager");
            }
            else if (gender == "nogender" && newage > 21 && newage < 60)
            {
                Console.WriteLine("You are a nogender adult");
            }
            else if (gender == "nogender" && newage > 61)
            {
                Console.WriteLine("You are a old, old nogender person!");
            }







        }

        private static void ForEachLoopAppWithZelda()
        {


            Console.Write("Enter names in a list (like Maria, Peter, Lisa): ");

            string names = Console.ReadLine();
            string[] nameList = names.Split(',');

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (string name in nameList)
            {              
                if (name.Equals("zelda"))
                {
                    break;
                }

                Console.WriteLine($"{name} Andersson");
            }

            Console.WriteLine();

















        }

        private static void ForEachLoopApp()
        {


            Console.Write("Enter names in a list (like Maria, Peter, Lisa): ");

            string names = Console.ReadLine();
            string[] nameList = names.Split(',');

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (string name in nameList)
            {
                Console.WriteLine($"{name} Andersson");
            }

            Console.WriteLine();























        }

        private static void RepeatApp()
        {




            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Times to repeat: ");
            string times = Console.ReadLine();
            int newtimes = int.Parse(times);

            int i = 0;
            while (i < newtimes)
            {
                Console.WriteLine("Your name is " + name);
                i++;
            }



            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Your name is " + name);
            //    i++;
            //} while (i < newtimes);




















        }

        private static void FruitApp()
        {
            Console.Write("Enter fruit one: ");
            string fruitone = Console.ReadLine();

            Console.Write("Enter fruit two: ");
            string fruittwo = Console.ReadLine();

            Console.Write("Enter fruit three: ");
            string fruitthree = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("You entered three fruits: " + fruitone + ", " + fruittwo + ", " + fruitthree);
            Console.WriteLine("You entered three fruits: " + fruitone + ", " + fruittwo + ", " + fruitthree);
            Console.WriteLine("You entered three fruits: " + fruitone + ", " + fruittwo + ", " + fruitthree);

            Console.WriteLine("\n");

            string fruits = "You entered three fruits: " + fruitone + ", " + fruittwo + ", " + fruitthree;
            Console.WriteLine(fruits);
            Console.WriteLine(fruits);
            Console.WriteLine(fruits);

            Console.WriteLine("\n");

            var mystring = $"You entered three fruits: {fruitone}, {fruittwo}, {fruitthree}";
            Console.WriteLine(mystring);
            Console.WriteLine(mystring);
            Console.WriteLine(mystring);

            Console.WriteLine("\n");

            string[] fruitbasquet = { fruitone + ", " + fruittwo + ", " + fruitthree };
            foreach (var v in fruitbasquet)
            {
                Console.WriteLine("You entered three fruits " + v);
                Console.WriteLine("You entered three fruits " + v);
                Console.WriteLine("You entered three fruits " + v);
            }

            Console.WriteLine("\n");

            string choiceoffruits = string.Format("You entered three fruits: {0}, {1}, {2} ", fruitone, fruittwo, fruitthree);
            Console.WriteLine(choiceoffruits);
            Console.WriteLine(choiceoffruits);
            Console.WriteLine(choiceoffruits);

            Console.WriteLine("\n");
        }

        //private static void SleepApp()
        //{


        //Console.Write("When did you go to bed yesterday? ");
        //string bedtime = Console.ReadLine();
        //int newbedtime = int.Parse(bedtime);

        //Console.Write("When did you wake up? ");
        //string wakeuptime = Console.ReadLine();
        //int newwakeuptime = int.Parse(wakeuptime);

        //Console.WriteLine("\n");



        //int sleptbad;
        //int sleptokay;
        //int slepttomuch;






        //if (sleeptime1 = true)
        //{
        //Console.WriteLine("You have slept well." + "(" + sleeptime1 + " hours" + ")");
        //}
        //else if
        //{
        // Console.WriteLine("You have slept bad." + "(" + sleeptime1 + " hours" + ")");
        //}
        // else 
        //{
        //   Console.WriteLine("You have slept bad." + "(" + sleeptime1 + " hours" + ")");
        //}


        ////////Kolla på denna i efterhand!

        private static void ForLoopApp()
        {




            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Times to repeat: ");
            string times = Console.ReadLine();
            int newtimes = int.Parse(times);

            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < newtimes; i++)
            {
                Console.WriteLine("Your name is " + name);
            }


            Console.Write("Rows: ");
            string rows = Console.ReadLine();
            int newrows = int.Parse(rows);

            Console.Write("Columns: ");
            string columns = Console.ReadLine();
            int newcolumns = int.Parse(columns);


            for (int i = 0; i < newrows; i++)
            {
                for (int j = 0; j < newcolumns; j++)
                {
                    Console.Write(" " + name + " ");
                }
                Console.WriteLine();
            }

        }

















    }
}

