using DS.LinkedLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists
{
    public class Palindrome
    {
        // First Method. Add all nodes to List and use 2 pointers to traverse front and back
        public static bool IsPalindromeWithSpace(ListNode head)
        {
            List<int> list = new List<int>();
            var temp = head;
            while (temp != null)
            {
                list.Add(temp.val);
                temp = temp.next;
            }

            var arr = list.ToArray();
            int end = arr.Length - 1;
            for (int i = 0; i < arr.Length / 2; i++, end--)
            {
                if (arr[i] != arr[end])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsPalindrome(ListNode head)
        {
            if (head == null)
            {
                return true;
            }
            ListNode p = head; // slow
            ListNode q = head; // fast
            ListNode secondList = null;

            // Find middle and split list into 2 halves
            while (q != null && q.next != null)
            {
                q = q.next.next;
                if (q == null) // even
                {
                    secondList = p.next;
                    break;
                }
                if (q.next == null) // odd
                {
                    secondList = p.next.next;
                    break;
                }
                p = p.next;
            }
            p.next = null;
            // Reverse the second half
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
