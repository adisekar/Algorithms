using DS.LinkedLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists
{
    public class Intersection
    {
        // 2 stacks and push elements of headA in stackA and headB in stackB
        // Now till both stacks are not null, pop items and compare. If equal, store in temp, else return stored value
        public ListNode GetIntersectionNodeUsingStacks(ListNode headA, ListNode headB)
        {
            Stack<ListNode> stackA = new Stack<ListNode>();
            Stack<ListNode> stackB = new Stack<ListNode>();

            while (headA != null)
            {
                stackA.Push(headA);
                headA = headA.next;
            }

            while (headB != null)
            {
                stackB.Push(headB);
                headB = headB.next;
            }

            ListNode temp = null;
            while (stackA.Count > 0 && stackB.Count > 0)
            {
                ListNode a = stackA.Pop();
                ListNode b = stackB.Pop();

                if (a == b)
                {
                    temp = a;
                }
                else
                {
                    break;
                }
            }
            return temp;
        }

        // Calculate length of both lists and find abs diff
        // Move lower linked list to diff of length places
        // Now loop over both lists, till there is an node which is equal.
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode tempA = headA;
            ListNode tempB = headB;

            // Calculate length of both linkedList
            int lenA = 0;
            int lenB = 0;
            while (tempA != null)
            {
                lenA++;
                tempA = tempA.next;
            }

            while (tempB != null)
            {
                lenB++;
                tempB = tempB.next;
            }

            int diff = Math.Abs(lenA - lenB);

            // Move smaller pointer to the diff
            tempA = headA;
            tempB = headB;
            int i = 1;
            if (lenA > lenB)
            {
                while (i <= diff)
                {
                    tempA = tempA.next;
                    i++;
                }
            }
            else
            {
                while (i <= diff)
                {
                    tempB = tempB.next;
                    i++;
                }
            }

            ListNode intersect = null;
            // Now move both pointers to find intersection
            while (tempA != null && tempB != null)
            {
                if (tempA == tempB)
                {
                    intersect = tempA;
                    break;
                }
                tempA = tempA.next;
                tempB = tempB.next;
            }

            return intersect;
        }

        public ListNode GetIntersectionNodeUsingSet(ListNode headA, ListNode headB)
        {
            HashSet<ListNode> set = new HashSet<ListNode>();

            ListNode tempA = headA;
            while (tempA != null)
            {
                set.Add(tempA);
                tempA = tempA.next;
            }

            ListNode tempB = headB;
            ListNode result = null;
            while (tempB != null)
            {
                if (set.Contains(tempB))
                {
                    result = tempB;
                    break;
                }
                tempB = tempB.next;
            }
            return result;
        }
    }
}
