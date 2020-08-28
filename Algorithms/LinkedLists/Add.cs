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
            int carry = 0;

            ListNode head = null;
            ListNode result = null;
            ListNode newNode = null;
            while (l1 != null && l2 != null)
            {
                // Addition step
                int add = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
                carry = 0;

                if (add > 9)
                {
                    // Divide by 10
                    int divide = add / 10;
                    if (divide != 0)
                    { // divide result is > 0
                        carry = divide;
                    }
                    int reminder = add % 10;
                    newNode = new ListNode(reminder);
                }
                else
                {
                    newNode = new ListNode(add);
                }
                if (head == null)
                {
                    result = newNode;
                    head = result;
                }
                else
                {
                    result.next = newNode;
                    result = result.next;
                }
                l1 = l1 != null ? l1.next : l1;
                l2 = l2 != null ? l2.next : l2;
            }
            // For overflow numbers
            if (carry > 0)
            {
                newNode = new ListNode(carry);
                result.next = newNode;
            }
            return head;
        }
    }
}
