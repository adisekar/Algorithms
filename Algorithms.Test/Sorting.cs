using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algorithms.Sorting;
using System;

namespace Algorithms.Test
{
    [TestClass]
    public class Sorting
    {

        [TestMethod]
        public void FrequencySortString()
        {
            string s = "tree";
            var result = FrequencySort.Sort(s);
            Assert.AreEqual("eetr", result);
        }

        [TestMethod]
        public void SortColors()
        {
            int[] nums = { 1, 0, 2, 1, 0, 0, 0, 2, 2, 1, 1, 1, 1, 0 };
            DutchNationalFlag.SortColors(nums);
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
        }

        [TestMethod]
        public void QuickSortTest()
        {
            int[] nums = { 11, 13, 7, 12, 16, 9, 24, 5, 10, 3, Int32.MaxValue };
            QuickSort.Sort(nums, 0, 10);
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
        }

        [TestMethod]
        public void CountingSortColors()
        {
            int[] nums = { 1, 0, 2, 1, 0, 0, 0, 2, 2, 1, 1, 1, 1, 0 };
            var result = CountingSort.SortColors(nums);
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }

        [TestMethod]
        public void MergeSortTest()
        {
            int[] nums = { 11, 13, 7, 12, 16, 9, 24, 5, 10, 3 };
            MergeSort.IterativeMS(nums, 10);
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("-----------------------");
            MergeSort.RecursiveMS(nums, 0, nums.Length - 1);
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
