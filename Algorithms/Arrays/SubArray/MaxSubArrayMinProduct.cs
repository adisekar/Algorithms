using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.SubArray
{
    public class MaxSubArrayMinProduct
    {
        public static int FindMinProduct(int[] nums)
        {
            int result = int.MinValue;
            // Brute Force
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    int min = int.MaxValue;
                    int sum = 0;
                    // start from i and go till j
                    for (int k = i; k <= j; k++)
                    {
                        min = Math.Min(min, nums[k]);
                        sum += nums[k];
                    }
                    int product = min * sum;
                    result = Math.Max(result, product);
                }
            }
            return result;
        }
    }
}
