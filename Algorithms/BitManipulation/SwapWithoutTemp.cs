using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BitManipulation
{
    public class SwapWithoutTemp
    {
        public static Tuple<int, int> SwapUsingAddition(int i, int j)
        {
            i = i + j;
            j = i - j;
            i = i - j;
            return new Tuple<int, int>(i, j);
        }

        public static Tuple<int, int> SwapUsingXOR(int i, int j)
        {
            i = i ^ j;
            j = i ^ j;
            i = i ^ j;
            return new Tuple<int, int>(i, j);
        }
    }
}
