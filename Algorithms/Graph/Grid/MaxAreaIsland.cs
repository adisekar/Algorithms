using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graph.Grid
{
    public class MaxAreaIsland
    {
        // Can also do using global count, instead of recursion + and adding 1
        // private int currMaxArea = 0;
        public int MaxAreaOfIsland(int[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
            {
                return 0;
            }

            int maxArea = 0;


            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        maxArea = Math.Max(DFS(grid, i, j), maxArea);
                        //currMaxArea = 0;
                    }
                }
            }
            return maxArea;
        }

        private int DFS(int[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] != 1)
            {
                return 0;
            }

            grid[i][j] = 0;
            //currMaxArea++;

            return DFS(grid, i + 1, j) + DFS(grid, i - 1, j) + DFS(grid, i, j + 1) + DFS(grid, i, j - 1) + 1;
        }
    }
}
