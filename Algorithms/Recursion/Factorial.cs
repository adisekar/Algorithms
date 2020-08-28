using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Recursion
{
    public class Factorial
    {
        private Dictionary<int, int> dictionary { get; set; }
        public Factorial()
        {
            // Base case
            dictionary = new Dictionary<int, int>();
            dictionary.Add(0, 1);
            dictionary.Add(1, 1);
        }
        public static int FindFactorial(int n)
        {
            if (n < 2)
            {
                return 1;
            }
            return n * FindFactorial(n - 1);
        }

        // Memoization using dictionary
        public int RecursiveMemoizationDictionary(int n)
        {
            if (dictionary.ContainsKey(n))
            {
                return dictionary[n];
            }
            else
            {
                int result = n * RecursiveMemoizationDictionary(n - 1);
                dictionary.Add(n, result);
                return result;
            }
        }

        public static int FindFactorialIterative(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            int factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        // Memoization using array instead of dictionary
        public int RecursiveMemoizationArray(int n)
        {
            int[] result = new int[n == 0 ? 1 : n];

            return DoFactorial(n, result, 0);
        }

        private int DoFactorial(int n, int[] resultArr, int level)
        {
            if (n > 1)
            {
                int result = n * DoFactorial(n - 1, resultArr, level + 1);
                resultArr[level] = result;
                return resultArr[level];
            }
            else
            {
                resultArr[level] = 1;
                return 1;
            }
        }
    }
}
