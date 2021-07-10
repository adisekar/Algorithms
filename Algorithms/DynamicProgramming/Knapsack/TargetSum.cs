using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming.Knapsack
{
    /*
     You are given a list of non-negative integers, a1, a2, ..., an, and a target, S. Now you have 2 symbols + and -. For each integer, you should choose one from + and - as its new symbol.

Find out how many ways to assign symbols to make sum of integers equal to target S.

Example 1:

Input: nums is [1, 1, 1, 1, 1], S is 3. 
Output: 5
Explanation: 

-1+1+1+1+1 = 3
+1-1+1+1+1 = 3
+1+1-1+1+1 = 3
+1+1+1-1+1 = 3
+1+1+1+1-1 = 3

There are 5 ways to assign symbols to make the sum of nums be target 3.
     */
    public class TargetSum
    {
        int count = 0;
        public int FindTargetSumWays(int[] nums, int S)
        {
            FindTargetSumWaysDFS(nums, 0, 0, S);
            return count;
        }

        public void FindTargetSumWaysDFS(int[] set, int i, int sum, int S)
        {
            // Base case
            if (i == set.Length)
            {
                if (sum == S)
                {
                    count++;
                }
            }
            else
            {
                // Recursive case
                // Add + in every number, then add - t0 every number.
                // Same as 0/1 knapsack
                FindTargetSumWaysDFS(set, i + 1, sum + set[i], S);
                FindTargetSumWaysDFS(set, i + 1, sum - set[i], S);
            }
        }
    }
}
