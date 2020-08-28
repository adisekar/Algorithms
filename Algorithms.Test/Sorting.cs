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
        public void CountingSortColors()
        {
            int[] nums = { 1, 0, 2, 1, 0, 0, 0, 2, 2, 1, 1, 1, 1, 0 };
            var result = CountingSort.SortColors(nums);
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
