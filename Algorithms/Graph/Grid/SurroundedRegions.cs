using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graph.Grid
{
    public class SurroundedRegions
    {
        public static void Solve(char[][] board)
        {
            if (board == null || board.Length == 0 || board[0].Length == 0)
            {
                return;
            }

            // int result = 0;
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == 'X')
                    {
                        // result++;
                        DFS(board, i, j);
                    }
                }
            }

            // Make visited Z to X
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == 'Z')
                    {
                        // result++;
                        board[i][j] = 'X';
                    }
                }
            }
        }

        private static void DFS(char[][] grid, int i, int j)
        {
            if (i >= grid.Length || i < 0 || j >= grid[i].Length || j < 0 || grid[i][j] == 'X'
              || grid[i][j] == 'Z')
            {
                return;
            }

            if (i != 0 && i != grid.Length - 1 && j != 0 && j != grid.Length - 1)
            {
                // Mark current as visited
                grid[i][j] = 'Z';
            }

            DFS(grid, i + 1, j);
            DFS(grid, i - 1, j);
            DFS(grid, i, j + 1);
            DFS(grid, i, j - 1);
        }
    }
}
