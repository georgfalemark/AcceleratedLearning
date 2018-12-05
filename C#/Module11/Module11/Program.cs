using System;
using System.Collections.Generic;
using System.Linq;

namespace Module11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> Masterlist = new List<double> { 33, 54, 15 };


            //Här förstår de "Masterlist" eftersom det är inom samma klamrar
            double mySum = Sum(Masterlist);
            Console.WriteLine($"Summan av talen UTAN LINK är {mySum}");

            double myAverage = Average(Masterlist);
            Console.WriteLine($"Medelvärdet av talen UTAN LINK är {myAverage}");

            double myLinqSum = Sum_WithLinq(Masterlist);
            //SKRIV UT HÄR

            double myLinqAverage = Average_WithLinq(Masterlist);
            //SKRIV UT HÄR


            

            //Skickar vidare listan output till nya metoder
            //NumbersHigherThanFive(output);

            // StariFyList(output);

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

        private static void NumbersHigherThanFive(List<double> output)
        {
            Console.Write("Higher than 5 UTAN LINK: ");
            foreach (var item in output)
            {
                if (item > 5)
                {
                    Console.Write(item);
                }
            }

            Console.WriteLine("Higher than 5 MED LINK: ");
            ///////////////FIXA DENNA
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
