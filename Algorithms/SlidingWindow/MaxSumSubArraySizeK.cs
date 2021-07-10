using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.SlidingWindow
{
    public class MaxSumSubArraySizeK
    {
        // A = [2,1,5,1,3,2] , k = 3. O/p = 5 + 1 + 3 = 9
        public static int GetMax(int[] A, int k)
        {
            if (A.Length < k)
            {
                return -1;
            }

            int curSum = 0;
            // Precomput till k sum
            for (int i = 0; i < k; i++)
            {
                curSum += A[i];
            }
            int maxSum = curSum;

            for (int i = k, l = 0; i < A.Length; i++, l++)
            {
                curSum += A[i];
                curSum -= A[l];
                maxSum = Math.Max(curSum, maxSum);
            }
            return maxSum;
        }

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
    }
}
