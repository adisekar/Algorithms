using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Queue
{
    public class QueueUsingTwoStacks
    {
        Stack<int> forwardStack;
        Stack<int> reverseStack;
        /** Initialize your data structure here. */
        public QueueUsingTwoStacks()
        {
            forwardStack = new Stack<int>();
            reverseStack = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            while (reverseStack.Count > 0)
            {
                forwardStack.Push(reverseStack.Pop());
            }
            forwardStack.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            while (forwardStack.Count > 0)
            {
                reverseStack.Push(forwardStack.Pop());
            }
            return reverseStack.Count > 0 ? reverseStack.Pop() : -1;
        }

        /** Get the front element. */
        public int Peek()
        {
            while (forwardStack.Count > 0)
            {
                reverseStack.Push(forwardStack.Pop());
            }
            return reverseStack.Count > 0 ? reverseStack.Peek() : -1;
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return forwardStack.Count == 0 && reverseStack.Count == 0;
        }
    }
}
