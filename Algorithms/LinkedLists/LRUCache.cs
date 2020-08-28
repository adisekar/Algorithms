using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists
{
    public class LRUCache
    {
        private Dictionary<int, DListNode> map = new Dictionary<int, DListNode>();
        public DListNode head;
        private DListNode tail;
        private int size;
        private int capacity;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            this.size = 0;
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

        public void AddNode(DListNode newNode)
        {
            if (tail == null)
            {
                tail = newNode;
                head = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
            }
            size++;
        }

        public void MoveToTop(DListNode node)
        {
            if (node == head)
            {
                head = head.next;
                head.prev = null;
            }
            else
            {
                node.prev = node.next;
                node.next.prev = node.prev;
            }

            tail.next = node;
            node.prev = tail;
            tail = node;
        }

        public void RemoveNode()
        {
            if (head == null)
            {
                return;
            }
            else
            {
                head = head.next;
                head.prev = null;
            }
            size--;
        }

        public int Get(int key)
        {
            if (map.ContainsKey(key))
            {
                MoveToTop(map[key]);
                return map[key].val;
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            DListNode newNode = new DListNode(key, value);

            if (size > capacity)
            { // evict first added item
                RemoveNode();
                map.Remove(key);
            }
            map.Add(key, newNode);
            AddNode(newNode);
        }
    }

    /**
     * Your LRUCache object will be instantiated and called as such:
     * LRUCache obj = new LRUCache(capacity);
     * int param_1 = obj.Get(key);
     * obj.Put(key,value);
     */

    public class DListNode
    {
        public int key { get; set; }
        public int val { get; set; }
        public DListNode next { get; set; }
        public DListNode prev { get; set; }
        public DListNode(int key, int val)
        {
            this.key = key;
            this.val = val;
            this.next = null;
            this.prev = null;
        }
    }
}
