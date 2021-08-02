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
            ListNode dummy = new ListNode(-1);
            dummy.next = head;
            ListNode l = dummy;
            ListNode r = head;

            // Move Right r ptr n places, so it starts from here
            int count = 0;
            while (count < n)
            {
                r = r.next;
                count++;
            }

            // Move Left l and right r pointers
            while (r != null)
            {
                r = r.next;
                l = l.next;
            }
            // Reassign the left pointer, skipping the deleted (nth) node
            l.next = l.next.next;

            return dummy.next;
        }
    }
}
