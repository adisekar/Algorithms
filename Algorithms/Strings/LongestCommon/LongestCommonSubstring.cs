using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    // str1 = "ABAB", str2 = "BABA". Result = "ABA" or "BAB". = 3
    public class LongestCommonSubstring
    {
        public static string FindLongest(string s1, string s2)
        {
            string result = "";
            int[,] cache = new int[s1.Length, s2.Length];

            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    // If 2 characters match, then add 1 to prev diagnol value
                    if (s1[i] == s2[j])
                    {
                        if (i == 0 || j == 0)
                        {
                            cache[i, j] = 1;
                        }
                        else
                        {
                            cache[i, j] = cache[i - 1, j - 1] + 1;
                        }

                        if (cache[i, j] > result.Length)
                        {
                            result = s1.Substring(i - cache[i, j] + 1, j);
                        }
                    }
                }
            }
            return result;
        }
    }
}
