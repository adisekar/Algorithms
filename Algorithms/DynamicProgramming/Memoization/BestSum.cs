using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming.Memoization
{
    public class BestSum
    {
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        List<int> combination = null;
        public List<int> BestSumTarget(int target, int[] nums)
        {
            if (map.ContainsKey(target)) { return map[target]; }

            if (target == 0) { return new List<int>(); }
            if (target < 0) { return null; }

            List<int> shortestCombination = null;

            for (int i = 0; i < nums.Length; i++)
            {
                int rem = target - nums[i];
                // If atleast 1 returns [], we can return that array with adding the edge value
                combination = BestSumTarget(rem, nums);
                if (combination != null)
                {
                    combination.Add(nums[i]);
                    if (shortestCombination == null || combination.Count < shortestCombination.Count)
                    {
                        shortestCombination = combination;
                    }
                }
            }
            map[target] = shortestCombination;
            return shortestCombination;
        }
    }
}
