using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public class PrisonCellAfterNDays
    {
        public static int[] PrisonAfterNDays(int[] cells, int N)
        {
            int[] temp = new int[cells.Length];
            for (int i = 0; i < N; i++)
            {
                for (int j = 1; j < cells.Length - 1; j++)
                {
                    if (cells[j - 1] == cells[j + 1])
                    {
                        temp[j] = 1;
                    }
                    else
                    {
                        temp[j] = 0;
                    }
                }
                // Base case as first and last cells have no neighbors, so 0
                temp[0] = 0;
                temp[cells.Length - 1] = 0;

                Array.Copy(temp, cells, cells.Length);
            }
            return cells;
        }
    }
}
