using DS.LinkedLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists
{
    public class Add
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            // If numbers are in normal order, reverse it first, so smallest digit is first
            // Step 1 - Get length of both lists. Get abs difference, and pad wit zeroes on smaller list
            // Step 2 - Add elements, divide by 10, calculate carry and reminder, if divide by 0 is more than 1
            // Step 3 - Go to next element, add carry to it, if present, and repeat step 2
            // Step 4 - If remaining carry remains, create new node and add it
            int carry, reminder;
            ListNode result = new ListNode(-1);
            ListNode resultTemp = result;
            carry = 0;
            // instead of calculating lengths and diff, we can just use l1 || l2 != null, and if null during add keep it as 0.
            while (l1 != null || l2 != null)
            {
                int add = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
                // Reinit carry as 0
                carry = 0;
                int divideBy10 = add / 10;
                reminder = add % 10;
                if (divideBy10 > 0)
                {
                    carry = divideBy10;
                    add = reminder;
                }
                resultTemp.next = new ListNode(add);

                resultTemp = resultTemp.next;
                l1 = l1 != null ? l1.next : l1;
                l2 = l2 != null ? l2.next : l2;
            }

            if (carry > 0)
            {
                resultTemp.next = new ListNode(carry);
            }

            return result.next;
        }
    }
}
