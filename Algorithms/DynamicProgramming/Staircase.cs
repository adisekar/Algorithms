using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    public class Staircase
    {
        static Dictionary<int, int> map = new Dictionary<int, int>() { { 0, 1 }, { 1, 1 } };
        public int ClimbStairsR(int n)
        {
            if (map.ContainsKey(n))
            {
                return map[n];
            }
            else
            {
                map[n] = ClimbStairsR(n - 1) + ClimbStairsR(n - 2);
                return map[n];
            }
        }

        public static int ClimbStairs(int n)
        {
            int[] dp = new int[n + 1];

            dp[0] = 1;
            dp[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }
    }
}
