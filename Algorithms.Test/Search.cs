using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algorithms.Searching;
using System;
using Algorithms.Search;

namespace Algorithms.Test
{
    [TestClass]
    public class Searching
    {
        [TestMethod]
        public void FindBinarySearch()
        {
            int[] array = { -1, 0, 3, 5, 9, 12 };
            var result = BinarySearch.IterativeSearch(array, 9);
            Assert.AreEqual(4, result);

            var result2 = BinarySearch.RecursiveSearch(array, 9);
            Assert.AreEqual(4, result2);
        }

        [TestMethod]
        public void SearchElementInSortedRotatedArray()
        {
            int[] array = { 4, 5, 6, 7, 0, 1, 2 };
            int target = 0;
            var result = SortedRotatedArray.Search(array, target);
            Assert.AreEqual(4, result);

            int[] array2 = { 4, 5, 6, 7, 0, 1, 2 };
            int target2 = 3;
            var result2 = SortedRotatedArray.Search(array2, target2);
            Assert.AreEqual(-1, result2);

            int[] array3 = { 1, 3 };
            int target3 = 1;
            var result3 = SortedRotatedArray.Search(array3, target3);
            Assert.AreEqual(0, result3);
        }
    }
}
