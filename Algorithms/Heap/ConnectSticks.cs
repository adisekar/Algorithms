using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DS.Heap;

namespace Algorithms.Heap
{
    public class ConnectSticks
    {
        public static int MinCost(int[] sticks)
        {
            int cost = 0;
            MinHeap minHeap = new MinHeap(sticks.Length);
            foreach (var stick in sticks)
            {
                minHeap.Insert(stick);
            }

            while (minHeap.count > 1)
            {
                int num1 = minHeap.PeekPriorityElement();
                minHeap.Remove();
                int num2 = minHeap.PeekPriorityElement();
                minHeap.Remove();

                int sum = num1 + num2;
                minHeap.Insert(sum);

                cost += sum;
            }
            return cost;
        }

        // As C# dont have min heap implementation
        public static int MinCostBruteForce(int[] sticks)
        {
            int cost = 0;
            List<int> remainingRopes = sticks.ToList();
            remainingRopes.Sort();

            while (remainingRopes.Count > 1)
            {
                int sum = remainingRopes[0] + remainingRopes[1];
                remainingRopes.RemoveRange(0, 2);//Removes first 2 elements                
                remainingRopes.Add(sum);
                cost += sum;
                remainingRopes.Sort();
            }
            return cost;
        }
    }
}
