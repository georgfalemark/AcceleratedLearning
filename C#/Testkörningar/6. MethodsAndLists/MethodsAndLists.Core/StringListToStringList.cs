using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndLists.Core
{
    public class StringListToStringList
    {
        public IEnumerable<string> GetEverySecondElement(string[] strings)
        {


            //if (strings == null)
            //{
            //    throw new ArgumentNullException();
            //}

            //int counter = 0;
            //var result = new List<string>();

            //foreach (var item in strings)
            //{
            //    if (counter == 1)
            //    {
            //        result.Add(item);
            //    }

            //    if (counter == 2)
            //    {
            //        counter = 0;
            //    }               
            //    counter++;
            //}
            //return result;


            return strings.Where((x, i) => (i + 1) % 2 == 0);

        }
    }
}
