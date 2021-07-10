using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algorithms.Arrays;
using System;
using Algorithms.DynamicProgramming.Tabulation;
using Algorithms.DynamicProgramming.Tabulation.Knapsack;
using Algorithms.DynamicProgramming;

namespace Algorithms.Test
{
    [TestClass]
    public class DynamicProgrammingTabulation
    {
        [TestMethod]
        public void FibonacciNumberTest()
        {
            var result = FibonacciNumber.Fib(7);
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void CanSumTarget()
        {
            int target = 7;
            int[] nums = { 5, 3, 4 };
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
            int[] nums = { 5, 3, 4, 7 };
            var result = HowSum.HowSumTarget(target, nums);
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }

            int target2 = 300;
            int[] nums2 = { 7, 14 };
            var result2 = HowSum.HowSumTarget(target2, nums2);
            if (result2 != null)
            {
                foreach (int num in result2)
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
            var result = BestSum.BestSumTarget(target, nums);
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }

            int target2 = 300;
            int[] nums2 = { 7, 14 };
            var result2 = BestSum.BestSumTarget(target2, nums2);
            if (result2 != null)
            {
                foreach (int num in result2)
                {
                    Console.WriteLine(num);
                }
            }

            int target3 = 8;
            int[] nums3 = { 2, 3, 5 };
            var result3 = BestSum.BestSumTarget(target3, nums3);
            foreach (int num in result3)
            {
                Console.WriteLine(num);
            }
        }

        [TestMethod]
        public void CoinChangeCombinations()
        {
            int target = 5;
            int[] coins = { 1, 2, 5 };
            CoinChange coinChange = new CoinChange();
            var result = coinChange.Change(target, coins);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Knapsack01MaxProfit()
        {
            int[] wt = { 3, 2, 4 };
            int[] profit = { 8, 6, 7 };
            int w = 8; // total wt of bag
            int n = 3;
            var result = Knapsack01.GetMaxProfit(wt, profit, w, n);
            Assert.AreEqual(15, result);

            int[] wt2 = { 1, 2, 3 };
            int[] profit2 = { 2, 3, 5 };
            int w2 = 4; // total wt of bag
            int n2 = 3;
            var result2 = Knapsack01.GetMaxProfit(wt2, profit2, w2, n2);
            Assert.AreEqual(7, result2);
        }

        [TestMethod]
        public void IsSubsetSum()
        {
            int[] set = { 1, 2, 3 };
            int sum = 5;
            bool result = SubsetSum.SubsetSumDP(set, sum);
            Assert.AreEqual(true, result);

            int[] set2 = { 1, 3, 3 };
            int sum2 = 5;
            bool result2 = SubsetSum.SubsetSumDP(set2, sum2);
            Assert.AreEqual(false, result2);

            int[] set3 = { 1, 2, 5, 7 };
            int sum3 = 8;
            bool result3 = SubsetSum.SubsetSumDP(set3, sum3);
            Assert.AreEqual(true, result3);
        }

        [TestMethod]
        public void PartitionEqualSubsetSumTest()
        {
            int[] set = { 1, 5, 11, 5 };
            bool result = PartitionEqualSubsetSum.FindEqualPartitions(set);
            Assert.AreEqual(true, result);
        }


        [TestMethod]
        public void MinPathSumTest()
        {
            int[][] grid = { new int[] { 1, 3, 1 }, new int[] { 1, 5, 1 }, new int[] { 4, 2, 1 } };
            //int[][] grid = { new int[] { 1, 2 }, new int[] { 1, 3 } }; Result = 5
            MinPathSum minPathSum = new MinPathSum();
            int result = minPathSum.MinPathSumRecursive(grid);
            Assert.AreEqual(7, result);
        }
    }
}
