using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    /*
     * Input: "USA"
Output: True

        Input: "FlaG"
Output: False

        Input: "leetcode"
Output: True
     * */
    public class DetectCapital
    {
        public bool DetectCapitalUse(string word)
        {
            int countCapital = 0;

            foreach (var c in word)
            {
                if (char.IsUpper(c))
                {
                    countCapital++;
                }
            }

            if (countCapital == word.Length)
            {
                return true;
            }
            if (countCapital == 0)
            {
                return true;
            }

            if (Char.IsUpper(word[0]) && countCapital == 1)
            {
                return true;
            }
            return false;
        }
    }
}
