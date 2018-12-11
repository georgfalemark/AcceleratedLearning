using System.Collections.Generic;
using System;
using System.Linq;

namespace MethodsAndLists.Core
{
    public class NumberListToStringList
    {

        public List<string> LongOrShort(List<int> heightList)
        {
            var longShort = new List<string>();

            foreach (var height in heightList)
            {
                if (height > 120 && height < 160)
                {
                    longShort.Add($"{height}cm är kort");
                }
                else if (height > 160 && height < 220)
                {
                    longShort.Add($"{height}cm är långt");
                }
            }
            return longShort;
        }

        public List<string> NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(List<int> numbers)
        {
            var giveNumberDiffName = new List<string>();

            string zip = "ZIP";
            string zap = "ZAP";
            string boing = "BOING";

            foreach (var number in numbers)
            {
                if (number == 0)
                {
                    giveNumberDiffName.Add(boing);
                }
                else if (number < 0)
                {
                    giveNumberDiffName.Add(zip);
                }
                else if (number > 0)
                {
                    giveNumberDiffName.Add(zap);
                }
            }
            return giveNumberDiffName;
        }

        public List<string> AddStarsToNumbersHigherThan1000(List<int> numbers)
        {
            var starsFor1000 = new List<string>();

            foreach (var number in numbers)
            {
                if (number > 1000)
                {
                    starsFor1000.Add($"***{number}***");
                }
                else
                {
                    starsFor1000.Add($"{number}");
                }
            }
            return starsFor1000;
        }

        public List<string> AddStars(List<int> numbers)
        {
            var stars = new List<string>();

            foreach (int number in numbers)
            {
                stars.Add("***" + number + "***");
            }
            return stars;
        }

        public List<string> AddStars_Linq(List<int> numbers)
        {

            return numbers.Select(x => "***"+ x +"***").ToList();

        }
    }
}