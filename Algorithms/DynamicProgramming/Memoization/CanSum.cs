using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming.Memoization
{
    public class CanSum
    {
        static Dictionary<int, bool> map = new Dictionary<int, bool>();
        public static bool CanSumTarget(int target, int[] nums)
        {
            if (map.ContainsKey(target)) { return map[target]; }
            if (target == 0) { return true; }
            if (target < 0) { return false; }

            for (int i = 0; i < nums.Length; i++)
            {
                int rem = target - nums[i];
                // If atleast 1 returns true, we can return true overall
                // and break early
                map[rem] = CanSumTarget(rem, nums);
                if (map[rem])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
