using DS.Heap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Heap
{
    public class TopKFrequent
    {
        public static int[] TopKFrequentElement(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (map.ContainsKey(num))
                {
                    map[num]++;
                }
                else
                {
                    map.Add(num, 1);
                }
            }
            // Add to heap for better performance
            // var sortedMap = map.OrderByDescending(d => d.Value).ThenBy(d => d.Key).Take(k);
            var sortedMap = map.OrderByDescending(d => d.Value).ThenBy(d => d.Key);
            MinHeap minHeap = new MinHeap(sortedMap.Count());
            foreach (var kv in sortedMap)
            {
                minHeap.Insert(kv.Key);
                if (minHeap.count > k)
                {
                    minHeap.Remove();
                }
            }

            int[] result = new int[k];
            for (int i = 0; i < k; i++)
            {
                result[i] = minHeap.PeekPriorityElement();
                minHeap.Remove();
            }
            return result;
        }

        // Java using heap
        //public int[] topKFrequent(int[] nums, int k)
        //{
        //    HashMap<Integer, Integer> map = new HashMap<Integer, Integer>();

        //    for (int i = 0; i < nums.length; i++)
        //    {
        //        map.put(nums[i], map.getOrDefault(nums[i], 0) + 1);
        //    }

        //    // Init heap with least frequent elements added first
        //    PriorityQueue<Integer> minHeap = new PriorityQueue<Integer>((n1, n2)->map.get(n1) - map.get(n2));

        //    for (int n: map.keySet())
        //    {
        //        minHeap.add(n);
        //        if (minHeap.size() > k) minHeap.poll();
        //    }

        //    int[] result = new int[k];
        //    for (int i = k - 1; i >= 0; i--)
        //    {
        //        result[i] = minHeap.poll();
        //    }
        //    return result;
        //}
    }
}
