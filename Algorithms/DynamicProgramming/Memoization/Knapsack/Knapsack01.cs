using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming.Memoization
{
    public class Knapsack01
    {
        static Dictionary<int, int> map = new Dictionary<int, int>();
        public static int GetMaxProfit(int[] wt, int[] profit, int w, int n)
        {
            if (map.ContainsKey(w)) { return map[n]; }
            // Base case
            if (w == 0 || n < 0)
            {
                return 0;
            }

            // Exclude
            if (wt[n] > w)
            {
                map[w] = GetMaxProfit(wt, profit, w, n - 1);
                return map[w];
            }
            else  // Include or exclude item. First param is to exclude, and second is include so profit of adding item and reducing wt
            {
                map[w] = Math.Max(GetMaxProfit(wt, profit, w, n - 1), profit[n] + GetMaxProfit(wt, profit, w - wt[n], n - 1));
                return map[w];
            }
        }
    }
}
