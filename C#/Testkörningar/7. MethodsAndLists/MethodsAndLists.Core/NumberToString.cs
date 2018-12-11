using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndLists.Core
{
    public class NumberToString
    {
        public string Triangle(int height)
        {
            if (height < 0)
            {
                throw new ArgumentException();
            }


            for (int i = 1; i <= height; i++)
            {
                for (int i = 0; i < height; i++)
                {
                    Console.Write("");
                }
            }




            throw new NotImplementedException();
        }

        public string Triangle(int height, char symbol)
        {
            throw new NotImplementedException();
        }

        public string TriangleReversed(int height)
        {
            throw new NotImplementedException();
        }


    }
}
