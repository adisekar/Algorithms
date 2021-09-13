using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graph.Grid
{
    public class SurroundedRegions
    {
        private bool seen = false;
        public void Solve(char[][] board)
        {
            if (board == null || board.Length == 0 || board[0].Length == 0)
            {
                return;
            }

            bool[,] visited = new bool[board.Length, board[0].Length];

            // int result = 0;
            for (int i = 1; i < board.Length - 1; i++)
            {
                for (int j = 1; j < board[i].Length - 1; j++)
                {
                    if (board[i][j] == 'O' && !visited[i, j])
                    {
                        seen = false;
                        SeenDFS(board, i, j, visited);

                        if (!seen)
                        {
                            MarkDFS(board, i, j);
                        }
                        seen = true;
                    }
                }
            }
        }

        private void SeenDFS(char[][] grid, int i, int j, bool[,] visited)
        {
            if (i > grid.Length - 1 || i < 0 || j > grid[i].Length - 1 || j < 0 || grid[i][j] == 'X' || visited[i, j])
            {
                return;
            }

            visited[i, j] = true;

            // check if borders contain 'O'
            if ((i == 0 || i == grid.Length - 1) || (j == 0 || j == grid[i].Length - 1))
            {
                seen = true;
            }

            SeenDFS(grid, i + 1, j, visited);
            SeenDFS(grid, i - 1, j, visited);
            SeenDFS(grid, i, j + 1, visited);
            SeenDFS(grid, i, j - 1, visited);
        }

        private void MarkDFS(char[][] grid, int i, int j)
        {
            if (i > grid.Length - 1 || i < 0 || j > grid[i].Length - 1 || j < 0 || grid[i][j] == 'X')
            {
                return;
            }

            grid[i][j] = 'X';

            MarkDFS(grid, i + 1, j);
            MarkDFS(grid, i - 1, j);
            MarkDFS(grid, i, j + 1);
            MarkDFS(grid, i, j - 1);
        }

        // 2nd Approach, using 1 DFS to set value as 1 if connected on borders
        // And reset after
        public void Solve2(char[][] board)
        {
            if (board == null || board.Length == 0 || board[0].Length == 0)
            {
                return;
            }

            bool[,] visited = new bool[board.Length, board[0].Length];
            int row = board.Length;
            int col = board[0].Length;
            // Top left to right
            for (int i = 0; i < col; i++)
            {
                DFS(board, 0, i, visited);
                DFS(board, row - 1, i, visited);
            }
            // Left and right top to bottom
            for (int i = 0; i < row; i++)
            {
                DFS(board, i, 0, visited);
                DFS(board, i, col - 1, visited);
            }

            // Loop over to reset values 
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == 'O')
                    {
                        board[i][j] = 'X';
                    }
                    else if (board[i][j] == '1')
                    {
                        board[i][j] = 'O';
                    }
                }
            }
        }

        private void DFS(char[][] grid, int i, int j, bool[,] visited)
        {
            if (i > grid.Length - 1 || i < 0 || j > grid[i].Length - 1 || j < 0 || grid[i][j] == 'X' || visited[i, j])
            {
                return;
            }

            visited[i, j] = true;

            // check if borders contain 'O'
            if (grid[i][j] == 'O')
            {
                grid[i][j] = '1';
            }

            DFS(grid, i + 1, j, visited);
            DFS(grid, i - 1, j, visited);
            DFS(grid, i, j + 1, visited);
            DFS(grid, i, j - 1, visited);
        }

        // Almost same as Solve2
        public void SolveBest(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if ((i == 0 || i == board.Length - 1) || (j == 0 || j == board[i].Length - 1))
                    {
                        if (board[i][j] == 'O')
                        {
                            DFSBest(board, i, j);
                        }
                    }
                }
            }

            // Loop m*n again and change 1 to O and change O to X
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    // Middle items, not connected to border are surrounded
                    if (board[i][j] == 'O')
                    {
                        board[i][j] = 'X';
                    }
                    else if (board[i][j] == '1')
                    {
                        board[i][j] = 'O';
                    }
                }
            }
        }

        private void DFSBest(char[][] board, int i, int j)
        {
            // Guard check
            if (i < 0 || i > board.Length - 1 || j < 0 || j > board[i].Length - 1 || board[i][j] != 'O')
            {
                return;
            }

            if (board[i][j] == 'O')
            {
                board[i][j] = '1';
            }
            DFSBest(board, i + 1, j);
            DFSBest(board, i - 1, j);
            DFSBest(board, i, j + 1);
            DFSBest(board, i, j - 1);
        }
    }
}
