using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public class SpiralMatrix
    {
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> result = new List<int>();
            if (matrix == null || matrix.Length == 0)
            {
                return result;
            }

            int top = 0;
            int down = matrix.Length - 1;
            int left = 0;
            int right = matrix[0].Length - 1;

            int matrixSize = matrix.Length * matrix[0].Length;

            // while(top <= down && left <= right){
            while (result.Count < matrixSize)
            {
                for (int i = left; i <= right && result.Count < matrixSize; i++)
                {
                    result.Add(matrix[top][i]);
                }
                top++;

                for (int i = top; i <= down && result.Count < matrixSize; i++)
                {
                    result.Add(matrix[i][right]);
                }
                right--;

                for (int i = right; i >= left && result.Count < matrixSize; i--)
                {
                    result.Add(matrix[down][i]);
                }
                down--;

                for (int i = down; i >= top && result.Count < matrixSize; i--)
                {
                    result.Add(matrix[i][left]);
                }
                left++;
            }
            return result;
        }
    }
}
