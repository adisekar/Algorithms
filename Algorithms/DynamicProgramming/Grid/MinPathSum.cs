using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    public class MinPathSum
    {
        public static int MinimumPathSum(int[][] grid)
        {
            int[,] dp = new int[grid.Length, grid[0].Length];

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (i > 0 && i < grid.Length && j > 0 && j < grid[0].Length)
                    {
                        dp[i, j] = grid[i][j] + Math.Min(dp[i - 1, j], dp[i, j - 1]);
                    }
                    else if (i == 0)
                    {
                        // First cell
                        if (j == 0)
                        {
                            dp[i, j] = grid[i][j];
                        }
                        else
                        {
                            dp[i, j] = dp[i, j - 1] + grid[i][j];
                        }
                    }
                    else if (j == 0)
                    {
                        // First cell
                        if (i == 0)
                        {
                            dp[i, j] = grid[i][j];
                        }
                        else
                        {
                            dp[i, j] = dp[i - 1, j] + grid[i][j];
                        }
                    }
                }
            }
            return dp[grid.Length - 1, grid[0].Length - 1];
        }

        public int MinPathSumRecursive(int[][] grid)
        {
            return MinPathSumHelper(grid, 0, 0);
        }

        private int MinPathSumHelper(int[][] grid, int i, int j)
        {
            // Boundary cases
            if (i >= grid.Length || j >= grid[0].Length)
            {
                return int.MaxValue;
            }

            // Base case
            if (i == grid.Length - 1 && j == grid[0].Length - 1)
            {
                return grid[i][j];
            }
            return grid[i][j] + Math.Min(MinPathSumHelper(grid, i, j + 1), MinPathSumHelper(grid, i + 1, j));
        }
    }
}
