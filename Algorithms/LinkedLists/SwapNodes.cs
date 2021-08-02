using DS.LinkedLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists
{
    public class SwapNodesKFromStartAndEnd
    {
        public static ListNode SwapNodes(ListNode head, int k)
        {
            // Find kth Node from start
            ListNode p = head;
            ListNode prevP = null;

            int count = 1;
            while (p != null && count < k)
            {
                count++;
                prevP = p;
                p = p.next;
            }

            // Find kth Node from end
            ListNode dummy = new ListNode(-1);
            dummy.next = head;
            ListNode l = dummy;
            ListNode r = head;
            // Move k places to right
            count = 0;
            while (r != null && count < k)
            {
                count++;
                r = r.next;
            }

            // Move r till end, l is prev of k. l.next is kth node from end
            while (r != null)
            {
                r = r.next;
                l = l.next;
            }

            ListNode prevQ = l;
            ListNode q = l.next;

            // Swap Nodes
            ListNode temp = q.next;
            if (q == p.next)
            {
                q.next = p;
            }
            else
            {
                q.next = p.next;
            }
            p.next = temp;

            if (prevP == null)
            {

            }

            if (prevQ == null)
            {

            }

            if (prevP != null && prevQ != null)
            {
                prevP.next = q;
                if (prevQ != p)
                {
                    prevQ.next = p;
                }
            }

            return dummy.next;
        }
    }
}
