using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    class LongestSubstringWithoutRepeating
    {
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> set = new HashSet<char>();
            int left = 0;
            int right = 0;
            int longestSubstrLen = 0;
            while (right < s.Length)
            {
                if (!set.Contains(s[right]))
                {
                    set.Add(s[right]);
                    longestSubstrLen = Math.Max(longestSubstrLen, set.Count);
                    right++;
                }
                else
                {
                    set.Remove(s[left]);
                    left++;
                }
            }
            return longestSubstrLen;
        }
    }
}
