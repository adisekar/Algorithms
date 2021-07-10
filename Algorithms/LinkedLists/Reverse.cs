using DS.LinkedLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists
{
    public class Reverse
    {
        public static ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            ListNode next = null;

            while (curr != null)
            {
                next = curr.next; // Store the next ref
                curr.next = prev; // change pointers, point next to prev
                prev = curr; // move prev to curr
                curr = next; // move curr to next which is stored
            }
            return prev; // Contains head or last element, as curr goes to null
        }

        ListNode first = null;
        // Best approach for recursion. p = curr, q = prev
        public ListNode ReverseListRecursive(ListNode head)
        {
            Recursive(head, null);
            return first;
        }

        public void Recursive(ListNode p, ListNode q)
        {
            if (p != null)
            {
                Recursive(p.next, p); // Move q to p;
                p.next = q;
            }
            else
            {
                first = q; // First element of list
            }
        }

        public static ListNode ReverseListRecursive2(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode reversedHead = ReverseList(head.next);
            head.next.next = head;
            head.next = null;
            return reversedHead;
        }
    }
}
