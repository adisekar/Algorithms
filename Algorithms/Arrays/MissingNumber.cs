using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public class MissingNumber
    {
        // Total sum is for n length of elements.
        // n * (n+1)/2
        public static int FindMissingNumber(int[] nums)
        {
            int len = nums.Length;
            int total = len * (len + 1) / 2;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
            }
            return total - sum;
        }
    }
}
