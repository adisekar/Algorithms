using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings.Palindrome
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            s = s.ToLower();
            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {
                while (i < j && !char.IsLetterOrDigit(s[i]))
                {
                    i++;
                }

                while (i < j && !char.IsLetterOrDigit(s[j]))
                {
                    j--;
                }

                if (s[i] != s[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}
