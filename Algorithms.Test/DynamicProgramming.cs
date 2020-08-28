using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algorithms.Arrays;
using System;
using Algorithms.DynamicProgramming;
using Algorithms.DynamicProgramming.Grid;

namespace Algorithms.Test
{
    [TestClass]
    public class DynamicProgramming
    {
        [TestMethod]
        public void ClimbStairs()
        {
            var result = Staircase.ClimbStairs(4);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void HouseRobberTest()
        {
            int[] nums = { 1, 2, 3, 1 };
            var result = HouseRobber.Rob(nums);
            Assert.AreEqual(4, result);

            int[] nums2 = { 1, 3, 1, 3, 100 };
            var result2 = HouseRobber.Rob2(nums2);
            Assert.AreEqual(103, result2);
        }

        [TestMethod]
        public void LCS()
        {
            string text1 = "abcde";
            string text2 = "ace";
            var result = LongestCommonSubsequence.GetLength(text1, text2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void UniquePathsNoObstacles()
        {
            int m = 3;
            int n = 2;
            int result = UniquePaths.NoObstacles(m, n);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void UniquePathsWithObstacles()
        {
            int[][] obstacleGrid = new int[3][];
            obstacleGrid[0] = new int[] { 0, 0, 0 };
            obstacleGrid[1] = new int[] { 0, 1, 0 };
            obstacleGrid[2] = new int[] { 0, 0, 0 };

            int result = UniquePaths.WithObstacles(obstacleGrid);
            Assert.AreEqual(2, result);

            int[][] obstacleGrid2 = new int[1][];
            obstacleGrid2[0] = new int[] { 1, 0 };
            int result2 = UniquePaths.WithObstacles(obstacleGrid2);
            Assert.AreEqual(0, result2);
        }

        [TestMethod]
        public void MinPathSumGrid()
        {
            int[][] grid = new int[3][];
            grid[0] = new int[] { 1, 3, 1 };
            grid[1] = new int[] { 1, 5, 1 };
            grid[2] = new int[] { 4, 2, 1 };

            int result = MinPathSum.MinimumPathSum(grid);
            Assert.AreEqual(7, result);
        }
    }
}
