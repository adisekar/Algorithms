using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BitManipulation.Square
{
    public class SquareRoot
    {
        public int MySqrt(int x)
        {
            long i;
            for (i = 1; i * i < x; i++) { }
            if (i * i == x)
            {
                return (int)i;
            }
            else
            {
                return (int)(i - 1);
            }
        }
    }
}
