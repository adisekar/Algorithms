using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Recursion
{
    public class Basic
    {
        public static void Fun1(int x)
        {
            if(x > 0)
            {
                Console.WriteLine(x);
                Fun1(x - 1);
            }
        }

        public static void Fun2(int x)
        {
            if (x > 0)
            {
                Fun2(x - 1);
                Console.WriteLine(x);               
            }
        }

        public static int Fun3(int x)
        {
            if (x > 0)
            {
                int count = 0;
                
                for(int i = 0; i< 3; i++)
                {
                    count = Math.Max(Fun3(x - 1), count);
                }
                return count + 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
