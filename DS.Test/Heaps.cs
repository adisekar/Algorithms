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

        [TestMethod]
        public void MaxHeapConstruction()
        {
            int[] arr = { 2, 5, 8, 9, 4, 10, 7 };
            MaxHeap maxHeap = new MaxHeap(arr.Length);
            var result = maxHeap.BuildHeap(arr);

            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
            maxHeap.Remove();
            maxHeap.Remove();
            maxHeap.Remove();
            maxHeap.Remove();
            Console.WriteLine("------------------");
            //for (int i = 0; i < maxHeap.count; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            foreach (var num in arr)
            {
                Console.WriteLine(num);
            }
        }
    }
}
