using DS.Stacks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Stack
{
    public class MinStack
    {
        // Use 2 stacks, one for normal push and other to push min element
        // Another approach is to use an array[], one for normal and next element
        // is min element
        private Node top { get; set; }
        private Node minStackTop { get; set; }

        /** initialize your data structure here. */
        public MinStack()
        {
            top = null;
        }

        public void Push(int x)
        {
            Node node = new Node(x);
            if (top == null)
            {
                top = node;
                minStackTop = node;
            }
            else
            {
                node.next = top;
                top = node;

                if (minStackTop.val < x)
                {
                    Node minNode = new Node(minStackTop.val);
                    minNode.next = minStackTop;
                    minStackTop = minNode;
                }
                else
                {
                    Node minNode = new Node(x);
                    minNode.next = minStackTop;
                    minStackTop = minNode;
                }
            }
        }

        public void Pop()
        {
            if (top != null)
            {
                top = top.next;
                minStackTop = minStackTop.next;
            }
        }

        public int Top()
        {
            return top.val;
        }

        public int GetMin()
        {
            return minStackTop.val;
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(x);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */
}
