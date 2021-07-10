using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Recursion
{
    public class Exponent
    {
        // 2 ^ 3 = (2 * 2) * 2
        public static int Pow(int m, int n)
        {
            if(n == 0)
            {
                return 1;
            }
            return Pow(m, n - 1) * m;
        }


        public static int PowBetter(int m, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if(n % 2 == 0)
            {
                return PowBetter(m * m, n / 2);
            }
            else
            {
                return m * PowBetter(m * m, (n - 1) / 2);
            }
        }
    }
}
