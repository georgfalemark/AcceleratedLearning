using System.Collections.Generic;
using System.Linq;
using System;

namespace MethodsAndLists.Core
{
    public class NumberListToString
    {
        // Demo: returnera "fjärde talet är jättestort" om det är större än 10000

        public string ReportNumberOfNegativeValues(List<int> numbers)
        {
            int numberOfNegativeNumbers = 0;

            foreach (var number in numbers)
            {
                if (number < 0)
                {
                    numberOfNegativeNumbers++;
                }
            }

            if (numberOfNegativeNumbers == 0)
            {
                return "Jippi! Det finns inga negativa tal i listan";
            }
            else if (numberOfNegativeNumbers == 1)
            {
                return "Det finns ett negativt tal i listan";
            }
            else
            {
                return "Det finns " + numberOfNegativeNumbers + " st negativa tal i listan";
            }
        }

        public string ReportIfAllValuesAreHigherThan100(List<int> numbers)
        {
            bool boolStatement = true;

            foreach (var number in numbers)
            {
                if (number > 100)
                {
                    boolStatement = true;
                }
                else
                {
                    boolStatement = false;
                    break;
                }
            }

            if (boolStatement)
            {
                return "Alla nummer är högre än 100";
            }
            else
            {
                return "Något nummer är lägre än (eller lika med) 100";
            }
        }

        public string ReportFirstAndLastValue(List<int> numbers)
        {
            if (numbers.Count == 0 || numbers == null)
            {
                throw new ArgumentException();
            }

            int firstNumber = numbers[0];
            int lastIndex = numbers.Count - 1;
            int lastNumber = numbers[lastIndex];

            return "Första siffran är " + firstNumber + " och sista siffran är " + lastNumber;
        }

        public string ReportFirstAndLastValue_Linq(List<int> numbers)
        {
            throw new NotImplementedException();
        }
    }
}