using DS.LinkedLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists.Clone
{
    public class CloneList
    {
        public static ListNode CopyList(ListNode head)
        {
            ListNode newHeadTemp = null;
            ListNode temp = head;
            ListNode newHead = null;

            // Copy a list to new list
            while (temp != null)
            {
                ListNode node = new ListNode(temp.val);

                if (newHeadTemp == null)
                {
                    newHeadTemp = node;
                    newHead = newHeadTemp;
                }
                else
                {
                    newHeadTemp.next = node;
                    newHeadTemp = newHeadTemp.next;
                }
                temp = temp.next;
            }
            return newHead;
        }
    }
}
