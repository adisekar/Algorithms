using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Arrays.Triangle
{
    public class PascalsTriangle1
    {
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> result = new List<IList<int>>();
            List<int> firstRow = new List<int>() { 1 };
            result.Add(firstRow);

            for (int i = 1; i < numRows; i++)
            {
                var prevRow = result.Last();
                int[] curRow = new int[prevRow.Count + 1];
                curRow[0] = 1;

                // Add prev row values j -1 and j to find curRow value
                for (int j = 1; j < curRow.Length - 1; j++)
                {
                    curRow[j] = prevRow[j - 1] + prevRow[j];
                }

                curRow[curRow.Length - 1] = 1;
                result.Add(curRow.ToList());
            }
            return result;
        }
    }
}
