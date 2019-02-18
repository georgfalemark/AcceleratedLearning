using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace regex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^([A-Z]{2})-(\d{3})-(\d{3})$");

            string produktnummer = "DE-234-456";
            Match match = regex.Match(produktnummer);

            if (match.Success)
            {
                Console.WriteLine($"Första delen: {match.Groups[1].Value}");
                Console.WriteLine($"Andra delen: {match.Groups[2].Value}");
                Console.WriteLine($"Tredje delen: {match.Groups[3].Value}");
            }
















        }
    }
}
