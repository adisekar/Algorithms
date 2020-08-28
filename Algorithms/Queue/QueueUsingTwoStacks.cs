using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Queue
{
    public class QueueUsingTwoStacks
    {
        private Stack<int> forwardStack { get; set; }
        private Stack<int> reverseStack { get; set; }

        /** Initialize your data structure here. */
        public QueueUsingTwoStacks()
        {
            forwardStack = new Stack<int>();
            reverseStack = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            if (forwardStack.Count == 0 && reverseStack.Count > 0)
            {
                while (reverseStack.Count > 0)
                {
                    var el = reverseStack.Pop();
                    forwardStack.Push(el);
                }
            }
            forwardStack.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (reverseStack.Count == 0 && forwardStack.Count > 0)
            {
                while (forwardStack.Count > 0)
                {
                    var el = forwardStack.Pop();
                    reverseStack.Push(el);
                }
            }
            return reverseStack.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            if (reverseStack.Count == 0 && forwardStack.Count > 0)
            {
                while (forwardStack.Count > 0)
                {
                    var el = forwardStack.Pop();
                    reverseStack.Push(el);
                }
            }
            return reverseStack.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return forwardStack.Count == 0 && reverseStack.Count == 0;
        }
    }
}
