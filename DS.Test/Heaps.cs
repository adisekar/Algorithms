using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DS.Heap;

namespace DS.Test
{
    [TestClass]
    public class Heaps
    {
        [TestMethod]
        public void MinHeapConstruction()
        {
            int[] arr = { 5, 4, 2, 6, 7, 4, 2, 6 };
            MinHeap minHeap = new MinHeap(arr.Length);
            var result = minHeap.BuildHeap(arr);

            foreach (var num in result)
            {
                Console.WriteLine(num);
            }

        }
    }
}
