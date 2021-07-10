using DS.LinkedLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists
{
    public class Remove
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode p = head;
            // q always follows p, is one behind
            ListNode q = new ListNode(-1);
            q.next = head;

            ListNode newStart = q;

            while (p != null)
            {
                if (p.val == val)
                {
                    q.next = p.next;
                }
                else
                {
                    q = p;
                }
                p = p.next;
            }
            return newStart.next;
        }
    }
}
