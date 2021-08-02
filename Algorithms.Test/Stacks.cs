using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Algorithms.Stack;

namespace Algorithms.Test
{
    [TestClass]
    public class Stacks
    {
        [TestMethod]
        public void FindNextGreaterElements()
        {
            int[] array = { 13, 7, 6, 12 };
            var result = NextGreatestElement.GetAll(array);
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("--------------------");
            int[] array2 = { 18, 7, 6, 12, 15 };
            var result2 = NextGreatestElement.GetAll(array2);
            foreach (var num in result2)
            {
                Console.WriteLine(num);
            }
        }

        [TestMethod]
        public void BackspaceCompare()
        {
            string S = "ab#c";
            string T = "ad#c";
            var result = BackspaceStringCompare.BackspaceCompare(S, T);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void LargestRectangularAreaInHistogram()
        {
            int[] heights = { 2, 1, 5, 6, 2, 3 };
            var result = Histogram.LargestRectangleArea(heights);
            Assert.AreEqual(10, result);

            int[] heights2 = { 5,4,1,2 };
            var result2 = Histogram.LargestRectangleArea(heights2);
            Assert.AreEqual(8, result2);
        }
    }
}
