using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming.Memoization
{
    public class TribonacciNumber
    {
        static Dictionary<int, int> map = new Dictionary<int, int>() { { 0, 0 }, { 1, 1 }, { 2, 1 } };
        public static int Tribonacci(int n)
        {
            if (map.ContainsKey(n))
            {
                return map[n];
            }
            else
            {
                map.Add(n, Tribonacci(n - 1) + Tribonacci(n - 2) + Tribonacci(n - 3));
                return map[n];
            }
        }
    }
}
