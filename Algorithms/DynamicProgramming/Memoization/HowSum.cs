using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming.Memoization
{
    public class HowSum
    {
        static Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        static List<int> remResults = null;
        public static List<int> HowSumTarget(int target, int[] nums)
        {
            if (map.ContainsKey(target)) { return map[target]; }

            if (target == 0) { return new List<int>(); }
            if (target < 0) { return null; }

            for (int i = 0; i < nums.Length; i++)
            {
                int rem = target - nums[i];
                // If atleast 1 returns [], we can return that array with adding the edge value
                remResults = HowSumTarget(rem, nums);
                map[rem] = remResults;
                if (remResults != null)
                {
                    remResults.Add(nums[i]);
                    break;
                }
            }
            return remResults != null ? remResults : null;
        }
    }
}
