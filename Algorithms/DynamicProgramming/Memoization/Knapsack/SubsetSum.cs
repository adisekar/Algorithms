using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming.Memoization.Knapsack
{
    public class SubsetSum
    {
        Dictionary<string, bool> map = new Dictionary<string, bool>();
        // Set = [1,2,3], sum = 5, result = true. as {2,3} = 5
        public bool IsSubsetSum(int[] set, int sum)
        {
            return IsSubsetSumDFS(set, 0, sum);
        }

        private bool IsSubsetSumDFS(int[] set, int n, int sum)
        {
            string current = n + "-" + sum;
            if (map.ContainsKey(current))
            {
                return map[current];
            }
            // Base case
            if ((n == set.Length) && sum == 0)
            {
                return true;
            }

            if (sum < 0 || n >= set.Length)
            {
                return false;
            }

            // Recursive case
            // 2 cases. Exclude number or Include number
            map[current] = IsSubsetSumDFS(set, n + 1, sum) || IsSubsetSumDFS(set, n + 1, sum - set[n]);
            return map[current];
        }
    }
}
