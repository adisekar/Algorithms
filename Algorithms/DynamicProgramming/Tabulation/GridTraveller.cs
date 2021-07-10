using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming.Tabulation
{
    public class GridTraveller
    {
        public int UniquePaths(int m, int n)
        {
            int[,] dp = new int[m + 1, n + 1];

            for (int i = 1; i < dp.GetLength(0); i++)
            {
                for (int j = 1; j < dp.GetLength(1); j++)
                {
                    if (i == 1 && j == 1)
                    {
                        dp[i, j] = 1;
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                    }
                }
            }
            return dp[m, n];
        }
    }
}
