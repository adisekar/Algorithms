using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    public class JumpGame
    {
        // [2,3,1,1,4] true
        // [3,2,1,0,4] false
        public static bool CanJump(int[] nums)
        {
            int reachable = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                // If we cannot reach i, from current reachable =, means there was 0, we return false
                if (reachable < i)
                {
                    return false;
                }
                reachable = Math.Max(reachable, nums[i] + i);
            }
            return true;
        }
    }
}
