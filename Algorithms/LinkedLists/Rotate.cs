using DS.LinkedLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists
{
    public class Rotate
    {
        /* I/P [1,2,3,4,5] K = 2
        Output [4, 5, 1, 2, 3]
        */
        public ListNode RotateRight(ListNode head, int k)
        {
            // base cases
            if (head == null) return null;
            if (head.next == null) return head;
            if (k == 0) return head;

            int totalCount = 0;
            ListNode p = head;
            // Calculate total items
            while (p != null)
            {
                p = p.next;
                totalCount++;
            }
            // Base case
            if (k == totalCount) return head;

            // If k > nums.Length, can only rotate it k% nums.Len times
            k = k % totalCount;

            // Find n -k, and stop there. Next node from here 
            // is new start/head. And n-k is connected to null
            int breakPoint = totalCount - k;
            int curCount = 1;
            p = head;
            while (curCount < breakPoint)
            {
                p = p.next;
                curCount++;
            }

            // p holds last node
            // break the ring
            ListNode newHead = p.next;
            p.next = null;

            ListNode q = newHead;
            while (q != null && q.next != null)
            {
                q = q.next;
            }

            if (q != null) { q.next = head; }
            return newHead == null ? head : newHead;
        }
    }
}
