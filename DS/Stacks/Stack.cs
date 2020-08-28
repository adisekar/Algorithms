using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Stacks
{
    public class Stack
    {
        private static int MAX_SIZE = 40;
        private Node top { get; set; }
        private int size = 0;

        public void Push(int data)
        {
            if (size == MAX_SIZE)
            {
                throw new StackOverflowException();
            }

            Node node = new Node(data);
            if (top == null)
            {
                top = node;
            }
            else
            {
                node.next = top;
                top = node;
            }
            size++;
        }

        public void Pop()
        {
            if (size == 0)
            {
                throw new Exception("Could not pop from empty stack");
            }

            if (top != null)
            {
                top = top.next;
                size--;
            }
        }

        public Node Peek()
        {
            if (top != null)
            {
                return top.next;
            }
            return null;
        }

        public List<int> Print()
        {
            List<int> values = new List<int>();
            Node temp = top;
            while (temp != null)
            {
                values.Add(temp.val);
                temp = temp.next;
            }
            return values;
        }
    }
}
