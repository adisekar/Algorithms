using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BitManipulation
{
    public class ReverseInteger
    {
        public static int Reverse(int x)
        {
            if (x > Int32.MaxValue || x < Int32.MinValue)
            {
                return 0;
            }
            bool negative = false;
            if (x < 0)
            {
                negative = true;
                x = x * -1;
            }

            long reversedNum = 0;

            while (x > 0)
            {
                int rem = x % 10;
                reversedNum = (reversedNum * 10) + rem;
                x = x / 10;
            }
            if (reversedNum > Int32.MaxValue || reversedNum < Int32.MinValue)
            {
                return 0;
            }
            int reversedNumInteger = Convert.ToInt32(reversedNum);
            return negative ? reversedNumInteger * -1 : reversedNumInteger;
        }
    }
}
