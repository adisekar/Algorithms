using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Recursion
{
    public class SumOfNaturalNumbers
    {
        public int SumRecursive(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            else
            {
               return SumRecursive(n - 1) + n;
            }
        }
        // Can use formula n* (n + 1)/2. Constant time O(1)
        public int Sum(int n)
        {
            return (n * (n + 1)) / 2;
        }

        public int SumIterative(int n)
        {
            int s = 0;
            for(int i =1; i<= n; i++)
            {
                s += i;
            }
            return s;
        }
    }
}
