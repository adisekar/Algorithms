using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.Matrix
{
    public class RotateImage
    {
        // O(n*2) solution
        public static void RotateByTranspose(int[][] matrix)
        {
            int n = matrix.Length;
            // Transpose. Rows become cols, and cols become rows
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int temp = matrix[j][i];
                    matrix[j][i] = matrix[i][j];
                    matrix[i][j] = temp;
                }
            }

            // Reverse each now
            for (int i = 0; i < n; i++)
            {
                for (int j = 0, k = n - 1; j < n / 2; j++, k--)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][k];
                    matrix[i][k] = temp;
                }
            }
        }

        public static void Rotate(int[][] matrix)
        {
            int n = matrix.Length;
            // Rotate 4 corners of rectangle
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                for (int j = 0, k = n - 1; j < n / 2; j++, k--)
                {
                    int temp = matrix[k - j][i];
                    matrix[k - j][i] = matrix[k - i][k - j];
                    matrix[k - i][k - j] = matrix[j][k - i];
                    matrix[j][k - i] = matrix[i][j];
                    matrix[i][j] = temp;
                }
            }
        }
    }
}
