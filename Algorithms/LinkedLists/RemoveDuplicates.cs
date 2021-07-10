using DS.LinkedLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists
{
    public class RemoveDuplicates
    {
        // 3 possible methods
        // 2 loops, for each element, go over every other element
        // Sort the list, and find duplicates
        // Hashing the seen values. This fn uses hashing
        public static ListNode UnsortedList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            HashSet<int> seenSet = new HashSet<int>();

            ListNode p = head.next;
            ListNode q = head;
            ListNode result = q;
            seenSet.Add(head.val);

            // q follows p
            while (p != null)
            {
                // Duplicate element, so skip
                if (seenSet.Contains(p.val))
                {
                    // Skip p element for q
                    q.next = p.next;
                }
                else
                {
                    seenSet.Add(p.val);
                    q = q.next;
                }
                p = p.next;
            }
            return result;
        }
    }
}
