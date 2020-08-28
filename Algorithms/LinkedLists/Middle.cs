using DS.LinkedLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists
{
    public class Middle
    {
        // 2 pointers, fast and slow. 
        // when fast reaches null, slow will be in middle
        // Odd and even list
        public ListNode MiddleNode(ListNode head)
        {
            ListNode p = head;
            ListNode q = head;

            while (q != null && q.next != null)
            {
                p = p.next;
                q = q.next.next;
            }
            return p;
        }
    }
}
