using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming.Tabulation
{
    public class FibonacciNumber
    {
        public static int Fib(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;

            if(n < 2)
            {
                return dp[n];
            }

            for(int i =2; i<=n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }
    }
}
