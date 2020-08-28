using System;
using System.Collections.Generic;
using System.Text;

namespace DS.LinkedLists.DoublyLinkedList
{
    public class DListNode
    {
        public int val { get; set; }
        public DListNode next { get; set; }
        public DListNode prev { get; set; }
        public DListNode(int val)
        {
            this.val = val;
            this.next = null;
            this.prev = null;
        }
    }
}
