using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Recursion
{
    public class Print1To100
    {
        public static void Print(int minNum, int maxNum)
        {
            // base case
            if (minNum > maxNum)
            {
                return;
            }

            Console.WriteLine(minNum);
            Print(++minNum, maxNum);
        }
    }
}
