using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.SlidingWindow
{
    public class LongestSubstringWithoutRepeating
    {
        public static int LengthOfLongestSubstring(string s)
        {
            HashSet<char> set = new HashSet<char>();
            int left = 0;
            int right = 0;
            int maxLen = 0;
            while (right < s.Length)
            {
                if (!set.Contains(s[right]))
                {
                    set.Add(s[right]);
                    maxLen = Math.Max(maxLen, set.Count);
                    right++;
                }
                else    // Slide window of substr to remove 1 char from left
                {
                    set.Remove(s[left]);
                    left++;
                }
            }
            return maxLen;
        }
    }
}
