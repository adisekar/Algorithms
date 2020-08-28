using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graph.Grid
{
    /*
     * Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

        Example 1:

        Input:
        11110
        11010
        11000
        00000

        Output: 1
        Example 2:

        Input:
        11000
        11000
        00100
        00011

        Output: 3
        */
    public class NumberOfIslands
    {
        public static int NumIslandsDFS(char[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
            {
                return 0;
            }

            int numIslands = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    // Check if land
                    if (grid[i][j] == '1')
                    {
                        DFS(grid, i, j);
                        numIslands++;
                    }
                }
            }
            return numIslands;
        }

        private static void DFS(char[][] grid, int i, int j)
        {
            // Check boundary
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length
                || grid[i][j] == '0' || grid[i][j] == '2')
            {
                return;
            }


            // Set current cell as visited, as 2. Can also use '0', instead of 2
            grid[i][j] = '2';

            DFS(grid, i + 1, j);
            DFS(grid, i - 1, j);
            DFS(grid, i, j + 1);
            DFS(grid, i, j - 1);
        }

        public static int NumIslandsBFS(char[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
            {
                return 0;
            }

            int numIslands = 0;
            int[][] dirs = { new int[] { 1,0}, new int[] {-1, 0}, new int[] {0, 1}, new
                    int[] {0, -1}};

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    // Check if land
                    if (grid[i][j] == '1')
                    {
                        numIslands++;
                        Queue<Coordinates> queue = new Queue<Coordinates>();
                        queue.Enqueue(new Coordinates(i, j));
                        // Mark visited as 0
                        grid[i][j] = '0';

                        while (queue.Count > 0)
                        {
                            var cell = queue.Dequeue();
                            foreach (var dir in dirs)
                            {
                                int newX = cell.X + dir[0];
                                int newY = cell.Y + dir[1];

                                if ((newX >= 0 && newX < grid.Length) && (newY >= 0 && newY < grid[i].Length) &&
                                    grid[newX][newY] == '1')
                                {
                                    queue.Enqueue(new Coordinates(newX, newY));
                                    // Mark new coordinate as visited as 0
                                    grid[newX][newY] = '0';
                                }
                            }
                        }
                    }
                }
            }
            return numIslands;
        }
    }
}
