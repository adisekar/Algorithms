using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graph.Grid
{
    public class RottingOranges
    {
        public static int MinTime(int[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
            {
                return 0;
            }

            //bool[,] visited = new bool[grid.Length, grid[0].Length];
            int[][] dirs = { new int[] { 1, 0 }, new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 0, -1 } };
            int minMins = 0;

            int freshOranges = 0;
            Queue<Coordinates> queue = new Queue<Coordinates>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        freshOranges++;
                    }
                    if (grid[i][j] == 2)
                    {
                        Coordinates start = new Coordinates(i, j);
                        queue.Enqueue(start);
                        //visited[i, j] = true;
                    }
                }
            }

            if (freshOranges == 0) return 0;

            while (queue.Count > 0)
            {
                // End case if already all fresh oranges are rotten, exit early
                if (freshOranges == 0) return minMins;

                int currentQueueLevel = queue.Count;
                for (int step = 0; step < currentQueueLevel; step++)
                {
                    var cell = queue.Dequeue();

                    foreach (var dir in dirs)
                    {
                        int newX = cell.X + dir[0];
                        int newY = cell.Y + dir[1];

                        if (newX >= 0 && newX < grid.Length && newY >= 0 && newY < grid[0].Length
                            && grid[newX][newY] == 1)
                        {
                            queue.Enqueue(new Coordinates(newX, newY));
                            //visited[newX, newY] = true;
                            grid[newX][newY] = 2;
                            freshOranges--;
                        }
                    }
                }
                minMins++;
            }
            return -1;
        }
    }
}
