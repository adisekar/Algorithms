using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    // Robot Travelling from top left to bottom right. Same as total number of ways
    public class UniquePaths
    {
        // m and n are rows/columns. Unique Path 1
        public static int NoObstacles(int m, int n)
        {
            int[,] dp = new int[m, n];

            // Base case, fill first row and column with 1, as it takes one way to reach.
            for (int i = 0; i < dp.GetLength(0); i++)
            {
                dp[i, 0] = 1;
            }
            for (int i = 0; i < dp.GetLength(1); i++)
            {
                dp[0, i] = 1;
            }

            for (int i = 1; i < dp.GetLength(0); i++)
            {
                for (int j = 1; j < dp.GetLength(1); j++)
                {
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }

            return dp[m - 1, n - 1];
        }

        public static int WithObstacles(int[][] obstacleGrid)
        {
            if (obstacleGrid == null || obstacleGrid.Length == 0 || obstacleGrid[0].Length == 0)
            {
                return 0;
            }

            int[][] dp = new int[obstacleGrid.Length][];
            for (int i = 0; i < obstacleGrid.Length; i++)
            {
                dp[i] = new int[obstacleGrid[i].Length];
            }

            // Base case, fill first row and column with 1, as it takes one way to reach.
            for (int i = 0; i < dp.Length; i++)
            {
                if (obstacleGrid[i][0] != 1)
                {
                    dp[i][0] = 1;
                }
                else // Stop going down in first column, if obstacle
                {
                    break;
                }
            }
            for (int i = 0; i < dp[0].Length; i++)
            {
                if (obstacleGrid[0][i] != 1)
                {
                    dp[0][i] = 1;
                }
                else // Stop going right in first row, if obstacle
                {
                    break;
                }
            }

            for (int i = 1; i < dp.Length; i++)
            {
                for (int j = 1; j < dp[0].Length; j++)
                {
                    if (obstacleGrid[i][j] != 1)
                    {
                        dp[i][j] = dp[i - 1][j] + dp[i][j - 1];
                    }
                }
            }
            return dp[obstacleGrid.Length - 1][obstacleGrid[0].Length - 1];
        }
    }
}
