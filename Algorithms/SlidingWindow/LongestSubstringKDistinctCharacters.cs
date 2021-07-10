using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.SlidingWindow
{
    public class LongestSubstringKDistinctCharacters
    {
        public static int LengthOfLongestSubstringKDistinct(string s, int k)
        {
            int l = 0;
            int r = 0;
            int max = 0;
            k = k + 1;
            // last index of character map
            Dictionary<Char, int> map = new Dictionary<Char, int>(); // last index map

            while (r < s.Length && l <= r)
            {
                if (map.ContainsKey(s[r]))
                {
                    map[s[r]] = r;
                }
                else
                {
                    map.Add(s[r], r);
                }

                if (map.Count == k)
                {
                    // Get smallest index from map. Can use minHeap
                    var sortedMap = map.OrderBy(e => e.Value);
                    var kv = sortedMap.First();
                    map.Remove(kv.Key);
                    l = kv.Value + 1; // left = smallest index + 1
                }
                max = Math.Max(max, r - l + 1);
                r++;
            }
            return max;
        }
    }
}
