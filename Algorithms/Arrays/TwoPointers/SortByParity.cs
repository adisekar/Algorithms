using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.TwoPointers
{
    public class SortByParity
    {
        // Better as time is O(n/2)
        public int[] SortArrayByParity(int[] A)
        {
            int i = 0;
            int j = A.Length - 1;

            while (i < j && i < A.Length && j >= 0)
            {
                // If even
                while (i < A.Length && A[i] % 2 == 0)
                {
                    i++;
                }

                // If odd
                while (j >= 0 && A[j] % 2 == 1)
                {
                    j--;
                }

                if (i < A.Length && j >= 0 && i < j)
                {
                    Swap(A, i, j);
                    i++;
                    j--;
                }
            }
            return A;
        }

        private void Swap(int[] A, int i, int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }

        public int[] SortArrayByParity_Linear(int[] A)
        {
            int index = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    Swap(A, index, i);
                    index++;
                }
            }
            return A;
        }
    }
}
