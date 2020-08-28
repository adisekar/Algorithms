using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Searching
{
    public class BinarySearch
    {
        // O(log n) time, O(1) space
        public static int IterativeSearch(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (nums[middle] == target)
                {
                    return middle;
                }

                if (target < nums[middle])
                {
                    right = middle - 1;
                }

                if (target > nums[middle])
                {
                    left = middle + 1;
                }
            }
            return -1;
        }

        // O(log n) time, O(log n) space, for call stack
        public static int RecursiveSearch(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            return RecursiveSearchHelper(nums, target, left, right);
        }

        private static int RecursiveSearchHelper(int[] nums, int target, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }
            int middle = (left + right) / 2;
            if (nums[middle] == target)
            {
                return middle;
            }

            if (target < nums[middle])
            {
                right = middle - 1;
                return RecursiveSearchHelper(nums, target, left, right);
            }

            if (target > nums[middle])
            {
                left = middle + 1;
                return RecursiveSearchHelper(nums, target, left, right);
            }
            return -1;
        }
    }
}
