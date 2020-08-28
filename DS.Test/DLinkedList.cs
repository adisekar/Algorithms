using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DS.LinkedLists.DoublyLinkedList;

namespace DS.Test
{
    [TestClass]
    public class DLinkedListTest
    {
        [TestMethod]
        public void Construction()
        {
            DLinkedList dLinkedList = new DLinkedList();
            dLinkedList.InsertAtStart(5);
            dLinkedList.InsertAtStart(4);
            dLinkedList.InsertAtStart(3);
            dLinkedList.InsertAtStart(2);
            dLinkedList.InsertAtStart(1);
            dLinkedList.InsertAtTail(6);
            dLinkedList.InsertAtTail(8);
            dLinkedList.InsertAtTail(9);
            dLinkedList.AddAtIndex(6, 7);
            dLinkedList.DeleteAtIndex(7);
            int val = dLinkedList.Get(9);
            Console.WriteLine("Value at Node is = " + val);

            Console.WriteLine("Count of nodes = " + dLinkedList.CountNodes());
            var result = dLinkedList.PrintList();
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }


        [TestMethod]
        public void Reverse()
        {
            DLinkedList dLinkedList = new DLinkedList();
            dLinkedList.InsertAtStart(5);
            dLinkedList.InsertAtStart(4);
            dLinkedList.InsertAtStart(3);
            dLinkedList.InsertAtStart(2);
            dLinkedList.InsertAtStart(1);
            dLinkedList.InsertAtTail(6);
            dLinkedList.InsertAtTail(8);
            dLinkedList.InsertAtTail(9);

            var result = dLinkedList.Reverse();
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
