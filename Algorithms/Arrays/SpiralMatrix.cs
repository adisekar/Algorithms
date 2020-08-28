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

            if (matrix.Length == 0)
                return result;

            int sr = 0;
            int er = matrix.Length - 1;
            int sc = 0;
            int ec = matrix[0].Length - 1;

            while (sr <= er && sc <= ec)
            {
                // Col Incr
                for (int j = sc; j <= ec; j++)
                {
                    result.Add(matrix[sr][j]);
                }

                // Row Incr
                for (int i = sr + 1; i <= er; i++)
                {
                    result.Add(matrix[i][ec]);
                }
                if (sr < er && sc < ec)
                {
                    // Col Decr
                    for (int j = ec - 1; j > sc; j--)
                    {
                        result.Add(matrix[er][j]);
                    }

                    // Row Decr
                    for (int i = er; i > sr; i--)
                    {
                        result.Add(matrix[i][sc]);
                    }
                }

                sr++;
                er--;
                sc++;
                ec--;
            }
            return result;
        }
    }
}
