using Algorithms.Strings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.SlidingWindow
{
    public class FindAllAnagrams
    {
        // Here we are checking all characters of window length
        // for every character. Instead we should cange start and 
        // end window pointers
        public static IList<int> FindAnagrams_BF(string s, string p)
        {
            IList<int> result = new List<int>();

            for (int i = p.Length - 1; i < s.Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                int j = i;
                int count = 0;
                while (count < p.Length)
                {
                    count++;
                    sb.Append(s[j]);
                    j--;
                }
                var checkStr = sb.ToString();
                if (Anagram.IsAnagram(p, checkStr))
                {
                    result.Add(i - (p.Length - 1));
                }
            }
            return result;
        }

        // Same as solution of Final all permutations in string
        public static IList<int> FindAnagrams(string s, string p)
        {
            IList<int> result = new List<int>();

            if (p.Length > s.Length)
            {
                return result;
            }

            int[] pArr = new int[26];
            int[] sArr = new int[26];
            for (int i = 0; i < p.Length; i++)
            {
                pArr[p[i] - 'a']++;
                sArr[s[i] - 'a']++;
            }

            for (int i = 0; i <= s.Length - p.Length; i++)
            {
                if (IsAnagram(sArr, pArr))
                {
                    result.Add(i);
                }

                sArr[s[i + p.Length] - 'a']++;
                sArr[s[i] - 'a']--;
            }
            return result;
        }
        private static bool IsAnagram(int[] sArr, int[] pArr)
        {
            for (int i = 0; i < 26; i++)
            {
                if (sArr[i] != pArr[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
