using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public class PeakElement
    {
        // O(n) solution
        public static int FindPeakLinear(int[] nums)
        {
            int peak = nums[0];
            // Second till second last element
            for (int i = 1; i < nums.Length - 1; i++)
            {
                int num = nums[i];
                if (num > nums[i - 1] && num > nums[i + 1])
                {
                    peak = num;
                    return i;
                }
            }
            // Handle first and last element cases
            if (nums.Length > 1)
            {
                if (nums[0] > nums[1])
                {
                    return 0;
                }
                if (nums[nums.Length - 1] > nums[nums.Length - 2])
                {
                    return nums.Length - 1;
                }
            }
            return 0;
        }

        public static int FindPeakLog(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int middle = left + ((right - left) / 2);
                if (nums[middle] < nums[middle + 1])
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle;
                }
            }
            return left;
        }
    }
}
