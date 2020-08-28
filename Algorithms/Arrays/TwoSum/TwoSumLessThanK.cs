using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.TwoSum
{
    public class PairLessThanK
    {
        public int TwoSumLessThanK(int[] A, int K)
        {
            Array.Sort(A);
            int i = 0;
            int j = A.Length - 1;
            int maxSum = -1;

            while (i < j && i < A.Length && j > 0)
            {
                int currentSum = A[i] + A[j];
                if (currentSum < K)
                {
                    maxSum = Math.Max(maxSum, currentSum);
                }
                if (currentSum < K)
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }
            return maxSum;
        }
    }
}
