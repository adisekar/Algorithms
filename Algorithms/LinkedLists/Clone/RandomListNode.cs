using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists.Clone
{
    public class RandomListNode
    {
        public int val { get; set; }
        public RandomListNode next { get; set; }
        public RandomListNode random { get; set; }

        public RandomListNode(int data)
        {
            this.val = data;
        }
    }
}
