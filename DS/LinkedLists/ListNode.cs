using System;
using System.Collections.Generic;
using System.Text;

namespace DS.LinkedLists
{
    public class ListNode
    {
        public int val { get; set; }
        public ListNode next { get; set; }

        public ListNode(int data)
        {
            this.val = data;
        }
    }
}
