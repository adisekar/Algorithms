using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists
{
    public class LRUCache
    {
        public DNode head;
        private DNode tail;
        private Dictionary<int, DNode> map;
        private int size;

        // Insert at tail (MRU)
        // Delete at head (LRU)


        public LRUCache(int capacity)
        {
            map = new Dictionary<int, DNode>();
            size = capacity;
        }

        public int Get(int key)
        {
            if (map.ContainsKey(key))
            {
                // Move element to top of list. Easier is to delete current element and insert new element to tail of list. O(1)
                int nodeVal = map[key].val;
                Delete(map[key]);
                DNode node = Insert(key, nodeVal);
                map[key] = node;
                return node.val;
            }
            else
            {
                return -1;
            }

        }

        public void Put(int key, int value)
        {
            // If size = map elements, and it is a new key, remove from map
            if (size == map.Count && !map.ContainsKey(key))
            {
                if (this.head != null)
                {
                    DNode toRemoveNode = map[this.head.key];
                    this.head = toRemoveNode.next;
                    toRemoveNode.prev = null;
                    if (toRemoveNode.next != null)
                    {
                        toRemoveNode.next.prev = null;
                    }
                    map.Remove(toRemoveNode.key);
                }
            }

            if (map.ContainsKey(key))
            {
                Delete(map[key]);
                DNode node = Insert(key, value);
                map[key] = node;
            }
            else
            {
                DNode node = Insert(key, value);
                map.Add(key, node);
            }
        }

        private DNode Insert(int key, int val)
        {
            DNode node = new DNode(key, val);
            if (tail == null)
            {
                tail = node;
            }
            else
            {
                tail.next = node;
                node.prev = tail;
                tail = node;
            }

            if (head == null)
            {
                head = node;
            }
            return node;
        }

        private void Delete(DNode node)
        {
            // Do null checks. And update head and tail
            if (node != null && node.prev != null)
            {
                node.prev.next = node.next;
            }

            if (node != null && node.next != null)
            {
                node.next.prev = node.prev;
            }


            if (head == node)
            {
                head = node.next;
            }

            if (tail == node)
            {
                tail = tail.prev;
            }
        }
    }

    /**
     * Your LRUCache object will be instantiated and called as such:
     * LRUCache obj = new LRUCache(capacity);
     * int param_1 = obj.Get(key);
     * obj.Put(key,value);
     */

    public class DNode
    {
        public int key { get; set; }
        public int val { get; set; }
        public DNode next { get; set; }
        public DNode prev { get; set; }
        public DNode(int key, int val)
        {
            this.key = key;
            this.val = val;
            this.next = null;
            this.prev = null;
        }
    }
}
