using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.TwoSum
{
    public class ThreeSumClosest
    {
        public static int FindClosest(int[] nums, int target)
        {
            int result = nums[0] + nums[1] + nums[nums.Length - 1];
            Array.Sort(nums);
            int n = nums.Length;
            //int closest = Int32.MaxValue;
            for (int i = 0; i < n - 2; i++)
            {
                int left = i + 1;
                int right = n - 1;
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    // Check if current difference is lesser than prev diff
                    if (Math.Abs(sum - target) < Math.Abs(result - target))
                    {
                        result = sum;
                    }

                    if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return result;
        }
    }
}
