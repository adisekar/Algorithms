using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Stack
{
    // Push Costly
    public class StackUsing2Queues
    {
        Queue<int> q1;
        Queue<int> q2;
        /** Initialize your data structure here. */
        public StackUsing2Queues()
        {
            q1 = new Queue<int>();
            q2 = new Queue<int>();
        }

        // Push Costly
        // Move current items from Q1 to Q2
        // Push to Q1
        // Move items back to Q1 from Q2
        /** Push element x onto stack. */
        public void Push(int x)
        {
            while (q1.Count > 0)
            {
                q2.Enqueue(q1.Dequeue());
            }
            q1.Enqueue(x);
            while (q2.Count > 0)
            {
                q1.Enqueue(q2.Dequeue());
            }
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            return q1.Count > 0 ? q1.Dequeue() : -1;
        }

        /** Get the top element. */
        public int Top()
        {
            return q1.Count > 0 ? q1.Peek() : -1;
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return q1.Count == 0 && q2.Count == 0;
        }

        // Pop Costly
        // Move current n - 1 items from Q1 to Q2
        // Pop last element and return from Q1
        // Move items back to Q1 from Q2
        /** Push element x onto stack. */
        public void Push2(int x)
        {
            q1.Enqueue(x);
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop2()
        {
            while (q1.Count > 1)
            {
                q2.Enqueue(q1.Dequeue());
            }
            var returnItem = q1.Count > 0 ? q1.Dequeue() : -1;
            while (q2.Count > 0)
            {
                q1.Enqueue(q2.Dequeue());
            }

            return returnItem;
        }

        /** Get the top element. */
        public int Top2()
        {
            while (q1.Count > 1)
            {
                q2.Enqueue(q1.Dequeue());
            }
            var returnItem = q1.Count > 0 ? q1.Dequeue() : -1;
            if (returnItem != -1)
            {
                q2.Enqueue(returnItem);
            }
            while (q2.Count > 0)
            {
                q1.Enqueue(q2.Dequeue());
            }

            return returnItem;
        }
    }
}
