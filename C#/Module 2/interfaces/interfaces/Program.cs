using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {





            List<List<decimal>> multiDimList = new List<List<decimal>> { new List<decimal> { 1, 2, 3 }, new List<decimal> { 4, 5, 6 }, new List<decimal> { 7, 8, 9 } };

            foreach (var list in multiDimList)
            {
                Console.WriteLine(list[0]);
            }




            Console.ReadKey();

        }
    }
}
