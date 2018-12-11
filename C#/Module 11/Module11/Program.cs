using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Module11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine();

            //var Masterlist = new List<double> { 33, 54, 15 };

            ////Här förstår de "Masterlist" eftersom det är inom samma klamrar
            //double mySum = Sum(Masterlist);
            //Console.WriteLine($"Summan av talen UTAN LINK är {mySum}");

            //double myAverage = Average(Masterlist);
            //Console.WriteLine($"Medelvärdet av talen UTAN LINK är {myAverage}");

            //double myLinqSum = Sum_WithLinq(Masterlist);
            ////SKRIV UT HÄR

            //double myLinqAverage = Average_WithLinq(Masterlist);
            ////SKRIV UT HÄR

            //List <double> myNumbersHigherThanFive = NumbersHigherThanFive(Masterlist);
            //Console.WriteLine($"Nummer högre än {myNumbersHigherThanFive}");

            //// StariFyList(Masterlist);



            //List<Show> allShows = GetShowsFromTextFile();
            //DisplayInfoAboutShows(allShows);



            List<Person> personList = CreateListOfCustomers("Personshort.txt");
            DisplayPersonList(personList);

            Console.ReadKey();
        }

        private static List<Person> CreateListOfCustomers(String fileWithPersons)
        {
            List<Person> personList = new List<Person>();
            string[] everyLine = File.ReadAllLines(@"C:\TMP\PersonShort.txt");

            foreach (string item in everyLine)
            {
                string[] splitedPersonInfo = item.Split(",");

                var p = new Person();

                int newID = int.Parse(splitedPersonInfo[0]);
                p.ID = newID;
                p.FirstName = splitedPersonInfo[1];
                p.LastName = splitedPersonInfo[2];
                p.Email = splitedPersonInfo[3];
                p.Gender = Enum.Parse<Gender>(splitedPersonInfo[4]);
                int newAge = int.Parse(splitedPersonInfo[5]);
                p.Age = newAge;

                personList.Add(p);
            }
            return personList;
        }

        private static void DisplayPersonList(List<Person> personList)
        {
            Console.WriteLine();
            Console.WriteLine("Sorted list by age: ");
            Console.WriteLine();

            personList.Sort((a, b) => a.Age - b.Age);
            foreach (Person person in personList)
            {
                Console.WriteLine($"{person.FirstName}\t\t{person.Age}\t\t{person.Gender}");
            }

            Console.WriteLine();
            Console.WriteLine("Sorted list by first name: ");
            Console.WriteLine();

            personList.Sort((a, b) => string.Compare(a.FirstName, b.FirstName));
            foreach (Person person in personList)
            {
                Console.WriteLine($"{person.FirstName}\t\t{person.Age}\t\t{person.Gender}");
            }

            Console.WriteLine();
            Console.WriteLine("Men older than 35: ");
            Console.WriteLine();

            var menOlderThan35 = personList.Where(x => x.Gender == Gender.Male && x.Age > 35);
            foreach (Person person in menOlderThan35)
            {
                Console.WriteLine($"{person.FirstName}\t\t{person.Age}\t\t{person.Gender}");
            }

            Console.WriteLine();
            Console.WriteLine("Manipulated: ");
            Console.WriteLine();

            var manipulatedList = menOlderThan35.Select(x => new Person
            {
                ID = x.ID,
                Age = x.Age + 1000,
                FirstName = x.FirstName.ToUpper(),
                LastName = x.LastName.ToUpper(),
                Email = x.Email,
                Gender = x.Gender
            });

            foreach (Person person in manipulatedList)
            {
                Console.WriteLine($"{person.FirstName}\t\t{person.Age}\t\t{person.Gender}");
            }
        }


        private static List<Show> GetShowsFromTextFile()
        {
            List<Show> Shower = new List<Show>();
            string[] shower = File.ReadAllLines(@"C:\TMP\tv-data.txt");

            foreach (string item in shower)
            {
                string[] deladeShower = item.Split("*");

                var s = new Show();
                s.Channel = deladeShower[0];
                TimeSpan time = TimeSpan.Parse(deladeShower[1]);
                s.StartTime = time;
                s.Title = deladeShower[2];

                Shower.Add(s);
            }
            return Shower;
        }
        private static void DisplayInfoAboutShows(List<Show> allShows)
        {
            Console.WriteLine("ALLA TITLAR");
            Console.WriteLine();

            foreach (Show show in allShows)
            {
                Console.WriteLine(show.Title);
            }

            Console.WriteLine();
            Console.WriteLine("PROGRAM SOM BÖRJAR SENARE ÄN KL 21");
            Console.WriteLine();

            foreach (Show show in allShows)
            {
                if (show.StartTime.Hours >= 21)
                {
                    Console.WriteLine($"{show.Channel} {show.StartTime} {show.Title}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("PROGRAM FRÅN SVT2 I KRONOLOGISK ORDNING");
            Console.WriteLine();

            foreach (Show show in allShows)
            {
                if (show.Channel == "SVT2")
                {
                    Console.WriteLine($"{show.Channel} {show.StartTime} {show.Title}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("FINNS PROGRAMMET 'KULTURNYHETERNA'? ");
            Console.WriteLine();

            foreach (Show show in allShows)
            {
                if (show.Title == "Kulturnyheterna")
                {
                    Console.WriteLine("Ja");
                }
            }

            Console.WriteLine();
            Console.WriteLine("FINNS PROGRAMMET 'ENSAM PAPPA SÖKER'? ");
            Console.WriteLine();

            int counter = 0;
            foreach (Show show in allShows)
            {
                if (show.Title != "Ensam pappa söker" && counter == 0)
                {
                    Console.WriteLine("Nej");
                }
                counter++;
            }

            Console.WriteLine();
            Console.WriteLine("ALLA PROGRAM SOM BÖRJAR KL 20.00 ");
            Console.WriteLine();

            foreach (Show show in allShows)
            {
                if (show.StartTime.Hours == 20)
                {
                    Console.WriteLine($"{show.Channel} {show.StartTime} {show.Title}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("ALLA PROGRAMNAME MED STORA BOKSTÄVER ");
            Console.WriteLine();

            foreach (Show show in allShows)
            {
                Console.WriteLine(show.Title.ToUpper());
            }

            Console.WriteLine();
            Console.WriteLine("ALLA KANALER ");
            Console.WriteLine();

            int i = 0;
            foreach (Show show in allShows)
            {
                Console.WriteLine(show.Channel);
                i++;
            }
        }


        private static double Sum(List<double> kalle1)
        {
            double totalen = 0;

            foreach (double item in kalle1)
            {
                totalen += item;
            }
            return totalen;
        }
        private static double Sum_WithLinq(List<double> listOfNumbers)
        {
            double sumTotalen = listOfNumbers.Sum();

            return sumTotalen;
        }
        private static double Average(List<double> listOfNumbers)
        {
            double averageResult = Sum(listOfNumbers)  / listOfNumbers.Count;

            return averageResult;
        }
        private static double Average_WithLinq(List<double> listOfNumbers)
        {
            double result = listOfNumbers.Average();
            return result;
        }
        private static List<double> NumbersHigherThanFive(List<double> listOfNumbers)
        {
            List<double> result = new List<double>();

            foreach (var number in listOfNumbers)
            {
                if (number > 5)
                {
                    result.Add(number);
                }
            }
            return result;
        }
        //private static StariFyList(List<double> output)
        //{

        //    var ListaStjärnor = new List<double>;
        //    ListaStjärnor.Add(*);

        //    foreach (var item in ListaStjärnor)
        //    {
        //        ??????????????("*" + item + "*");
        //    }

        //}

    }
}
