using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graph.Grid
{
    /*
     * Given a 2D grid, each cell is either a zombie 1 or a human 0. Zombies can turn adjacent (up/down/left/right) human beings into zombies every hour. Find out how many hours does it take to infect all humans?

Example:

Input:
[[0, 1, 1, 0, 1],
 [0, 1, 0, 1, 0],
 [0, 0, 0, 0, 1],
 [0, 1, 0, 0, 0]]

Output: 2

Explanation:
At the end of the 1st hour, the status of the grid:
[[1, 1, 1, 1, 1],
 [1, 1, 1, 1, 1],
 [0, 1, 0, 1, 1],
 [1, 1, 1, 0, 1]]

At the end of the 2nd hour, the status of the grid:
[[1, 1, 1, 1, 1],
 [1, 1, 1, 1, 1],
 [1, 1, 1, 1, 1],
 [1, 1, 1, 1, 1]]
 */
    public class ZombieInfestation
    {
        public static int MinTime(int rows, int columns, List<List<int>> grid)
        {
            if (grid == null || grid.Count == 0 || grid[0].Count == 0)
            {
                return 0;
            }

            int[][] dirs = { new int[] { 1, 0 }, new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 0, -1 } };
            int hours = 0;
            int population = grid.Count * grid[0].Count;
            int human = 0;
            int zombie = 0;

            Queue<Coordinates> queue = new Queue<Coordinates>();
            for (int i = 0; i < grid.Count; i++)
            {
                for (int j = 0; j < grid[i].Count; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        human++;
                    }
                    if (grid[i][j] == 1)
                    {
                        zombie++;
                        Coordinates start = new Coordinates(i, j);
                        queue.Enqueue(start);
                        //visited[i, j] = true;
                    }
                }
            }

            while (queue.Count > 0)
            {
                // End case, if whole grid is zombies only
                if (zombie == population)
                {
                    return hours;
                }

                int currentQueueLevel = queue.Count;
                for (int step = 0; step < currentQueueLevel; step++)
                {
                    var cell = queue.Dequeue();

                    foreach (var dir in dirs)
                    {
                        int newX = cell.X + dir[0];
                        int newY = cell.Y + dir[1];

                        if (newX >= 0 && newX < grid.Count && newY >= 0 && newY < grid[0].Count
                            && grid[newX][newY] == 0)
                        {
                            queue.Enqueue(new Coordinates(newX, newY));
                            grid[newX][newY] = 1;
                            zombie++;
                        }
                    }
                }
                hours++;
            }
            // If target dont match.
            return -1;
        }
    }
}
