using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming.Memoization.Knapsack
{
    public class PartitionEqualSubsetSum
    {
        // Set = [1,5,11,5], result = true. as {1,5,5} and {11}
        public static bool FindEqualPartitions(int[] set)
        {
            int sum = 0;
            for (int i = 0; i < set.Length; i++)
            {
                sum += set[i];
            }

            int target = sum / 2;
            // IF target is odd, cannot split in 2 equal halves
            if (sum % 2 != 0)
            {
                return false;
            }
            else
            {
                SubsetSum subsetSum = new SubsetSum();
                return subsetSum.IsSubsetSum(set, target);
            }
        }
    }
}
