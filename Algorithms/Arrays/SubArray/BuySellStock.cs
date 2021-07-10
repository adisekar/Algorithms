using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.SubArray
{
    public class BuySellStock
    {
        // [7,1,5,3,6,4]. O/P = 5. Buy at 1, and sell at 6
        // Buy Sell once for max profit.
        // Keep counter of max profit
        public static int MaxProfit1(int[] prices)
        {
            int min = Int32.MaxValue;
            int max = 0;
            int n = prices.Length;

            for (int i = 0; i < n; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                }
                else
                {
                    max = Math.Max(max, prices[i] - min);
                }
            }
            return max;
        }

        /*
        Input: [7,1,5,3,6,4]
Output: 7
Explanation: Buy on day 2 (price = 1) and sell on day 3 (price = 5), profit = 5-1 = 4.
             Then buy on day 4 (price = 3) and sell on day 5 (price = 6), profit = 6-3 = 3. 
         */
        // Buy sell multiple times
        // Buy sell if price of selling is greater than buy
        // In loop values add up total profit
        public static int MaxProfit2(int[] prices)
        {
            int n = prices.Length;
            int max = 0;
            int current = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (prices[i] < prices[i + 1])
                {
                    current = prices[i + 1] - prices[i];
                    max = max + current;
                }
            }
            return max;
        }
    }
}
