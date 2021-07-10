using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class QuickSort
    {
        public static int Partition(int[] A, int l, int h)
        {
            int pivot = A[l];
            // For randomized quick sort, instead of picking low which is 0
            // Pick a random number as pivot
            int i = l;
            int j = h;

            do
            {
                do { i++; } while (A[i] <= pivot);
                do { j--; } while (A[j] > pivot);

                if (i < j)
                {
                    Swap(A, i, j);
                }
            } while (i < j);
            Swap(A, l, j);
            return j;
        }

        private static void Swap(int[] A, int i, int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }

        public static void Sort(int[] A, int l, int h)
        {
            int j;
            if (l < h)
            {
                j = Partition(A, l, h);
                Sort(A, l, j);
                Sort(A, j + 1, h);
            }
        }
    }
}
