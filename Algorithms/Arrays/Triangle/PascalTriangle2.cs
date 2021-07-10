using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Arrays.Triangle
{
    public class PascalTriangle2
    {
        public IList<int> GetRow(int rowIndex)
        {
            var triangle = CreateTriangle(rowIndex);

            return triangle[rowIndex].ToList();
        }

        public int[][] CreateTriangle(int rowIndex)
        {
            int[][] result = new int[rowIndex + 1][];
            int[] firstRow = new int[] { 1 };
            result[0] = firstRow;


            for (int i = 1; i <= rowIndex; i++)
            {
                var prevRow = result[i - 1];
                int[] curRow = new int[prevRow.Length + 1];
                curRow[0] = 1;

                // Add prev row values j -1 and j to find curRow value
                for (int j = 1; j < curRow.Length - 1; j++)
                {
                    curRow[j] = prevRow[j - 1] + prevRow[j];
                }

                curRow[curRow.Length - 1] = 1;
                result[i] = curRow;
            }
            return result;
        }
    }
}
