using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graph.Grid
{
    /*
     * image = [[1,1,1],[1,1,0],[1,0,1]]
sr = 1, sc = 1, newColor = 2
Output: [[2,2,2],[2,2,0],[2,0,1]]
Explanation: 
From the center of the image (with position (sr, sc) = (1, 1)), all pixels connected 
by a path of the same color as the starting pixel are colored with the new color.
Note the bottom corner is not colored 2, because it is not 4-directionally connected
to the starting pixel.
*/
    public class FloodFill
    {
        public int[][] FloodFillDFS(int[][] image, int sr, int sc, int newColor)
        {
            if (image == null || image.Length == 0 || image[0].Length == 0)
            {
                return image;
            }

            int sourceColor = image[sr][sc];
            DFS(image, sr, sc, newColor, sourceColor);
            return image;
        }

        private static void DFS(int[][] grid, int i, int j, int newColor, int sourceColor)
        {
            // Check boundary
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length
                || grid[i][j] == newColor || grid[i][j] != sourceColor)
            {
                return;
            }

            grid[i][j] = newColor;

            DFS(grid, i + 1, j, newColor, sourceColor);
            DFS(grid, i - 1, j, newColor, sourceColor);
            DFS(grid, i, j + 1, newColor, sourceColor);
            DFS(grid, i, j - 1, newColor, sourceColor);
        }
    }
}