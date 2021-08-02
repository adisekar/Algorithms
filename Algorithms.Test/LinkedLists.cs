using Algorithms.LinkedLists;
using Algorithms.LinkedLists.Clone;
using DS.LinkedLists;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Test
{
    [TestClass]
    public class LinkedLists
    {
        [TestMethod]
        public void AddTwoNumbers()
        {
            LinkedList l1 = new LinkedList();
            l1.InsertAtStart(3);
            l1.InsertAtStart(4);
            l1.InsertAtStart(2);

            LinkedList l2 = new LinkedList();
            l2.InsertAtStart(4);
            l2.InsertAtStart(6);
            l2.InsertAtStart(5);

            var resultHead = Add.AddTwoNumbers(l1.head, l2.head);
            if (resultHead != null)
            {
                var result = l1.PrintList(resultHead);
                foreach (var n in result)
                {
                    Console.WriteLine(n);
                }
            }

            Console.WriteLine("--------------------------");
            LinkedList l3 = new LinkedList();
            l3.InsertAtStart(9);

            LinkedList l4 = new LinkedList();
            l4.InsertAtStart(9);
            var resultHead2 = Add.AddTwoNumbers(l3.head, l4.head);
            if (resultHead2 != null)
            {
                var result = l3.PrintList(resultHead2);
                foreach (var n in result)
                {
                    Console.WriteLine(n);
                }
            }
        }

        [TestMethod]
        public void IsPalindrome()
        {
            LinkedList l = new LinkedList();
            l.InsertAtStart(1);
            l.InsertAtStart(2);
            l.InsertAtStart(2);
            l.InsertAtStart(1);

            var result = Palindrome.IsPalindrome(l.head);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void RemoveDuplicatesUnsortedList()
        {
            LinkedList l = new LinkedList();
            l.InsertAtStart(1);
            l.InsertAtEnd(3);
            l.InsertAtEnd(2);
            l.InsertAtEnd(3);
            l.InsertAtEnd(5);
            l.InsertAtEnd(4);
            l.InsertAtEnd(5);

            var result = RemoveDuplicates.UnsortedList(l.head);

            var resultList = l.PrintList(result);
            foreach (var node in resultList)
            {
                Console.Write(node + " -> ");
            }
        }

        [TestMethod]
        public void CopyList()
        {
            LinkedList l = new LinkedList();
            l.InsertAtStart(1);
            l.InsertAtEnd(2);

            var result = CloneList.CopyList(l.head);
            l.InsertAtStart(3);
            Console.WriteLine("--------- New List ----");
            var resultList = l.PrintList(result);
            foreach (var node in resultList)
            {
                Console.Write(node + " -> ");
            }

            Console.WriteLine();
            Console.WriteLine("--------- Original List ----");
            var originalList = l.PrintList(l.head);
            foreach (var node in originalList)
            {
                Console.Write(node + " -> ");
            }
        }

        public RandomListNode InsertAtStartRandom(RandomListNode head, int data, RandomListNode randomNode)
        {
            RandomListNode newNode = new RandomListNode(data);
            newNode.random = randomNode;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
            return head;
        }

        [TestMethod]
        public void CopyListRandomPointer()
        {
            RandomListNode node1 = new RandomListNode(1);
            RandomListNode node2 = new RandomListNode(2);
            var head = InsertAtStartRandom(null, 1, null);
            head = InsertAtStartRandom(head, 2, node1);
            head = InsertAtStartRandom(head, 3, node2);

            var result = CloneListRandomPointer.CopyRandomListInsertBetweenNode(head);
            head = InsertAtStartRandom(head, 4, node2);
            Console.WriteLine("--------- New List ----");
            while (result != null)
            {
                Console.Write(result.val + "," + result.random + " -> ");
                result = result.next;
            }
        }

        [TestMethod]
        public void LRU()
        {
            LRUCache cache = new LRUCache(2);
            cache.Put(1, 1);
            cache.Put(2, 2);
            cache.Get(1);       // returns 1
            cache.Put(3, 3);    // evicts key 2
            cache.Get(2);       // returns -1 (not found)
            cache.Put(4, 4);    // evicts key 1
            cache.Get(1);       // returns -1 (not found)
            cache.Get(3);       // returns 3
            cache.Get(4);       // returns 4

            var temp = cache.head;
            while (temp != null)
            {
                Console.WriteLine(temp.val);
                temp = temp.next;
            }
        }

        [TestMethod]
        public void SwapNodes()
        {
            //LinkedList l = new LinkedList();
            //l.InsertAtStart(1);
            //l.InsertAtEnd(2);
            //l.InsertAtEnd(3);
            //l.InsertAtEnd(4);
            //l.InsertAtEnd(5);

            //int k = 2;
            //SwapNodesKFromStartAndEnd.SwapNodes(l.head, k);

            //var temp = l.head;
            //while (temp != null)
            //{
            //    Console.WriteLine(temp.val);
            //    temp = temp.next;
            //}

            LinkedList l = new LinkedList();
            l.InsertAtStart(7);
            l.InsertAtEnd(9);
            l.InsertAtEnd(6);
            l.InsertAtEnd(6);
            l.InsertAtEnd(7);
            l.InsertAtEnd(8);
            l.InsertAtEnd(3);
            l.InsertAtEnd(0);
            l.InsertAtEnd(9);
            l.InsertAtEnd(5);

            int k = 5;
            SwapNodesKFromStartAndEnd.SwapNodes(l.head, k);

            var temp = l.head;
            while (temp != null)
            {
                Console.WriteLine(temp.val);
                temp = temp.next;
            }
        }
    }
}
