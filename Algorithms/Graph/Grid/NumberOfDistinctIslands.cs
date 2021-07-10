using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graph.Grid
{
    public class NumberOfDistinctIslands
    {
        HashSet<string> shapeSet = new HashSet<string>();
        StringBuilder dir = new StringBuilder();

        // Use dir string, which is added to shape set. Based on this we record for each recursion step as  
        // Up,down, left, right, start and blocked path as o. If 2 islands have same sequence, then they are same
        public int NumDistinctIslands(int[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
            {
                return 0;
            }

            // int numIslands = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        // numIslands++;
                        DFS(grid, i, j, dir.Append("x"));
                        shapeSet.Add(dir.ToString());
                        dir.Clear();
                    }
                }
            }
            return shapeSet.Count;
        }

        private void DFS(int[][] grid, int i, int j, StringBuilder dir)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] != 1)
            {
                dir.Append("o");
                return;
            }

            grid[i][j] = 0;

            DFS(grid, i + 1, j, dir.Append("r"));
            DFS(grid, i - 1, j, dir.Append("l"));
            DFS(grid, i, j + 1, dir.Append("u"));
            DFS(grid, i, j - 1, dir.Append("d"));
        }
    }
}
