using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    public class LongestCommonPrefix
    {
        public static string LCP(string[] words)
        {
            string longestCommonPrefix = "";
            // Guard clause
            if (words == null || words.Length == 0)
            {
                return longestCommonPrefix;
            }
            // Loop thru each character of first word
            for (int i = 0; i < words[0].Length; i++)
            {
                char c = words[0][i];
                // loop thru remaining words, and check their char
                for (int j = 1; j < words.Length; j++)
                {
                    string word = words[j];
                    // If index is more than word length 
                    // or char dont match
                    if (i >= word.Length || c != word[i])
                    {
                        return longestCommonPrefix;
                    }
                }
                // Here means char exists in all words
                longestCommonPrefix += c;
            }
            return longestCommonPrefix;
        }
    }
}
