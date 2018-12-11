using System;
using System.Collections.Generic;
using System.Text;
using MethodsAndLists.Core.Models;

namespace MethodsAndLists.Core
{
    public class StringToObjectList
    {
        public List<City> ParseCities(string input)
        {
            //Lista AV city syftar till att vi har en klass som heter city!
            List<City> cities = new List<City>();

            //För att inte lägga få null som svar här lägger vi till input ÄR INTE LIKA MED "null"
            if (string.IsNullOrWhiteSpace(input)  && input != null)
            {
                return cities;
            }

            //Exception om svaret är null
            if (input == null)
            {
                throw new ArgumentException();
            }

            //Delar strängen med städerna så att de hamnar STAD!
            string[] städer = input.Split(";");

            foreach (string item in städer)
            {
                //Delar VARJE "item" i strängen "städer" med ','
                string[] städerEnsam = item.Split(",");
                var c = new City();
                c.Name = städerEnsam[0];
                c.Population = int.Parse(städerEnsam[1]);

                cities.Add(c);
            }         
            return cities;
        }
    }
}
