using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.HashMap
{
    public class CommonCharacters
    {
        public static IList<string> CommonChars(string[] A)
        {
            IList<string> result = new List<string>();
            Dictionary<char, int> map = new Dictionary<char, int>();

            // Guard Clause
            if (A.Length == 0)
            {
                return result;
            }
            // Get master count of first word frequency
            foreach (var c in A[0])
            {
                if (map.ContainsKey(c))
                {
                    map[c]++;
                }
                else
                {
                    map.Add(c, 1);
                }
            }

            // Loop thru rest of words, and compare with master map
            for (int i = 1; i < A.Length; i++)
            {
                string word = A[i];
                // Get count freq of current word
                Dictionary<char, int> currentCountMap = new Dictionary<char, int>();
                foreach (var c in word)
                {
                    if (currentCountMap.ContainsKey(c))
                    {
                        currentCountMap[c]++;
                    }
                    else
                    {
                        currentCountMap.Add(c, 1);
                    }
                }

                GetIntersection(map, currentCountMap);
            }

            foreach (var kv in map)
            {
                for (int i = 0; i < kv.Value; i++)
                {
                    result.Add(kv.Key.ToString());
                }
            }
            return result;
        }

        private static void GetIntersection(Dictionary<char, int> map, Dictionary<char, int> currentCountMap)
        {
            // Need to store keys in array, as we cannot enumerate and remove
            char[] keys = map.Keys.ToArray();
            foreach (var key in keys)
            {
                if (!currentCountMap.ContainsKey(key))
                {
                    map.Remove(key);
                }
                else
                {
                    // Take lowest of frequency count in both maps
                    map[key] = Math.Min(map[key], currentCountMap[key]);
                }
            }
        }
    }
}
