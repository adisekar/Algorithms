using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming.Tabulation
{
    public class BestSum
    {
        public static List<int> BestSumTarget(int target, int[] nums)
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
                    if (dp[i] != null && index > 0 && index < dp.Length)
                    {
                        // 2 case if dp[index] == null, always replace. else check length then replace
                        // Only replace dp[index] if number coming in combination is lesser than what is currently there
                        if (dp[index] == null || dp[i].Count + 1 < dp[index].Count)
                        {
                            dp[index] = new List<int>(dp[i]);
                            dp[index].Add(nums[j]);
                        }
                    }
                }
            }
            return dp[target];
        }
    }
}
