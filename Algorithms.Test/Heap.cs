using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algorithms.Arrays;
using System;
using Algorithms.Heap;
using DS.LinkedLists;

namespace Algorithms.Test
{
    [TestClass]
    public class Heap
    {
        [TestMethod]
        public void MinCostConnectSticks()
        {
            int[] sticks1 = { 2, 3, 4 };
            int result1 = ConnectSticks.MinCost(sticks1);
            Assert.AreEqual(14, result1);

            int[] sticks2 = { 1, 8, 3, 5 };
            int result2 = ConnectSticks.MinCost(sticks2);
            Assert.AreEqual(30, result2);

            int[] ropes = { 8, 4, 6, 12 };
            int result3 = ConnectSticks.MinCost(ropes);
            Assert.AreEqual(58, result3);
        }

        [TestMethod]
        public void MinCostConnectSticksBruteForce()
        {
            int[] sticks1 = { 2, 3, 4 };
            int result1 = ConnectSticks.MinCostBruteForce(sticks1);
            Assert.AreEqual(14, result1);

            int[] sticks2 = { 1, 8, 3, 5 };
            int result2 = ConnectSticks.MinCostBruteForce(sticks2);
            Assert.AreEqual(30, result2);
        }

        [TestMethod]
        public void KthLargestElement()
        {
            int[] arr = { 3, 2, 1, 5, 6, 4 };
            int k = 2;
            int result = KthLargest.FindKthLargestElementInArray(arr, k);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TopKFrequentElement()
        {
            int[] arr = { 1, 1, 1, 2, 2, 3 };
            int k = 2;
            var result = TopKFrequent.TopKFrequentElement(arr, k);
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }

        [TestMethod]
        public void MergeKSortedList()
        {

            LinkedList l1 = new LinkedList();
            LinkedList l2 = new LinkedList();
            LinkedList l3 = new LinkedList();
            int[] arr1 = { 1, 4, 5 };
            int[] arr2 = { 1, 3, 4 };
            int[] arr3 = { 2, 6 };
            ListNode[] lists = new ListNode[3];
            l1.ConstructList(arr1);
            l2.ConstructList(arr2);
            l3.ConstructList(arr3);
            lists[0] = l1.head;
            lists[1] = l2.head;
            lists[2] = l3.head;

            //var newHead = MergeKSortedLists.MergeUsingHeap(lists);
            var newHead = MergeKSortedLists.MergeKListsOneByOne(lists);
            ListNode p = newHead;
            while (p != null)
            {
                Console.Write(p.val + "->");
                p = p.next;
            }
        }
    }
}
