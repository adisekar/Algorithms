using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Heap
{
    public abstract class HeapBase
    {
        public int[] array { get; set; }
        public int MAX_SIZE { get; set; }
        public int count { get; set; }

        public HeapBase(int length)
        {
            array = new int[length];
            MAX_SIZE = length;
        }


        // 2i + 1
        public int GetLeftChildIndex(int index)
        {
            if (index < count)
            {
                return (2 * index) + 1;
            }
            return -1;
        }

        // 2i + 2
        public int GetRightChildIndex(int index)
        {
            if (index < count)
            {
                return (2 * index) + 2;
            }
            return -1;
        }

        // (i-1)/2
        public int GetParentIndex(int index)
        {
            if (index > 0)
            {
                return (index - 1) / 2;
            }
            return -1;
        }

        // Helper Methods
        public void Swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }


        public int GetElementAtIndex(int[] arr, int index)
        {
            if (index > count)
            {
                return -1;
            }
            return arr[index];
        }

        public int PeekPriorityElement()
        {
            if (!IsEmpty())
            {
                return array[0];
            }
            return -1;
        }


        public bool IsFull()
        {
            return count >= MAX_SIZE ? true : false;
        }

        public bool IsEmpty()
        {
            return count == 0 ? true : false;
        }
    }
}
