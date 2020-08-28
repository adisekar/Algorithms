using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Stacks
{
    public class Node
    {
        public int val { get; set; }
        public Node next { get; set; }

        public Node(int data)
        {
            this.val = data;
            this.next = null;
        }
    }
}
