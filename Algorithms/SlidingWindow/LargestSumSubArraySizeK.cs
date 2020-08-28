using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.SlidingWindow
{
    public class LargestSumSubArraySizeK
    {
        public static int[] Max_BF(int[] nums, int k)
        {
            int[] result = new int[nums.Length - k + 1];

            for (int i = 0; i <= nums.Length - k; i++)
            {
                int max = nums[i];
                for (int j = i + 1; j < i + k; j++)
                {
                    max = Math.Max(max, nums[j]);
                }
                result[i] = max;
            }
            return result;
        }

        public static int Sum(int[] nums, int k)
        {
            int max = 0;
            int start = 0;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
                if (i >= k - 1)
                {
                    max = Math.Max(sum, max);
                    sum = sum - nums[start];
                    start++;
                }
            }
            return max;
        }
    }
}
