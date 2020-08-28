using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DS.LinkedLists;

namespace DS.Test
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void Construction()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.InsertAtStart(5);
            linkedList.InsertAtStart(4);
            linkedList.InsertAtStart(3);
            linkedList.InsertAtStart(2);
            linkedList.InsertAtStart(1);
            linkedList.InsertAtEnd(6);
            linkedList.InsertAtEnd(8);
            linkedList.InsertAtEnd(9);
            linkedList.InsertAtPosition(7, 6);
            linkedList.InsertAtMiddle(5);

            Console.WriteLine("Count of nodes = " + linkedList.CountNodes());
            var result = linkedList.PrintList();
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
