using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search.Grid
{
    public class SearchMatrix
    {
        public bool Search(int[][] matrix, int target)
        {
            int i = 0;
            int j = matrix[0].Length - 1;
            bool result = false;

            // start row from 0 and col from last column
            while (i < matrix.Length && j >= 0)
            {
                if (target == matrix[i][j])
                {
                    result = true;
                    break;
                }
                else
                {
                    if (matrix[i][j] > target) { j--; }
                    else { i++; }
                }
            }
            return result;
        }
    }
}
