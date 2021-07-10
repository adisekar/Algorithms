using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming.Memoization
{
    class FibonacciNumber
    {
        static Dictionary<int, int> map = new Dictionary<int, int>() { { 0, 0 }, { 1, 1 } };

        public int Fib(int n)
        {
            if (map.ContainsKey(n))
            {
                return map[n];
            }
            else
            {
                map[n] = Fib(n - 1) + Fib(n - 2);
                return map[n];
            }
        }
    }
}
