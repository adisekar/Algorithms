using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    /*
     Input: nums = [1,5,11,5]
Output: true
Explanation: The array can be partitioned as [1, 5, 5] and [11].

Example 2:
Input: nums = [1,2,3,5]
Output: false
Explanation: The array cannot be partitioned into equal sum subsets.
     */
    public class PartitionEqualSubsetSum2
    {
        // Without state, run time is 2^N
        // With state it is N*M
        public static bool CanPartition2(int[] nums)
        {
            int total = 0;
            foreach (var num in nums)
            {
                total += num;
            }

            // If odd, we cannot split equally in half, so no subset possible
            if (total % 2 != 0)
            {
                return false;
            }

            return CanPartitionHelper(nums, 0, 0, total, new Dictionary<string, bool>());
        }

        public static bool CanPartitionHelper(int[] nums, int index, int currSubsetSum, int total, Dictionary<string, bool> state)
        {
            string current = index + "" + currSubsetSum;
            if (state.ContainsKey(current))
            {
                return state[current];
            }

            // Base case
            if (currSubsetSum * 2 == total)
            {
                return true;
            }

            if ((currSubsetSum > total / 2) || (index >= nums.Length))
            {
                return false;
            }

            // Recusrive case
            // 2 cases like 0/1 knapsack, taking and not taking number
            bool foundPartition = CanPartitionHelper(nums, index + 1, currSubsetSum + nums[index], total, state) ||
                CanPartitionHelper(nums, index + 1, currSubsetSum, total, state);
            state.Add(current, foundPartition);
            return foundPartition;
        }
    }
}
