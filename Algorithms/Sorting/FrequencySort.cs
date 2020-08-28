using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Sorting
{
    public class FrequencySort
    {
        public static string Sort(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (var c in s)
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

            var sortedDict = map.OrderByDescending(kv => map[kv.Key]);
            // Better only get keys
            //var sortedKeys = map.Keys.OrderByDescending(k => map[k]);

            StringBuilder sb = new StringBuilder();
            //foreach (var kv in sortedDict)
            //{
            //    // Overload of append 2nd parameter, can repeat string for that
            //    // many times as per map frequency
            //    sb.Append(kv.Key, map[kv.Key]);
            //}

            foreach (var kv in sortedDict)
            {
                // Loop to get copies of key by frequency
                for (int i = 0; i < map[kv.Key]; i++)
                {
                    sb.Append(kv.Key);
                }
            }
            return sb.ToString();
        }
    }
}
