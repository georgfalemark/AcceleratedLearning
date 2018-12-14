using System;
using System.Collections.Generic;


namespace CheckPoint3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string> { "a", "b", "c", "d", "e" };
            List<string> result = ReOrderList(myList);
        }

        public static List<string> ReOrderList(List<string> myList)
        {
            //var result = new List<string>();

            //if (myList == null)
            //{
            //    throw new ArgumentNullException();
            //}

            //myList.Sort();

            //foreach (string item in myList)
            //{
            //    result.Add(item);
            //}

            //return result;

            return myList[myList.FindIndex(ind => ind.Equals(myList[3]))]
            

        }
    }
}
