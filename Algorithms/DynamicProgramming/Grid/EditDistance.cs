using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming.Grid
{
    public class EditDistance
    {
        public static int MinDistance(string word1, string word2)
        {
            int[,] grid = new int[word1.Length + 1, word2.Length + 1];

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    // Set initial values
                    if (i == 0 && j == 0)
                    {
                        // When col and row is 0
                        grid[i, j] = 0;
                    }

                    // When row is 0
                    else if (i == 0)
                    {
                        grid[i, j] = grid[i, j - 1] + 1;
                    }

                    // When col is 0
                    else if (j == 0)
                    {
                        grid[i, j] = grid[i - 1, j] + 1;
                    }

                    else if (word1[i - 1] == word2[j - 1])
                    { // when equal, then get diagnol
                        grid[i, j] = grid[i - 1, j - 1];
                    }
                    else
                    {
                        grid[i, j] = Math.Min(grid[i - 1, j], Math.Min(grid[i - 1, j - 1], grid[i, j - 1])) + 1;
                    }
                }
            }
            return grid[word1.Length, word2.Length];
        }
    }
}
