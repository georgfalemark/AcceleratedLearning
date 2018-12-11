using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsAndLists.Core
{
    public class NumberListToNumberList
    {

        public List<int> Add70ToEverySecondElement(List<int> numbers)
        {
            var plus70ToEverySecond = new List<int>();

            int index = 0;

            foreach (var number in numbers)
            {
                if (index == 1)
                {
                    int d = number + 70;
                    plus70ToEverySecond.Add(d);
                }
                else if (index == 0)
                {
                    plus70ToEverySecond.Add(number);
                }
                index++;

                if (index == 2)
                {
                    index = 0;
                }
            }
            return plus70ToEverySecond;
        }

        public List<int> Add50ToFirstThreeElements(List<int> numbers)
        {
            var plus50ToEvery = new List<int>();

            int index = 0;

            foreach (var number in numbers)
            {
                int d = number + 50;

                if (index <= 2)
                {
                    plus50ToEvery.Add(d);
                }
                else
                {
                    plus50ToEvery.Add(number);
                }
                index++;
            }
            return plus50ToEvery;
        }

        public List<int> NegateEachNumber(List<int> numbers)
        {
            var makeNumberNegative = new List<int>();

            foreach (var number in numbers)
            {
                int d = number * -1;
                makeNumberNegative.Add(d);
            }
            return makeNumberNegative;
        }

        public List<int> DivideEachNumberBy100(List<int> numbers)
        {
            var dividedresult = new List<int>();

            foreach (var number in numbers)
            {
                int d = number / 100;
                dividedresult.Add(d);
            }
            return dividedresult;
        }

        public List<int> DoubleEachNumber(List<int> input)
        {
            var doubledresult = new List<int>();

            foreach (var number in input)
            {
                int d = number * 2;
                doubledresult.Add(d);
            }
            return doubledresult;
        }

        public List<int> DoubleEachNumber_Linq(List<int> input)
        {
            return input.Select(x => x * 2).ToList();
        }

        public List<int> GetNumbersDividableByFive(List<int> numbers)
        {
            var dividedByFive = new List<int>();

            foreach (var number in numbers)
            {
                int d = number;

                if (d % 5 == 0)
                {
                    dividedByFive.Add(d);
                }
            }
            return dividedByFive;
        }

        public List<int> GetNumbersHigherThan1000(List<int> numbers)
        {
            var numberHigherThan1000 = new List<int>();

            foreach (var number in numbers)
            {
                int d = number;

                if (d > 1000)
                {
                    numberHigherThan1000.Add(d);
                }
            }
            return numberHigherThan1000;
        }

        public List<int> Add100ToEachNumber(List<int> numbers)
        {
            var add100 = new List<int>();

            foreach (var number in numbers)
            {
                int d = number + 100;
                add100.Add(d);
            }
            return add100;
        }
    }
}