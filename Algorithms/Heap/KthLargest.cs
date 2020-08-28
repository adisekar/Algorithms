using DS.Heap;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Heap
{
    public class KthLargest
    {
        public static int FindKthLargestElementInArray(int[] nums, int k)
        {
            MinHeap minHeap = new MinHeap(nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                minHeap.Insert(nums[i]);
                if(i >= k)
                {
                    minHeap.Remove();
                }
            }

            // Instead of adding everything and removing n -k
            // Can be done in same loop above
            //int count = 0;
            //while (count < nums.Length - k)
            //{
            //    minHeap.Remove();
            //    count++;
            //}
            return minHeap.PeekPriorityElement();
        }
    }
}
