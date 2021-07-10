using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    // A = 1. Z= 26
    /*Input: "12"
Output: 2
Explanation: It could be decoded as "AB" (1 2) or "L" (12).

    Input: "226"
Output: 3
Explanation: It could be decoded as "BZ" (2 26), "VF" (22 6), or "BBF" (2 2 6).
    */

    public class DecodeWays
    {
        public int NumDecodings(string s)
        {
            int[] dp = new int[s.Length + 1];

            // Base case
            dp[0] = 1;
            dp[1] = s[0] == '0' ? 0 : 1; // Since no mapping for 0

            for (int i = 2; i <= s.Length; i++)
            {
                int firstDigit = Convert.ToInt32(s.Substring(i - 1, 1));
                int secondDigit = Convert.ToInt32(s.Substring(i - 2, 2));

                if (firstDigit >= 1)
                {
                    dp[i] += dp[i - 1];
                }

                if (secondDigit >= 10 && secondDigit <= 26)
                {
                    dp[i] += dp[i - 2];
                }
            }
            return dp[s.Length];
        }
    }
}
