using DS.LinkedLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists
{
    public class Palindrome
    {
        public static bool IsPalindrome(ListNode head)
        {
            if (head == null)
            {
                return true;
            }
            ListNode p = head; // slow
            ListNode q = head; // fast
            ListNode secondList = null;

            while (q != null && q.next != null)
            {
                q = q.next.next;
                if (q == null)
                {
                    secondList = p.next;
                    break;
                }
                if (q.next == null)
                {
                    secondList = p.next.next;
                    break;
                }
                p = p.next;
            }
            p.next = null;
            ListNode reversedList = Reverse.ReverseList(secondList);

            ListNode curr = head;
            while (reversedList != null)
            {
                if (curr.val != reversedList.val)
                {
                    return false;
                }
                reversedList = reversedList.next;
                curr = curr.next;
            }
            return true;
        }
    }
}
