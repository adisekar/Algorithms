using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.Intervals
{
    public class IntervalListIntersection
    {
        public static int[][] IntervalIntersection(int[][] A, int[][] B)
        {
            int aPtr = 0;
            int bPtr = 0;
            List<int[]> result = new List<int[]>();

            while (aPtr < A.Length && bPtr < B.Length)
            {
                int s1 = A[aPtr][0];
                int e1 = A[aPtr][1];
                int s2 = B[bPtr][0];
                int e2 = B[bPtr][1];

                // Only if this matches, matching intervals available
                if (s1 <= e2 && e1 >= s2)
                {
                    int[] newArr = new int[2];
                    newArr[0] = Math.Max(s1, s2);
                    newArr[1] = Math.Min(e1, e2);
                    result.Add(newArr);
                }

                // Move pointers
                if (e2 > e1)
                {
                    aPtr++;
                }
                else
                {
                    bPtr++;
                }
            }
            return result.ToArray();
        }
    }
}
