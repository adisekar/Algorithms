using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    public class MaxSubsetAdjacentSum
    {
        // [75, 105, 120, 75, 90, 135] . O/p = 330
        // O(n) time and space, as we use dp array
        public static int MaxSubsetSumNoAdjacentWithSpace(int[] array)
        {
            // Write your code here.
            int n = array.Length;
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return array[0];
            }

            int[] dp = new int[n];
            dp[0] = array[0];
            dp[1] = Math.Max(array[0], array[1]);

            for (int i = 2; i < n; i++)
            {
                dp[i] = Math.Max(dp[i - 1], dp[i - 2] + array[i]);
            }
            return dp[n - 1];
        }

        public static int MaxSubsetSumNoAdjacent(int[] array)
        {
            // Write your code here.
            int n = array.Length;
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return array[0];
            }

            int prevTwo = array[0];
            int prevOne = Math.Max(array[0], array[1]);
            int current = 0;

            for (int i = 2; i < n; i++)
            {
                current = Math.Max(prevOne, prevTwo + array[i]);
                prevTwo = prevOne;
                prevOne = current;
            }
            return prevOne;
        }
    }
}
