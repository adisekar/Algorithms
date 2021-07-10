using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Recursion
{
    public class TowersOfHanoi
    {
        public static void TOH(int n, int A, int B, int C)
        {
            if(n > 0)
            {
                TOH(n - 1, A, C, B);
                Console.WriteLine("From {0} to {1}", A, C);
                TOH(n - 1, B, A, C);
            }
        }
    }
}
