using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Heap
{
    public class MaxHeap : HeapBase
    {
        public MaxHeap(int length) : base(length)
        {
        }

        // Take existing array and make it in heap
        public int[] BuildHeap(int[] arr)
        {
            int lastIndex = arr.Length - 1;
            MAX_SIZE = arr.Length;
            count = 2;
            this.array = arr;

            for (int i = 2; i < array.Length; i++)
            {
                Insert(arr[i], i);
            }
            return arr;
        }
        // Insert to end of array
        public void Insert(int newValue, int pos)
        {
            if (count >= MAX_SIZE)
            {
                Console.WriteLine("Heap is full");
                return;
            }

            int temp = newValue;
            int i = pos;
            while (i > 0 && temp > array[GetParentIndex(i)])
            {
                array[i] = array[GetParentIndex(i)];
                i = GetParentIndex(i);
            }
            array[i] = temp;
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

            int temp = array[count - 1];
            array[0] = array[count - 1];
            count--;
            int i = 0;
            int j = GetLeftChildIndex(i);
            while (j < count - 1)
            {
                if (array[j + 1] > array[j]) { j = j + 1; } // compare child elements
                if (array[i] < array[j])
                {
                    Swap(array, i, j);
                    i = j;
                    j = GetLeftChildIndex(i);
                }
                else
                {
                    break;
                }
                array[count] = temp;
            }
        }
    }
}
