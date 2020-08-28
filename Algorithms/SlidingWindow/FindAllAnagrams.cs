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
                char c = p[i];
                var index = c - 'a';
                pArr[index]++;
            }

            // Initial population of values, till window size - 1
            for (int i = 0; i < p.Length - 1; i++)
            {
                char c = s[i];
                var index = c - 'a';
                sArr[index]++;
            }

            int left = 0;
            int right = p.Length - 1;
            // Start from window size and go till n - window length
            while (left <= s.Length - p.Length)
            {
                // Add to window
                var rightCharIndex = s[right] - 'a';
                sArr[rightCharIndex]++;
                int startIdx = right - (p.Length - 1);
                if (IsAnagram(sArr, pArr))
                {
                    result.Add(startIdx);
                }
                // Increment right
                right++;

                // Remove from window    
                var leftCharIndex = s[left] - 'a';
                sArr[leftCharIndex]--;
                left++;
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
