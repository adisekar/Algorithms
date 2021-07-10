using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming.Tabulation
{
    public class CanSum
    {
        public static bool CanSumTarget(int target, int[] nums)
        {
            bool[] dp = new bool[target + 1];
            dp[0] = true;

            for (int i = 0; i <= target; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    int currNum = nums[j];
                    int index = i + currNum;
                    if (dp[i] == true && index > 0 && index < dp.Length)
                    {
                        dp[index] = true;
                    }
                }
                // break early
                if (dp[target] == true) { break; }
            }
            return dp[target];
        }
    }
}
