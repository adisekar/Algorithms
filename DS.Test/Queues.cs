using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DS.QueueADT;

namespace DS.Test
{
    [TestClass]
    public class Queues
    {
        [TestMethod]
        public void Construction()
        {
            CircularQueue queue = new CircularQueue(5);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);

            queue.PrintItems();
        }
    }
}
