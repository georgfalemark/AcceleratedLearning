using System;
using System.Linq;

namespace MethodsAndLists.Core
{
    public class NumberToNumber
    {
        public int SumNumbersTo(int input)
        {
            if (input == 0 || input < 0)
            {
                throw new ArgumentException();
            }

            int y = 0;

            for (int i = 1; i <= input; i++)
            {
                y += i;
            }

            return y;
        }

        public int SumNumbersTo_WithoutLinq(int input)
        {
            throw new NotImplementedException();
        }

        public int SumNumbers(int from, int to)
        {

            


            throw new NotImplementedException();


        }

        public int SumNumbersDividedByThreeOrFive(int input)
        {
            if (input < 0 || input == 0)
            {
                throw new ArgumentException();
            }

            int y = 0;

            for (int i = 1; i <= input; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    y += i;
                }
            }

            return y;
        }
    }
}
