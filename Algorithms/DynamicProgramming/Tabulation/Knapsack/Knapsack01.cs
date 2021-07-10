using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming.Tabulation
{
    public class Knapsack01
    {
        public static int GetMaxProfit(int[] wt, int[] profit, int w, int n)
        {
            // i = row = items, j = col = weight of bag
            int[,] dp = new int[n + 1, w + 1];

            for (int i = 0; i < dp.GetLength(0); i++)
            {
                for (int j = 0; j < dp.GetLength(1); j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 0;
                    }
                    else if (wt[i - 1] > j)
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], profit[i - 1] + dp[i - 1, j - wt[i - 1]]);
                    }
                }
            }
            return dp[n, w];
        }
    }
}
