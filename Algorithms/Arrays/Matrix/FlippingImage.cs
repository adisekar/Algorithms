using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.Matrix
{
    public class FlippingImage
    {
        public static int[][] FlipAndInvertImage(int[][] A)
        {
            int n = A.Length;

            for (int i = 0; i < n; i++)
            {
                // Reverse the matrix
                for (int j = 0, k = n - 1; j < n / 2; j++, k--)
                {
                    int temp = A[i][j];
                    A[i][j] = A[i][k];
                    A[i][k] = temp;
                }

                // Invert the bits
                for (int j = 0; j < n; j++)
                {
                    if (A[i][j] == 0)
                    {
                        A[i][j] = 1;
                    }
                    else
                    {
                        A[i][j] = 0;
                    }
                }
            }
            return A;
        }
    }
}
