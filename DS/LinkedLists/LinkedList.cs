using System;
using System.Collections.Generic;
using System.Text;

namespace DS.LinkedLists
{
    public class LinkedList
    {
        public ListNode head { get; set; }

        public ListNode ConstructList(int[] nums)
        {
            foreach (var num in nums)
            {
                InsertAtEnd(num);
            }
            return head;
        }
        public void InsertAtStart(int data)
        {
            ListNode newNode = new ListNode(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }

        public void InsertAtEnd(int data)
        {
            ListNode newNode = new ListNode(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }

        public void InsertAtPosition(int data, int position)
        {
            ListNode newNode = new ListNode(data);
            var loop = head;
            while (position-- != 0)
            {
                if (position == 0)
                {
                    var temp = loop.next;
                    loop.next = newNode;
                    newNode.next = temp;
                    break;
                }
                loop = loop.next;
            }
        }

        public int CountNodes()
        {
            int count = 0;
            var temp = head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }

        public void InsertAtMiddle(int data)
        {
            int midLength = 0;
            int count = CountNodes();
            if (count % 2 == 0)// Even
            {
                midLength = count / 2;
            }
            else
            {
                midLength = (count + 1) / 2;
            }

            ListNode temp = head;
            int loopCount = 0;
            while (temp != null && loopCount < midLength - 1)
            {
                temp = temp.next;
                loopCount++;
            }

            // At correct position after loop completes
            ListNode newNode = new ListNode(data);
            ListNode temp2 = temp.next;
            temp.next = newNode;
            newNode.next = temp2;
        }

        public List<int> PrintList(ListNode head = null)
        {
            List<int> result = new List<int>();
            ListNode temp = null;
            if (head == null)
            {
                temp = this.head;
            }
            else
            {
                temp = head;
            }

            while (temp != null)
            {
                result.Add(temp.val);
                temp = temp.next;
            }
            return result;
        }
    }
}
