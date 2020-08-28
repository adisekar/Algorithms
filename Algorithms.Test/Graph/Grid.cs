using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algorithms.Arrays;
using System;
using Algorithms.Graph.Grid;
using DS.Graph;

namespace Algorithms.Test
{
    [TestClass]
    public class Grid
    {
        [TestMethod]
        public void TreasureIsland1()
        {
            char[][] obstacleGrid = {new char[] {'O', 'O', 'O', 'O' },
                                     new char[] {'D', 'O', 'D', 'O' },
                                     new char [] {'O', 'O', 'O', 'O' },
                                     new char [] {'X', 'D', 'D', 'O' }
                                        };

            int result = TreasureIsland.MinSteps(obstacleGrid);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TreasureIsland2()
        {
            char[][] obstacleGrid = {new char[] {'S','O', 'O', 'S', 'S' },
                                     new char[] {'D', 'O', 'D', 'O', 'D' },
                                     new char [] {'O', 'O', 'O', 'O', 'X' },
                                     new char [] {'X', 'D', 'D', 'O', 'O' },
                                     new char [] {'X', 'D', 'D', 'D', 'O' }
                                        };

            int result = TreasureIsland.MinStepsMultipleStart(obstacleGrid);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void NumIslandsDFS()
        {
            char[][] grid = {new char[] {'1', '1','1', '1', '0' },
                                     new char[] {'1', '1', '0', '1', '0' },
                                     new char [] {'1', '1', '0', '0', '0' },
                                     new char [] {'0', '0', '0', '0', '0' }
                                        };

            int result = NumberOfIslands.NumIslandsDFS(grid);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void NumIslandsBFS()
        {
            char[][] grid = {new char[] {'1', '1','1', '1', '0' },
                                     new char[] {'1', '1', '0', '1', '0' },
                                     new char [] {'1', '1', '0', '0', '0' },
                                     new char [] {'0', '0', '0', '0', '0' }
                                        };

            int result = NumberOfIslands.NumIslandsBFS(grid);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SurroundedRegionsDFS()
        {
            char[][] grid = {new char[] {'X', 'X','X', 'X'},
                                     new char[] {'X', 'O', 'O', 'X', '0' },
                                     new char [] {'X', 'X', 'O', 'X'},
                                     new char [] {'X', 'O', 'X', 'X' }
                                        };

            SurroundedRegions.Solve(grid);
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    Console.Write(grid[i][j]);
                }
                Console.WriteLine();
            }
        }

        [TestMethod]
        public void RottingOrangesBFS()
        {
            int[][] grid = {new int[] {2,1,1 },
                            new int[] {1,1,0 },
                            new int [] {0,1,1 }
                            };

            int result = RottingOranges.MinTime(grid);
            Assert.AreEqual(4, result);

            int[][] grid2 = {new int[] {1 },
                            new int[] {2 },
                            new int [] {2 }
                            };

            int result2 = RottingOranges.MinTime(grid2);
            Assert.AreEqual(1, result2);

            // If multiple rotten oranges (2) , need to return min time based on closes rotten orange
            int[][] grid3 = {new int[] {2,2,2,1,1 }
                            };
            int result3 = RottingOranges.MinTime(grid3);
            Assert.AreEqual(2, result3);
        }

        [TestMethod]
        public void ZombieInfestationDFS()
        {
            /*
             * [[0, 1, 1, 0, 1],
 [0, 1, 0, 1, 0],
 [0, 0, 0, 0, 1],
 [0, 1, 0, 0, 0]] 
 Output = 2
*/
            List<List<int>> grid = new List<List<int>>() {
                new List<int>() { 0, 1, 1, 0, 1 },
                new List<int>() { 0, 1, 0, 1, 0},
                new List<int>() {0, 0, 0, 0, 1},
                new List<int>() { 0, 1, 0, 0, 0 }
            };

            int result = ZombieInfestation.MinTime(4, 5, grid);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void WordSearch1()
        {
            char[][] board = {new char[] {'A', 'B', 'C', 'E' },
                                     new char[] {'S', 'F', 'C', 'S' },
                                     new char [] {'A', 'D', 'E', 'E' }
                                        };
            string word = "ABCCED";
            var result = WordSearch.Exist(board, word);
            Assert.AreEqual(true, result);
        }
    }
}
