using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming.Tabulation.Knapsack
{
    public class SubsetSum
    {
        public static bool SubsetSumDP(int[] set, int sum)
        {
            // Create rows as set values, and columns as sum values
            // + 1 to include/ start with 0
            bool[,] dp = new bool[set.Length + 1, sum + 1];

            // set initial values
            // rows, items as rows. items are elements in set/array
            // If sum count is 0, then we can achieve this by excluding all items
            for (int i = 0; i < dp.GetLength(0); i++)
            {
                dp[i, 0] = true;
            }
            // columns, sum as columns.
            // when no items are used, only sum 0 is achieved, rest are all false
            for (int i = 1; i < dp.GetLength(1); i++)
            {
                dp[0, i] = false;
            }

            for (int i = 1; i < dp.GetLength(0); i++)
            {
                for (int j = 1; j < dp.GetLength(1); j++)
                {
                    int setIndex = i - 1;
                    // If set val is > than sum col, then assign prev row value
                    if (set[setIndex] > j)
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                    else
                    {
                        // Include or exclude value ||
                        // Exclude is done by taking value in row above
                        // Include is by taking difference between, and checking that column 
                        int diff = j - set[setIndex];
                        dp[i, j] = dp[i - 1, j] || dp[i - 1, diff];
                    }
                }
            }
            return dp[set.Length, sum];
        }
    }
}
