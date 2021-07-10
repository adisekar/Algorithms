using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming.Memoization
{
    public class GridTraveller
    {
        Dictionary<string, int> map = new Dictionary<string, int>() { };
        public int UniquePaths(int m, int n)
        {
            string key = m + "," + n;
            string key2 = n + "," + m;

            if (map.ContainsKey(key))
            {
                return map[key];
            }
            if (map.ContainsKey(key2))
            {
                return map[key2];
            }
            // Base case
            if (m == 1 && n == 1)
            {
                return 1;
            }

            if (m == 0 || n == 0)
            {
                return 0;
            }

            map[key] = UniquePaths(m - 1, n) + UniquePaths(m, n - 1);
            return map[key];
        }
    }
}
