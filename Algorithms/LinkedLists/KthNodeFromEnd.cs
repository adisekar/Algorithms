using DS.LinkedLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists
{
    public class KthNodeFromEnd
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode p = dummy;
            ListNode q = dummy;

            int counter = 0;
            // Loop p till n + 1
            while (counter != n + 1)
            {
                p = p.next;
                counter++;
            }

            while (p != null)
            {
                p = p.next;
                q = q.next;
            }
            // Delete nth node
            q.next = q.next.next;
            return dummy.next;
        }
    }
}
