using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search.SortedRotated
{
    public class MinimumElement
    {
        public int FindMin(int[] nums)
        {
            int n = nums.Length;
            if (n == 0)
                return -1;
            if (n == 1)
                return nums[0];
            int pivot = FindPivotIndex(nums, 0, nums.Length - 1);
            return nums[pivot];
        }

        private int FindPivotIndex(int[] A, int start, int end)
        {
            if (start >= end)
            {
                return 0;
            }
            int mid = start + ((end - start) / 2);

            if (A[mid] > A[mid + 1])
            {
                return mid + 1;
            }
            else
            {
                if (A[start] < A[mid])
                {
                    // pivot is in m+ 1 to end
                    return FindPivotIndex(A, mid + 1, end);
                }
                else
                {
                    return FindPivotIndex(A, start, mid - 1);
                }
            }
        }
    }
}
