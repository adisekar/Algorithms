using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Queue
{
    /*
     * ["MovingAverage","next","next","next","next"]
[[3],[1],[10],[3],[5]]
*/
    public class MovingAverage
    {
        // Private fields
        private Queue<int> q;
        private int count;
        private int maxSize;
        private double average = 0;
        private int total = 0;
        /** Initialize your data structure here. */
        public MovingAverage(int size)
        {
            q = new Queue<int>();
            count = 0;
            maxSize = size;
            average = 0;
            total = 0;
        }

        public double Next(int val)
        {
            if (count == maxSize)
            {
                int removedNum = q.Dequeue();
                total = total - removedNum;
            }
            q.Enqueue(val);
            count = count == maxSize ? maxSize : count + 1;
            total = total + val;
            average = (double)total / count;
            return average;
        }
    }

    /**
     * Your MovingAverage object will be instantiated and called as such:
     * MovingAverage obj = new MovingAverage(size);
     * double param_1 = obj.Next(val);
     */
}
