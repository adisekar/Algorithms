﻿using DS.LinkedLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists
{
    public class MergeTwoSortedLists
    {
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(-1);
            ListNode head = dummy;
            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    dummy.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    dummy.next = l2;
                    l2 = l2.next;
                }
                dummy = dummy.next;
            }

            // When one list is not null
            while (l1 != null)
            {
                dummy.next = l1;
                l1 = l1.next;
                dummy = dummy.next;
            }
            while (l2 != null)
            {
                dummy.next = l2;
                l2 = l2.next;
                dummy = dummy.next;
            }
            return head.next;
        }
    }
}
