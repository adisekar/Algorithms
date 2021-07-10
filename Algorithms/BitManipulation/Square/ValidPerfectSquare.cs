using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BitManipulation
{
    public class ValidPerfectSquare
    {
        public bool IsPerfectSquare_BF(int num)
        {
            int i;
            // Loop till i is sq of num, eg 25 = num, i * i < 25, i = 5
            for (i = 1; i * i < num; i++)
            {
            }
            // if it is exactly equal, it is perfect sq
            if (i * i == num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Binary Search to find mid * mid which will be valid sq
        public bool IsPerfectSquare(int num)
        {
            if (num < 2)
            {
                return true;
            }

            long high = num / 2;
            long low = 2;
            while (low <= high)
            {
                long mid = low + (high - low) / 2;
                long square = mid * mid;
                if (square == num)
                {
                    return true;
                }
                else if (square < num)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return false;
        }
    }
}
