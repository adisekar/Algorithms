using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithms.DynamicProgramming.Tabulation
{
    /*
   You are given coins of different denominations and a total amount of money amount.Write a function to compute the 
    fewest number of coins that you need to make up that amount.If that amount of money cannot be made up by any 
    combination of the coins, return -1.
   You may assume that you have an infinite number of each kind of coin.
   Example 1:


   Input: coins = [1, 2, 5], amount = 11
   Output: 3
   Explanation: 11 = 5 + 5 + 1
   Example 2:


   Input: coins = [2], amount = 3
   Output: -1 
   */
    public class CoinChange
    {
        public int CoinChangeSmallestCoins(int[] coins, int amount)
        {
            List<int>[] dp = new List<int>[amount + 1];

            dp[0] = new List<int>();

            for (int i = 0; i <= amount; i++)
            {
                if (dp[i] != null)
                {
                    for (int j = 0; j < coins.Length; j++)
                    {
                        int index = i + coins[j];
                        if (index > 0 && index < dp.Length)
                        {
                            if (dp[index] == null || dp[i].Count + 1 < dp[index].Count)
                            {
                                dp[index] = new List<int>(dp[i]);
                                dp[index].Add(coins[j]);
                            }
                        }
                    }
                }
            }
            return dp[amount] != null ? dp[amount].Count : -1;
        }

        public int Change(int amount, int[] coins)
        {
            List<int>[] dp = new List<int>[amount + 1];
            int[] countArr = new int[amount + 1];

            dp[0] = new List<int>();

            for (int i = 0; i <= amount; i++)
            {
                if (dp[i] != null)
                {
                    for (int j = 0; j < coins.Length; j++)
                    {
                        int index = i + coins[j];
                        if (index > 0 && index < dp.Length)
                        {
                            countArr[index]++;
                            if (dp[index] == null || dp[i].Count + 1 < dp[index].Count)
                            {
                                dp[index] = new List<int>(dp[i]);
                                dp[index].Add(coins[j]);
                            }
                        }
                    }
                }
            }
            return countArr[amount];
        }
    }
}
