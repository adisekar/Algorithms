using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    public class MinPathSum
    {
        public static int MinimumPathSum(int[][] grid)
        {
            int[][] dp = new int[grid.Length][];

            for (int i = 0; i < grid.Length; i++)
            {
                dp[i] = new int[grid[i].Length];
            }

            // Base case.
            dp[0][0] = grid[0][0];

            // For rows. Add prev row value
            for (int i = 1; i < grid.Length; i++)
            {
                dp[i][0] = grid[i][0] + dp[i - 1][0];
            }

            // For columns. Add prev column value
            for (int i = 1; i < grid[0].Length; i++)
            {
                dp[0][i] = grid[0][i] + dp[0][i - 1];
            }


            for (int i = 1; i < grid.Length; i++)
            {
                for (int j = 1; j < grid[0].Length; j++)
                {
                    // Sum of current cell in grid and cell above or left of DP which is CALCULATED
                    int aboveCellSum = dp[i - 1][j] + grid[i][j];
                    int leftCellSum = dp[i][j - 1] + grid[i][j];
                    dp[i][j] = Math.Min(aboveCellSum, leftCellSum);
                }
            }
            return dp[grid.Length - 1][grid[0].Length - 1];
        }
    }
}
