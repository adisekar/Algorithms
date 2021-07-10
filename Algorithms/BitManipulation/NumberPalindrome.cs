using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BitManipulation
{
    public class NumberPalindrome
    {
        public bool IsPalindrome(int x)
        {
            // If negative, not a palindrome
            if (x < 0)
            {
                return false;
            }

            int newNum = 0;
            int y = x;
            while (y > 0)
            {
                int rem = y % 10;
                newNum = (newNum * 10) + rem;
                y = y / 10;
            }

            return x == newNum ? true : false;
        }
    }
}
