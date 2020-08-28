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

        public static ListNode ReverseListRecursive(ListNode head)
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
