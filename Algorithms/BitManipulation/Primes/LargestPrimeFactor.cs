using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BitManipulation.Primes
{
    public class LargestPrimeFactor
    {
        // GetLargestPrime(21) = 7 * 3.
        // 7 is largets prime factor
        public static int GetLargestPrime(int number)
        {
            if (number < 0)
            {
                return -1;
            }

            int largestPrime = -1;
            for (int i = 2; i <= number; i++)
            {
                while (number % i == 0)
                {
                    largestPrime = i;
                    number = number / i;
                }
            }
            return largestPrime;
        }
    }
}