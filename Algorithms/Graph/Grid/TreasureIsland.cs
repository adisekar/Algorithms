using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graph.Grid
{
    /* Treasure Island
    You have a map that marks the location of a treasure island. Some of the map area has jagged rocks and dangerous reefs. Other areas are safe to sail in. There are other explorers trying to find the treasure. So you must figure out a shortest route to the treasure island.

    Assume the map area is a two dimensional grid, represented by a matrix of characters. You must start from the top-left corner of the map and can move one block up, down, left or right at a time. The treasure island is marked as X in a block of the matrix. X will not be at the top-left corner. Any block with dangerous rocks or reefs will be marked as D. You must not enter dangerous blocks. You cannot leave the map area. Other areas O are safe to sail in. The top-left corner is always safe. Output the minimum number of steps to get to the treasure.

    Example:

    Input:
    [['O', 'O', 'O', 'O'],
     ['D', 'O', 'D', 'O'],
     ['O', 'O', 'O', 'O'],
     ['X', 'D', 'D', 'O']]

    Output: 5
    Explanation: Route is (0, 0), (0, 1), (1, 1), (2, 1), (2, 0), (3, 0) The minimum route takes 5 steps.
         */
    public class TreasureIsland
    {
        public static int MinSteps(char[][] grid)
        {
            int minSteps = BFS(grid, new Coordinates(0, 0));
            return minSteps;
        }

        private static int BFS(char[][] grid, Coordinates start)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
            {
                return 0;
            }

            Queue<Coordinates> queue = new Queue<Coordinates>();
            queue.Enqueue(new Coordinates(start.X, start.Y));

            bool[,] visited = new bool[grid.Length, grid[0].Length];
            visited[0, 0] = true;

            int[][] dirs = new int[][] { new int[] { 1, 0 }, new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 0, -1 } };
            int minSteps = 0;

            while (queue.Count > 0)
            {
                int queueCurrentLevel = queue.Count;
                for (int i = 0; i < queueCurrentLevel; i++)
                {
                    var cell = queue.Dequeue();

                    // Success case
                    if (grid[cell.X][cell.Y] == 'X')
                    {
                        return minSteps;
                    }

                    foreach (int[] dir in dirs)
                    {
                        int newX = cell.X + dir[0];
                        int newY = cell.Y + dir[1];

                        if ((newX >= 0 && newX < grid.Length) && (newY >= 0 && newY < grid[0].Length)
                            && !visited[newX, newY] && grid[newX][newY] != 'D')
                        {
                            queue.Enqueue(new Coordinates(newX, newY));
                            visited[newX, newY] = true;
                        }
                    }
                }
                minSteps++;
            }
            return minSteps;
        }

        /*
         * You have a map that marks the locations of treasure islands. Some of the map area has jagged rocks and dangerous reefs. Other areas are safe to sail in. There are other explorers trying to find the treasure. So you must figure out a shortest route to one of the treasure islands.

        Assume the map area is a two dimensional grid, represented by a matrix of characters. You must start from one of the starting point (marked as S) of the map and can move one block up, down, left or right at a time. The treasure island is marked as X. Any block with dangerous rocks or reefs will be marked as D. You must not enter dangerous blocks. You cannot leave the map area. Other areas O are safe to sail in. Output the minimum number of steps to get to any of the treasure islands.

        Example:

        Input:
        [['S', 'O', 'O', 'S', 'S'],
            ['D', 'O', 'D', 'O', 'D'],
            ['O', 'O', 'O', 'O', 'X'],
            ['X', 'D', 'D', 'O', 'O'],
            ['X', 'D', 'D', 'D', 'O']]

        Output: 3
        Explanation:
        You can start from (0,0), (0, 3) or (0, 4). The treasure locations are (2, 4) (3, 0) and (4, 0). Here the shortest route is (0, 3), (1, 3), (2, 3), (2, 4).
         */
        public static int MinStepsMultipleStart(char[][] grid)
        {
            int minSteps = int.MaxValue;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid.Length; j++)
                {
                    if (grid[i][j] == 'S')
                    {
                        // Call BFS from each start node
                        int currentPathStep = BFS(grid, new Coordinates(i, j));
                        minSteps = Math.Min(minSteps, currentPathStep);
                    }
                }
            }

            return minSteps == int.MaxValue ? 0 : minSteps;
        }
    }

    public class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinates(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
