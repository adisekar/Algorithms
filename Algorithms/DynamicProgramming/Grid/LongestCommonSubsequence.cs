using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming.Grid
{
    public class LongestCommonSubsequence
    {
        public static int GetLength(string text1, string text2)
        {
            int[,] dp = new int[text1.Length + 1, text2.Length + 1];

            for (int i = 1; i < dp.GetLength(0); i++)
            {
                for (int j = 1; j < dp.GetLength(1); j++)
                {
                    // If characters match, get from diagnol element value and add 1
                    if (text1[i - 1] == text2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    // If characters do not match, get MAX from left and top element value 
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }
            return dp[text1.Length, text2.Length];
        }
    }
}
