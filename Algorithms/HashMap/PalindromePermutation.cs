using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.HashMap
{
    public class PalindromePermutation
    {
        // Can use Dictionary<char, int> to store frequency of
        // all characters, and then loop over to find if more than
        // 1 odd character freq exists. But set is better as it 
        // is in 1 pass
        public static bool CanPermutePalindrome(string s)
        {
            HashSet<char> set = new HashSet<char>();

            foreach (var c in s)
            {
                if (!set.Contains(c))
                {
                    set.Add(c);
                }
                else
                {
                    set.Remove(c);
                }
            }

            return set.Count <= 1;
        }
    }
}
