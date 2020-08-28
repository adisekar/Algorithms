using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DS.Heap
{
    // Sift Up/ Down is O(log n)
    // Build Heap is in O(n)
    public class MinHeap : HeapBase, IComparer<int>
    {
        public MinHeap(int length) : base(length)
        {
        }
        // Take existing array and make it in heap
        public int[] BuildHeap(int[] arr)
        {
            int lastIndex = arr.Length - 1;
            MAX_SIZE = arr.Length;
            count = arr.Length - 1;
            this.array = arr;

            int parentIndex = GetParentIndex(lastIndex);

            for (int i = parentIndex; i >= 0; i--)
            {
                SiftDown(i);
            }
            return arr;
        }

        // Insert to end of array
        public void Insert(int newValue)
        {
            if (count >= MAX_SIZE)
            {
                Console.WriteLine("Heap is full");
                return;
            }

            array[count] = newValue;
            if (count != 0)
            {
                SiftUp(count);
            }
            count++;
        }

        // Remove from top of array
        public void Remove()
        {
            if (count <= 0)
            {
                return;
            }
            // Copy last element to top of array
            array[0] = array[count - 1];
            count--;
            SiftDown(0);
        }

        // Heapify 
        public void SiftUp(int index)
        {
            if (index >= MAX_SIZE || index < 0)
            {
                return;
            }
            int newElement = GetElementAtIndex(this.array, index);
            int parentIndex = GetParentIndex(index);

            if (parentIndex > -1 && GetElementAtIndex(this.array, parentIndex) >= newElement)
            {
                Swap(array, index, parentIndex);
                SiftUp(parentIndex);
            }
        }

        // Heapify 
        public void SiftDown(int index)
        {
            if (index >= MAX_SIZE || index < 0)
            {
                return;
            }
            int newElement = GetElementAtIndex(this.array, index);
            int leftChildIndex = GetLeftChildIndex(index);
            int rightChildIndex = GetRightChildIndex(index);
            int smallerIndex = -1;
            if (leftChildIndex != -1 && rightChildIndex != -1)
            {
                smallerIndex = GetElementAtIndex(this.array, leftChildIndex) < GetElementAtIndex(this.array, rightChildIndex) ? leftChildIndex : rightChildIndex;
            }
            else if (leftChildIndex != -1)
            {
                smallerIndex = leftChildIndex;
            }
            else if (rightChildIndex != -1)
            {
                smallerIndex = rightChildIndex;
            }

            if (smallerIndex == -1)
            {
                return;
            }

            if (GetElementAtIndex(this.array, smallerIndex) < newElement && smallerIndex <= count)
            {
                Swap(array, index, smallerIndex);
                SiftDown(smallerIndex);
            }
        }

        public int Compare(int x, int y)
        {
            if (x < y)
            {
                return -1;
            }
            else if (x == y)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
