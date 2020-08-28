using DS.LinkedLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists
{
    public class RemoveDuplicatesFromSortedList
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            ListNode p = head;

            while (p != null && p.next != null)
            {
                if (p.val == p.next.val)
                {
                    p.next = p.next.next;
                }
                else
                {
                    p = p.next;
                }
            }
            return head;
        }
    }
}
