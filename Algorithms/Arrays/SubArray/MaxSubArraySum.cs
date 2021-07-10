using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.SubArray
{
    public class MaxSubArraySum
    {
        // Kadane's Algo
        public int MaxSubArray(int[] nums)
        {
            int max = nums[0];
            int currMax = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                currMax = Math.Max(nums[i], currMax + nums[i]);
                max = Math.Max(currMax, max);
            }
            return max;
        }

        // Above implementation returns smallest negative number, if arr is ALL negative
        // But this implementation returns 0
        public int MaxSubArrayReturn0IfNegative(int[] nums)
        {
            int curMax = 0;
            int max = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                curMax = Math.Max(0, curMax + nums[i]);
                max = Math.Max(curMax, max);
            }
            return max;
        }
    }
}
