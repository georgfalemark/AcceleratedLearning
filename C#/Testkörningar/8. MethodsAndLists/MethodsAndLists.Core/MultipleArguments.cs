using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MethodsAndLists.Core.Enums;

namespace MethodsAndLists.Core
{
    public class MultipleArguments
    {
        public List<string> SomeToUpper(List<string> list, List<bool> toUpper)
        {
            var result = new List<string>();
            int counter = 0;

            foreach (var item in list)
            {
                if (toUpper[counter])
                {
                    result.Add(item.ToUpper());
                }
                else
                {
                    result.Add(item);
                }
                counter++;
            }
            return result;
        }

        public List<double> MultiplyAllBy(int factor, List<double> numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentException();
            }

            var result = new List<double>();

            foreach (var item in numbers)
            {
                result.Add(item * factor);
            }

            return result;
        }

        public List<double> MultiplyAllBy_Linq(int factor, List<double> numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentException();
            }

            return numbers.Select((x => x * factor)).ToList();
        }

        public List<string> NearbyElements(int position, List<string> list)
        {
            var result = new List<String>();
            int counter = 0;

            foreach (var item in list)
            {
                if (position < 0 || list.Count <= position)
                {
                    throw new ArgumentException();
                }

                if (position - 1 == counter)
                {
                    result.Add(item);
                }
                else if (position + 1 == counter)
                {
                    result.Add(item);
                }
                else if (position == counter)
                {
                    result.Add(item);
                }
                counter++;
            }
            return result;
        }

        public List<List<int>> MultiplicationTable(int rowMax, int colMax)
        {
            if (rowMax <= 0 || colMax <= 0)
            {
                throw new ArgumentException();
            }

            var combinedList = new List<List<int>>();

            for (int i = 1; i <= rowMax; i++)
            {
                var rows = new List<int>();
                for (int j = 1; j <= colMax; j++)
                {
                    rows.Add(j * i);
                }
                combinedList.Add(rows);
            }
            return combinedList;
        }

        public List<List<int>> MultiplicationTable_Linq(int rowMax, int colMax)
        {
            throw new NotImplementedException();
        }

        public int ComputeSequenceSumOrProduct(int toNumber, bool sum)
        {
            if (toNumber <= 0)
            {
                throw new ArgumentException();
            }

            int result = 0;

            if (sum == true)
            {
                for (int i = 1; i <= toNumber; i++)
                {
                    result += i;
                }
            }
            else if (sum == false)
            {
                result = 1;
                for (int i = 1; i <= toNumber; i++)
                {
                    result *= i;
                }
            }
            return result;
        }

        public int ComputeSequence(int toNumber, ComputeMethod sum)
        {
            if (toNumber <= 0)
            {
                throw new ArgumentException();
            }

            var range = Enumerable.Range(1, toNumber).ToList();

            switch (sum)
            {
                case ComputeMethod.Sum:
                    {
                        return range.Sum();
                    }
                case ComputeMethod.Product:
                    {
                        return range.Aggregate((a, b) => a * b);
                    }
                default:
                    {
                        throw new NotImplementedException();
                    }
            }
        }

        public int[] CombineLists(int[] list1, int[] list2)
        {
            var result = new List<int>();

            for (int i = 0; i < Math.Max(list1.Length, list2.Length); i++)
            {
                if (i < list1.Length)
                {
                    result.Add(list1[i]);
                }

                if (i < list2.Length)
                {
                    result.Add(list2[i]);
                }
            }
            return result.ToArray();
        }

        public int[] RotateList(int[] list, int rotation)
        {
            // Ej riktigt färdig än!


            if (list == null)
                throw new ArgumentException();

            var rotateList = new List<int>();


            if (rotation == 0 || rotation < -(list.Length - 1) || rotation > list.Length - 1)
            {
                return list;
            }
            else if (rotation > 0 && rotation < list.Length - 1)
            {
                for (int i = 0; i < (list.Length); i++)
                {
                    int y = i - rotation;
                    if (y < 0)
                    {
                        y = i + (list.Length - 1);
                        rotateList.Add(list[y]);
                    }
                    else
                    {
                        rotateList.Add(list[i - rotation]);
                    }
                }
            }
            else if (rotation < 0 || rotation > -(list.Length - 1))
            {
                for (int i = 0; i < list.Length; i++)
                {
                    int y = i + rotation;
                    if (y > 0)
                    {
                        y = i - (list.Length + 1);
                        rotateList.Add(list[y]);
                    }
                    else
                    {
                        rotateList.Add(list[i + -(rotation)]);
                    }
                }
            }

            return rotateList.ToArray();
        }
    }
}
