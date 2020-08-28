using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    public class SortedRotatedArray
    {
        public static int Search(int[] nums, int target)
        {
            int n = nums.Length;
            if (n == 0)
                return -1;
            if (n == 1)
                return nums[0] == target ? 0 : -1;

            int pivotIndex = FindPivotIndex(nums);

            int s1 = 0;
            int e1 = pivotIndex == -1 ? n - 1 : pivotIndex - 1;
            int val1 = BinarySearch(nums, s1, e1, target);

            if (val1 != -1)
            {
                return val1;
            }
            int s2 = pivotIndex;
            int e2 = nums.Length - 1;
            int val2 = BinarySearch(nums, s2, e2, target);

            return val2;

        }

        private static int BinarySearch(int[] nums, int start, int end, int target)
        {
            int mid = start + ((end - start) / 2);
            if (start < 0 || start >= nums.Length ||
               end < 0 || end >= nums.Length || start > end)
            {
                return -1;
            }

            if (nums[mid] == target)
            {
                return mid;
            }

            if (target >= nums[mid])
            {
                return BinarySearch(nums, mid + 1, end, target);
            }
            else
            {
                return BinarySearch(nums, start, mid - 1, target);
            }
        }

        private static int FindPivotIndex(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;
            int pivotIndex = -1;

            while (true)
            {
                int mid = start + ((end - start) / 2);

                if (start < 0 || start >= nums.Length ||
              end < 0 || end >= nums.Length || start > end
              || mid + 1 >= nums.Length)
                {
                    return -1;
                }

                if (nums[mid] > nums[mid + 1])
                {
                    pivotIndex = mid + 1;
                    break;
                }
                else
                {
                    // Find which part does pivot exist
                    if (nums[start] > nums[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
            }
            return pivotIndex;
        }
    }
}
