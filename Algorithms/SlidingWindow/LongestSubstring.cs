using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.SlidingWindow
{
    public class LongestSubstring
    {
        public static string LongestSubstringWithoutDuplication(string str)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            int i = 0;
            int j = 0;
            int[] longest = { 0, 1 };

            while (i < str.Length && j < str.Length)
            {
                if (map.ContainsKey(str[j]))
                {
                    i = Math.Max(i, map[str[j]] + 1);
                    map[str[j]] = j;
                }
                else
                {
                    map.Add(str[j], j);
                }

                if (longest[1] - longest[0] < j + 1 - i)
                {
                    longest = new int[] { i, j + 1 };
                }
                j++;
            }
            return str.Substring(longest[0], longest[1] - longest[0]);
        }

        public static int LongestSubStringWithKDistinctChars(string s, int k)
        {
            Dictionary<char, int> freqMap = new Dictionary<char, int>();
            int start = 0;
            int end = 0;
            int maxLen = 1;
            int n = s.Length;
            if (n * k == 0) return 0;

            while (end < n)
            {
                if (freqMap.ContainsKey(s[end]))
                {
                    freqMap[s[end]] = freqMap[s[end]] + 1;
                }
                else
                {
                    freqMap.Add(s[end], 1);
                }
                end++;

                if (freqMap.Count > k)
                {
                    // Delete the left(start) pointer from map
                    freqMap[s[start]] = freqMap[s[start]] - 1;
                    if (freqMap[s[start]] == 0)
                        freqMap.Remove(s[start]);
                    // Move left start pointer
                    start++;
                }
                maxLen = Math.Max(maxLen, end - start);
            }
            return maxLen;
        }
    }
}
