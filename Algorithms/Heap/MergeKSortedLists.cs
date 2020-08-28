using Algorithms.LinkedLists;
using DS.Heap;
using DS.LinkedLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Heap
{
    public class MergeKSortedLists
    {
        public static ListNode MergeUsingHeap(ListNode[] lists)
        {
            MinHeap minHeap = new MinHeap(40);
            foreach (var head in lists)
            {
                ListNode p = head;
                while (p != null)
                {
                    minHeap.Insert(p.val);
                    p = p.next;
                }
            }

            ListNode dummy = new ListNode(-1);
            ListNode newHead = dummy;
            while (!minHeap.IsEmpty())
            {
                ListNode node = new ListNode(minHeap.PeekPriorityElement());
                minHeap.Remove();
                dummy.next = node;
                dummy = dummy.next;
            }
            return newHead.next;
        }

        public static ListNode MergeDivideAndConquer(ListNode[] lists)
        {
            ListNode result = null;
            for (int i = 0; i < lists.Length; i++)
            {
                var head1 = result;
                var head2 = lists[i];
                result = MergeTwoSortedLists.MergeTwoLists(head1, head2);
            }
            return result;
        }

        public static ListNode MergeKListsOneByOne(ListNode[] lists)
        {
            int minListIndex = 0;
            ListNode head = new ListNode(-1);
            ListNode h = head;

            while (true)
            {
                bool isBreak = true;
                int min = Int32.MaxValue;
                for (int i = 0; i < lists.Length; i++)
                {
                    if (lists[i] != null)
                    {
                        if (lists[i].val < min)
                        {
                            minListIndex = i;
                            min = lists[i].val;
                        }
                        isBreak = false;
                    }
                }
                if (isBreak)
                {
                    break;
                }

                ListNode a = new ListNode(lists[minListIndex].val);
                h.next = a;
                h = h.next;
                lists[minListIndex] = lists[minListIndex].next;
            }
            h.next = null;
            return head.next;
        }
    }
}
