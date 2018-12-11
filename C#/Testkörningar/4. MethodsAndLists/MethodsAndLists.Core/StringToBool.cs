using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MethodsAndLists.Core
{
    public class StringToBool
    {
        public bool Is_Pandorome(string word)
        {
            string reversestring = string.Empty;

            if (!Regex.IsMatch(word, @"^[a-zA-ZåäöÅÄÖ]+$"))
            {
                return false;
            }

            if (word != null)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversestring += word[i].ToString();
                }
                if (reversestring == word)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Is_ZipCode(string word)
        {
            if (Regex.IsMatch(word, @"^[1-9]\d\d \d\d$"))
            {
                return true;
            }
            else
            {
                return false;
            }         
        }
    }
}
