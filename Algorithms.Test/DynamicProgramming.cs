using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algorithms.Arrays;
using System;
using Algorithms.DynamicProgramming;
using Algorithms.DynamicProgramming.Grid;
using Algorithms.DynamicProgramming.Memoization;
using Algorithms.DynamicProgramming.Memoization.Knapsack;

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

        [TestMethod]
        public void IsSubsetSum()
        {
            int[] set = { 1, 2, 3 };
            int sum = 5;
            SubsetSum subsetSum = new SubsetSum();
            bool result = subsetSum.IsSubsetSum(set, sum);
            Assert.AreEqual(true, result);

            int[] set2 = { 1, 3, 3 };
            int sum2 = 5;
            SubsetSum subsetSum2 = new SubsetSum();
            bool result2 = subsetSum2.IsSubsetSum(set2, sum2);
            Assert.AreEqual(false, result2);

            //int[] set3 = { 1, 2, 5, 7 };
            //int sum3 = 8;
            //SubsetSum subsetSum3 = new SubsetSum();
            //bool result3 = subsetSum3.SubsetSumDP(set3, sum3);
            //Assert.AreEqual(true, result3);
        }

        [TestMethod]
        public void PartitionEqualSubsetSumTest()
        {
            int[] set = { 1, 5, 11, 5 };
            bool result = PartitionEqualSubsetSum.FindEqualPartitions(set);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void MinEditDistance()
        {
            string word1 = "horse";
            string word2 = "ros";
            int result = EditDistance.MinDistance(word1, word2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Tribonacci()
        {
            int n = 7;
            int result = TribonacciNumber.Tribonacci(n);
            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void CanSumTarget()
        {
            int target = 7;
            int[] nums = { 5, 3, 4, 7 };
            bool result = CanSum.CanSumTarget(target, nums);
            Assert.AreEqual(true, result);

            int target2 = 300;
            int[] nums2 = { 7, 14 };
            bool result2 = CanSum.CanSumTarget(target2, nums2);
            Assert.AreEqual(false, result2);
        }

        [TestMethod]
        public void HowSumTarget()
        {
            int target = 7;
            int[] nums = { 5, 3, 4 };
            var result = HowSum.HowSumTarget(target, nums);
            if (result != null)
            {
                foreach (var num in result)
                {
                    Console.WriteLine(num);
                }
            }

            int target2 = 300;
            int[] nums2 = { 7, 14 };
            var result2 = HowSum.HowSumTarget(target2, nums2);
            if (result2 != null)
            {
                foreach (var num in result2)
                {
                    Console.WriteLine(num);
                }
            }
        }

        [TestMethod]
        public void BestSumTarget()
        {
            int target = 7;
            int[] nums = { 5, 3, 4, 7 };
            BestSum bestSum = new BestSum();
            var result = bestSum.BestSumTarget(target, nums);
            if (result != null)
            {
                foreach (var num in result)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();

            int target3 = 8;
            int[] nums3 = { 2, 3, 5 };
            BestSum bestSum2 = new BestSum();
            var result3 = bestSum2.BestSumTarget(target3, nums3);
            if (result3 != null)
            {
                foreach (var num in result3)
                {
                    Console.Write(num + " ");
                }
            }

            Console.WriteLine();
            int target2 = 300;
            int[] nums2 = { 7, 14 };
            BestSum bestSum3 = new BestSum();
            var result2 = bestSum3.BestSumTarget(target2, nums2);
            if (result2 != null)
            {
                foreach (var num in result2)
                {
                    Console.Write(num + " ");
                }
            }
        }

        [TestMethod]
        public void Knapsack01MaxProfit()
        {
            int[] wt = { 3, 2, 4 };
            int[] profit = { 8, 6, 7 };
            int w = 8; // total wt of bag
            int n = 3;
            var result = Knapsack01.GetMaxProfit(wt, profit, w, n - 1);
            Assert.AreEqual(15, result);
        }
    }
}
