using System;
using System.Collections.Generic;
using System.Text;

namespace DS.LinkedLists.DoublyLinkedList
{
    public class DLinkedList
    {
        public DListNode head { get; set; }
        public DListNode tail { get; set; }

        public void InsertAtStart(int data)
        {
            DListNode newNode = new DListNode(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }
        }

        public void InsertAtTail(int data)
        {
            DListNode newNode = new DListNode(data);
            if (tail == null)
            {
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
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

        public List<int> PrintList(DListNode head = null)
        {
            List<int> result = new List<int>();
            DListNode temp = null;
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

        public bool AddAtIndex(int index, int val)
        {
            DListNode node = new DListNode(val);
            var temp = this.head;
            int count = 1;
            while (count != index)
            {
                if (temp != null)
                {
                    temp = temp.next;
                }
                else
                {
                    return false;
                }
                count++;
            }
            if (temp != null)
            {
                var tempNext = temp.next;
                temp.next = node;
                node.next = tempNext;
                node.prev = temp;
            }
            else
            {
                temp = node;
            }
            return true;
        }

        public bool DeleteAtIndex(int index)
        {
            var temp = this.head;
            int count = 1;
            while (count != index)
            {
                if (temp != null)
                {
                    temp = temp.next;
                }
                else
                {
                    return false;
                }
                count++;
            }
            if (temp != null)
            {
                temp.next = temp.next.next;
                temp.next.prev = temp.prev;
            }
            return true;
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            int count = 0;
            var temp = this.head;
            while (count != index)
            {
                if (temp == null)
                {
                    return -1;
                }
                temp = temp.next;
                count++;
            }
            return count == index && temp != null ? temp.val : -1;
        }

        public List<int> Reverse()
        {
            var temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            List<int> result = new List<int>();
            while (temp != null)
            {
                result.Add(temp.val);
                temp = temp.prev;
            }
            return result;
        }
    }
}
