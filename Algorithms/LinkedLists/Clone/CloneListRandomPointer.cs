using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists.Clone
{
    public class CloneListRandomPointer
    {
        // O(n) space for Hashmap of old node, new node mapping
        public RandomListNode CopyRandomListHashMap(RandomListNode head)
        {
            RandomListNode newHeadTemp = null;
            RandomListNode temp = head;
            RandomListNode newHead = null;

            // Copy a list to new list
            while (temp != null)
            {
                RandomListNode node = new RandomListNode(temp.val);

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

            // Create mapping of old to new list
            Dictionary<RandomListNode, RandomListNode> map = new Dictionary<RandomListNode, RandomListNode>();
            temp = head;
            newHeadTemp = newHead;
            while (temp != null && newHeadTemp != null)
            {
                map.Add(temp, newHeadTemp);
                temp = temp.next;
                newHeadTemp = newHeadTemp.next;
            }

            // Loop thru list again to assign random pointers
            temp = head;
            while (temp != null)
            {
                var newListNode = map[temp];
                var oldListRandom = temp.random;
                // Lookup value of random pointer in dictionary, to assign that node
                // to newNode
                if (oldListRandom != null)
                {
                    var newListRandom = map[oldListRandom];
                    newListNode.random = newListRandom;
                }
                temp = temp.next;
            }

            return newHead;
        }

        // Modifies Original List, but can be undone at end
        public static RandomListNode CopyRandomListInsertBetweenNode(RandomListNode head)
        {
            if (head == null)
            {
                return null;
            }

            // Insert new node copy between original nodes
            // 1-> 2 -> 3
            // v3-v3-v1

            // 1-> 1->2->2->3->3
            // v3-v3-v3-v3-v1-v1
            RandomListNode nCurr = head;
            while (nCurr != null)
            {
                RandomListNode newNode = new RandomListNode(nCurr.val);
                newNode.next = nCurr.next;
                nCurr.next = newNode;
                nCurr = newNode.next; //  nCurr = nCurr.next.next;
            }

            // Now loop thru and set random pointers
            nCurr = head;
            while (nCurr != null)
            {
                nCurr.next.random = nCurr.random != null ? nCurr.random.next : null;
                nCurr = nCurr.next.next;
            }

            // Unweave the linked list to get back the original linked list and the cloned list.
            // i.e. A->A'->B->B'->C->C' would be broken to A->B->C and A'->B'->C'

            RandomListNode oldListPtr = head; // A->B->C
            RandomListNode newListPtr = head.next; // A'->B'->C'

            RandomListNode newHead = head.next;
            while (oldListPtr != null)
            {
                oldListPtr.next = oldListPtr.next.next;
                newListPtr.next = (newListPtr.next != null) ? newListPtr.next.next : null;
                oldListPtr = oldListPtr.next;
                newListPtr = newListPtr.next;
            }
            return newHead;
        }

        // Modifies Original List, so may not be accepted
        public static RandomListNode CopyRandomList(RandomListNode head)
        {
            RandomListNode newHeadTemp = null;
            RandomListNode originalHead = head;
            RandomListNode newHead = null;

            // Copy a list to new list
            while (originalHead != null)
            {
                RandomListNode node = new RandomListNode(originalHead.val);

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
                originalHead = originalHead.next;
            }
            // Reset head and newList head 
            originalHead = head;
            newHeadTemp = newHead;
            // Loop to point original list next to clone list next
            // Assign clone list random to original list
            while (originalHead != null)
            {
                var temp = originalHead.next;

                originalHead.next = newHeadTemp.next;
                newHeadTemp.random = originalHead;

                originalHead = temp;
                newHeadTemp = newHeadTemp.next;
            }

            // Reset head and newList head 
            originalHead = head;
            newHeadTemp = newHead;
            // Loop to assign clone random pointers
            while (originalHead != null)
            {
                newHeadTemp.random = newHeadTemp.random != null && newHeadTemp.random.random != null ?
                    newHeadTemp.random.random.next : null;

                originalHead = originalHead.next;
                newHeadTemp = newHeadTemp.next;
            }
            return newHead;
        }
    }
}
