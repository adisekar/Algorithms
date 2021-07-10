using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming.Tabulation
{
    public class HowSum
    {
        public static List<int> HowSumTarget(int target, int[] nums)
        {
            List<int>[] dp = new List<int>[target + 1];
            // Initialize all array elements to null, done by default
            // Initialize 0th element as empty, so we can add items in it later
            dp[0] = new List<int>();

            for (int i = 0; i <= target; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    int index = i + nums[j];
                    if(dp[i] != null && index > 0 && index < dp.Length)
                    {
                        dp[index] = new List<int>(dp[i]);
                        dp[index].Add(nums[j]);
                    }
                }
            }
            return dp[target];
        }
    }
}
