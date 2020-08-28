using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algorithms.Arrays;
using Algorithms.Arrays.TwoSum;
using System;
using Algorithms.Arrays.Peak;
using Algorithms.Arrays.SortedArrays;
using Algorithms.Arrays.TwoPointers;
using Algorithms.Arrays.Intervals;

namespace Algorithms.Test
{
    [TestClass]
    public class Arrays
    {
        [TestMethod]
        public void IsAlienDictionarySorted()
        {
            string[] words = { "hello", "leetcode" };
            string order = "hlabcdefgijkmnopqrstuvwxyz";
            bool result = AlienDictionary.IsAlienSorted(words, order);
            Assert.AreEqual(true, result);

            string[] words2 = { "kuvp", "q" };
            string order2 = "ngxlkthsjuoqcpavbfdermiywz";
            bool result2 = AlienDictionary.IsAlienSorted(words2, order2);
            Assert.AreEqual(true, result2);

            string[] words3 = { "ubg", "kwh" };
            string order3 = "qcipyamwvdjtesbghlorufnkzx";
            bool result3 = AlienDictionary.IsAlienSorted(words3, order3);
            Assert.AreEqual(true, result3);
        }

        [TestMethod]
        public void ValidateSubsequence()
        {
            List<int> array = new List<int>() { 5, 1, 22, 25, 6, -1, 8, 10 };
            List<int> sequence = new List<int>() { 1, 6, -1, 10 };
            bool result = Subsequence.IsValidSubsequence(array, sequence);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void MergeIntervalsTest()
        {
            // [[1,3],[2,6],[8,10],[15,18]]
            int[][] intervals = { new int[] { 1, 3 }, new int[] { 2, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 } };
            var result = MergeIntervals.Merge2(intervals);
            foreach (var n in result)
            {
                Console.WriteLine(n[0] + "," + n[1]);
            }
        }

        [TestMethod]
        public void MeetingRooms1()
        {
            int[][] intervals = { new int[] { 0, 30 }, new int[] { 5, 10 }, new int[] { 15, 20 } };
            var result = MeetingRooms.CanAttendMeetings(intervals);
            Assert.AreEqual(false, result);

            int[][] intervals2 = { new int[] { 7, 10 }, new int[] { 2, 4 } };
            var result2 = MeetingRooms.CanAttendMeetings(intervals2);
            Assert.AreEqual(true, result2);
        }

        [TestMethod]
        public void MeetingRooms2()
        {
            int[][] intervals = { new int[] { 9, 10 }, new int[] { 4, 9 }, new int[] { 4, 17 } };
            var result = MeetingRooms.MinMeetingRooms_BF(intervals);
            Assert.AreEqual(2, result);

            int[][] intervals2 = { new int[] { 7, 10 }, new int[] { 2, 4 } };
            var result2 = MeetingRooms.MinMeetingRooms(intervals2);
            Assert.AreEqual(1, result2);
        }

        [TestMethod]
        public void PrisonAfterNDays()
        {
            int[] arr = { 0, 1, 0, 1, 1, 0, 0, 1 };
            int N = 2;
            var result = PrisonCellAfterNDays.PrisonAfterNDays(arr, N);
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
        }

        [TestMethod]
        public void IntersectionArrays()
        {
            int[] nums1 = { 1, 2, 3, 4, 5 };
            int[] nums2 = { 1, 2, 5, 7, 9 };
            int[] nums3 = { 1, 3, 4, 5, 8 };
            var result = IntersectionThreeArrays.ArraysIntersection(nums1, nums2, nums3);
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }

        [TestMethod]
        public void HIndex1()
        {
            int[] citations = { 3, 0, 6, 1, 5 };
            var result = HIndex.HIndex1(citations);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void HasSingleCycle()
        {
            int[] arr = { 2, 3, 1, -4, -4, 2 };
            var result = Cycle.HasSingleCycle(arr);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ThreeSumFindClosest()
        {
            int[] arr = { -1, 2, 1, -4 };
            int target = 1;
            var result = ThreeSumClosest.FindClosest(arr, target);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MoveElementToEnd()
        {
            int[] array = { 1, 3, 2, 4, 2, 2, 2 };
            var result = MoveToEnd.MoveElement(array, 2);
            foreach (var n in result)
            {
                Console.Write(n + " ");
            }
        }
        [TestMethod]
        public void RemoveDuplicatesFromSortedArray()
        {
            int[] array = { 1, 1, 2 };
            var result = RemoveDuplicates.FromSortedArray(array);
            Assert.AreEqual(2, result);
            for (int i = 0; i < result; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        [TestMethod]
        public void FindPeakElement()
        {
            int[] array = { 1, 2, 3, 1 };
            var result = PeakElement.FindPeakLinear(array);
            Assert.AreEqual(2, result);

            var result2 = PeakElement.FindPeakLog(array);
            Assert.AreEqual(2, result2);
        }

        [TestMethod]
        public void LongestMountain()
        {
            int[] array = { 2, 1, 4, 7, 3, 2, 5 };
            var result = LargestMountainArray.LongestMountainBF(array);
            Assert.AreEqual(5, result);

            var result2 = LargestMountainArray.LongestMountain(array);
            Assert.AreEqual(5, result2);
        }

        [TestMethod]
        public void RotateArray()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            Rotation.Rotate(array, k);
            foreach (var num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        [TestMethod]
        public void ProductExceptSelf()
        {
            int[] array = { 1, 2, 3, 4 };
            var result = ProductArrExceptSelf.ProductExceptSelf_Naive(array);
            foreach (var num in result)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            var result2 = ProductArrExceptSelf.ProductExceptSelfWithSpace(array);
            foreach (var num in result2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            var result3 = ProductArrExceptSelf.ProductExceptSelfInPlace(array);
            foreach (var num in result3)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        [TestMethod]
        public void ContainerMaxAreaWater()
        {
            int[] array = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            var result = ContainerMostWater.MaxAreaBF(array);
            Assert.AreEqual(49, result);

            var result2 = ContainerMostWater.MaxArea(array);
            Assert.AreEqual(49, result2);
        }

        [TestMethod]
        public void TrappingRainWater()
        {
            int[] array = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            var result = Algorithms.Arrays.TrappingRainWater.Trap_WithSpace(array);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void ZigZagArray()
        {
            int[] array = { 3, 4, 6, 2, 1, 8, 9 };
            var result = ZigZag.Convert(array);
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }

        [TestMethod]
        public void Median2SortedArrays()
        {
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3, 4 };
            var result = MedianTwoSortedArrays.FindMedianSortedArrays_InPlace(nums1, nums2);
            Assert.AreEqual(2.5, result);

            int[] numsV2_1 = { 1, 3 };
            int[] numsV2_2 = { 2 };
            var result2 = MedianTwoSortedArrays.FindMedianSortedArrays_InPlace(numsV2_1, numsV2_2);
            Assert.AreEqual(2, result2);
        }

        [TestMethod]
        public void SmallestDifference()
        {
            int[] nums1 = { -1, 5, 10, 20, 28, 3 };
            int[] nums2 = { 26, 134, 135, 15, 17 };
            var result = SmallestDifferenceTwoArrays.SmallestDifference(nums1, nums2);
            Assert.AreEqual(result[0], 28);
            Assert.AreEqual(result[1], 26);
        }


        [TestMethod]
        public void Merge2SortedArrays()
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 4, 6 };
            MergeTwoSortedArrays.Merge(nums1, 3, nums2, 3);
            foreach (var num in nums1)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            int[] nums3 = { 0, 0, 0, 0, 0 };
            int[] nums4 = { 1, 2, 3, 4, 5 };
            MergeTwoSortedArrays.Merge(nums3, 0, nums4, 5);
            foreach (var num in nums3)
            {
                Console.Write(num + " ");
            }
        }

        [TestMethod]
        public void SearchSuggestionSystem()
        {
            string[] products = { "mobile", "mouse", "moneypot", "monitor", "mousepad" };
            string searchWord = "mouse";
            var result = SearchSuggestions.SuggestedProducts(products, searchWord);
            // Expected O/P 
            // [["mobile","moneypot","monitor"],["mobile","moneypot","monitor"],["mouse","mousepad"],["mouse","mousepad"],["mouse","mousepad"]]
            foreach (var productsList in result)
            {
                foreach (var product in productsList)
                {
                    Console.Write(product + " ");
                }
                Console.WriteLine();
            }
        }

        [TestMethod]
        public void OptimalPairsSum()
        {
            List<int[]> a = new List<int[]>() { new int[] { 1, 2 }, new int[] { 2, 4 }, new int[] { 3, 6 } };
            List<int[]> b = new List<int[]>() { new int[] { 1, 2 } };
            int target = 7;
            var result = OptimalPairs.FindPairs(a, b, target);
            // Expected: Output: [[2, 1]]
            foreach (var num in result)
            {
                Console.WriteLine(num[0] + " " + num[1]);
            }
            Console.WriteLine("-------------------------------------------------");

            List<int[]> a2 = new List<int[]>() { new int[] { 1, 3 }, new int[] { 2, 5 }, new int[] { 3, 7 }, new int[] { 4, 10 } };
            List<int[]> b2 = new List<int[]>() { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 4 }, new int[] { 4, 5 } };
            int target2 = 10;
            var result2 = OptimalPairs.FindPairs(a2, b2, target2);
            // Expected: Output: [[2, 4], [3, 2]]
            foreach (var num in result2)
            {
                Console.WriteLine(num[0] + " " + num[1]);
            }
            Console.WriteLine("-------------------------------------------------");

            List<int[]> a3 = new List<int[]>() { new int[] { 1, 8 }, new int[] { 2, 7 }, new int[] { 3, 14 } };
            List<int[]> b3 = new List<int[]>() { new int[] { 1, 5 }, new int[] { 2, 10 }, new int[] { 3, 14 } };
            int target3 = 20;
            var result3 = OptimalPairs.FindPairs(a3, b3, target3);
            // Expected: Output: [[3, 1]]
            foreach (var num in result3)
            {
                Console.WriteLine(num[0] + " " + num[1]);
            }
            Console.WriteLine("-------------------------------------------------");

            List<int[]> a4 = new List<int[]>() { new int[] { 1, 8 }, new int[] { 2, 15 }, new int[] { 3, 9 } };
            List<int[]> b4 = new List<int[]>() { new int[] { 1, 8 }, new int[] { 2, 11 }, new int[] { 3, 12 } };
            int target4 = 20;
            var result4 = OptimalPairs.FindPairs(a4, b4, target4);
            // Expected: Output: [[1, 3], [3, 2]]
            foreach (var num in result4)
            {
                Console.WriteLine(num[0] + " " + num[1]);
            }
            Console.WriteLine("-------------------------------------------------");
        }
        [TestMethod]
        public void ReorderLogFiles()
        {
            string[] logs = { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" };
            string[] result = ReorderLogs.ReorderLogFiles(logs);

            // Expected output ["let1 art can","let3 art zero","let2 own kit dig","dig1 8 1 5 1","dig2 3 6"]
            foreach (var s in result)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("------------------------------------------");


            string[] logs2 = { "a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo" };
            string[] result2 = ReorderLogs.ReorderLogFiles(logs2);

            // Expected output ["g1 act car","a8 act zoo","ab1 off key dog","a1 9 2 3 1","zo4 4 7"]
            foreach (var s in result2)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("------------------------------------------");


            string[] logs3 = { "t kvr", "r 3 1", "i 403", "7 so", "t 54" };
            string[] result3 = ReorderLogs.ReorderLogFiles(logs3);

            // Expected output ["t kvr","7 so","r 3 1","i 403","t 54"]
            foreach (var s in result3)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("------------------------------------------");


            string[] logs4 = { "6p tzwmh ige mc", "ns 566543603829", "ubd cujg j d yf", "ha6 1 938 376 5", "3yx 97 666 56 5", "d 84 34353 2249", "0 tllgmf qp znc", "s 1088746413789", "ys0 splqqxoflgx", "uhb rfrwt qzx r", "u lrvmdt ykmox", "ah4 4209164350", "rap 7729 8 125", "4 nivgc qo z i", "apx 814023338 8" };
            string[] result4 = ReorderLogs.ReorderLogFiles(logs4);

            // Expected output ["ubd cujg j d yf","u lrvmdt ykmox","4 nivgc qo z i","uhb rfrwt qzx r","ys0 splqqxoflgx","0 tllgmf qp znc","6p tzwmh ige mc","ns 566543603829","ha6 1 938 376 5","3yx 97 666 56 5","d 84 34353 2249","s 1088746413789","ah4 4209164350","rap 7729 8 125","apx 814023338 8"]
            foreach (var s in result4)
            {
                Console.WriteLine(s);
            }
        }
    }
}
