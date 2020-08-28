using DS.LinkedLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists
{
    public class Cycle
    {
        public bool HasCycleHashSet(ListNode head)
        {
            HashSet<ListNode> nodesSeen = new HashSet<ListNode>();
            while (head != null)
            {
                if (nodesSeen.Contains(head))
                {
                    return true;
                }
                else
                {
                    nodesSeen.Add(head);
                }
                head = head.next;
            }
            return false;
        }

        public bool HasCycle2Pointers(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return false;
            }
            ListNode slow = head;
            ListNode fast = head.next;
            while (slow != fast)
            {
                if (fast == null || fast.next == null)
                {
                    return false;
                }
                slow = slow.next;
                fast = fast.next.next;
            }
            return true;
        }
    }
}
