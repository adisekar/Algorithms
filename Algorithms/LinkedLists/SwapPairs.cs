using DS.LinkedLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists
{
    public class SwapPairs
    {
         // 1-> 2 -> 3 -> 4 -> null
         // 2 -> 1 -> 4 -> 3 -> null
        public ListNode Swap(ListNode head)
        {
            // Initial boundary check
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode p = head;
            ListNode newStart = head.next;

            while (true)
            {
                ListNode q = p.next;
                ListNode temp = q.next;
                q.next = p;

                if (temp == null || temp.next == null)
                {
                    p.next = temp;
                    break;
                }
                p.next = temp.next;
                p = temp;
            }
            return newStart;
        }
    }
}
