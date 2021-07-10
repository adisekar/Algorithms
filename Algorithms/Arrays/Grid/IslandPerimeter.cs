using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.Grid
{
    public class IslandPerimeter
    {
        public static int GetPerimeter(int[][] grid)
        {
            if (grid.Length == 0) { return 0; }

            int sum = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        sum += 4;

                        // If top is 1, then subtract 2
                        if (i > 0 && grid[i - 1][j] == 1)
                        {
                            sum -= 2;
                        }
                        // If left is 1, then subtract 2
                        if (j > 0 && grid[i][j - 1] == 1)
                        {
                            sum -= 2;
                        }
                    }
                }
            }
            return sum;
        }
    }
}
