using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    public class LongestPalindrome
    {
        public static string Substring_BF(string s)
        {
            if (s.Length < 2)
            {
                return s;
            }

            string longest = s[0].ToString();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j <= s.Length; j++)
                {
                    string substring = s.Substring(i, j - i);
                    if (IsPalindrome(substring))
                    {
                        if (substring.Length > longest.Length)
                        {
                            longest = substring;
                        }
                    }
                }
            }
            // return longest.Length == 0 && s.Length> 0 ? s[0].ToString() : longest;
            return longest;
        }

        public static string Substring_ExpandCenter(string s)
        {
            int[] longest = { 0, 0 };
            for (int i = 0; i < s.Length; i++)
            {
                // Odd
                int[] odd = ExpandCenter(s, i - 1, i + 1, longest);
                // Even
                int[] even = ExpandCenter(s, i, i + 1, longest);
                if (odd[1] - odd[0] > even[1] - even[0])
                {
                    longest[0] = odd[0];
                    longest[1] = odd[1];
                }
                else
                {
                    longest[0] = even[0];
                    longest[1] = even[1];
                }
            }
            return s.Length > 1 ? s.Substring(longest[0], longest[1] - longest[0] + 1) : s;
        }

        private static int[] ExpandCenter(string s, int j, int k, int[] longest)
        {
            while (j >= 0 && k < s.Length)
            {
                if (s[j] == s[k])
                {
                    if (k - j > longest[1] - longest[0])
                    {
                        longest[0] = j;
                        longest[1] = k;
                    }
                }
                else
                {
                    break;
                }
                j--;
                k++;
            }
            return longest;
        }

        private static bool IsPalindrome(string s)
        {
            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {
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
