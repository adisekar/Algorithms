using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algorithms.Searching;
using System;
using Algorithms.SlidingWindow;

namespace Algorithms.Test
{
    [TestClass]
    public class SlidingWindowProblems
    {

        [TestMethod]
        public void MaxSubArraySum()
        {
            int[] array = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //var result = MaxSubArray.Sum(array);
            var result = MaxSubArray.Sum_BF(array);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void FindAnagrams()
        {
            string s = "abab";
            string p = "ab";
            var result = FindAllAnagrams.FindAnagrams(s, p);
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
        }

        [TestMethod]
        public void MaxSubArraySumSizeK()
        {
            int[] array = { 2, 1, 5, 1, 3, 2 };
            var result = LargestSumSubArraySizeK.Sum(array, 3);
            //var result = MaxSubArray.Sum_BF(array);
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void MaxSubArraySumGetArray()
        {
            int[] array = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var result = MaxSubArray.GetArray(array);
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }

        [TestMethod]
        public void LongestSubstringNoRepeatingCharacters()
        {
            string s = "pwwkew";
            string s2 = "clementisacap";
            var result = LongestSubstring.LongestSubstringWithoutDuplication(s);
            Console.WriteLine(result);

            var result2 = LongestSubstring.LongestSubstringWithoutDuplication(s2);
            Console.WriteLine(result2);
        }

        [TestMethod]
        public void LongestSubstringKDistinctCharacters()
        {
            string s = "araaci";
            var result = LongestSubstring.LongestSubStringWithKDistinctChars(s, 2);
            Assert.AreEqual(4, result);

            string s2 = "abaccc";
            var result2 = LongestSubstring.LongestSubStringWithKDistinctChars(s2, 2);
            Assert.AreEqual(4, result2);
        }

        [TestMethod]
        public void SmallestSumOfKSubArray()
        {
            int[] arr = { 2, 1, 5, 2, 3, 2 };
            //var result = SmallestSumKSubarray.SmallestSubArray_BF(arr, 7);
            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //}
            var result = SmallestSumKSubarray.SmallestSumSubArrayLength(arr, 7);
            Assert.AreEqual(2, result);
            Console.WriteLine("---------------");

            int[] arr2 = { 2, 1, 5, 2, 8 };
            var result2 = SmallestSumKSubarray.SmallestSumSubArrayLength(arr2, 7);
            Assert.AreEqual(1, result2);
            //var result2 = SmallestSumKSubarray.SmallestSubArray_BF(arr2, 7);
            //foreach (var num in result2)
            //{
            //    Console.WriteLine(num);
            //}

            int[] arr3 = { 2, 3, 1, 1, 1, 1, 1 };
            var result3 = SmallestSumKSubarray.SmallestSumSubArrayLength(arr3, 5);
            Assert.AreEqual(2, result3);
        }
    }
}
