using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BitManipulation
{
    public class Prime
    {
        public static int CountPrimes(int n)
        {
            bool[] array = new bool[n];
            // Set every bool index to true
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = true;
            }

            int primes = 0;

            // Loop thru to set all multiples of current num to false
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (array[i])
                {
                    for (int j = i + i; j < array.Length; j += i)
                    {
                        array[j] = false;
                    }
                }
            }

            // Ignore 0 and 1, and loop thru to see elements which are still true
            // They are prime numbers, as they are not divisible by any other number
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i])
                {
                    primes++;
                }
            }
            return primes;
        }

        public static int CountPrimes_BF(int n)
        {
            int primes = 0;
            Dictionary<int, bool> map = new Dictionary<int, bool>();
            for (int i = 0; i < n; i++)
            {
                if (IsPrime(i))
                {
                    primes++;
                }
            }
            return primes;
        }

        public static bool IsPrime(int num)
        {
            if (num == 0 || num == 1)
            {
                return false;
            }

            // or can use i <= n/2
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
