using System;
using DS.QueueADT;
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
        private CircularQueue q;
        private int count;
        private int maxSize;
        private double average = 0;
        private int total = 0;
        /** Initialize your data structure here. */
        public MovingAverage(int N)
        {
            q = new CircularQueue(N);
            count = 0;
            maxSize = N;
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
