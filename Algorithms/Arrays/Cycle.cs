using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public class Cycle
    {
        public static bool HasSingleCycle(int[] array)
        {
            // Write your code here.
            int[] cycle = new int[array.Length];
            int i = 0;
            int index = 0;
            bool hasCycle = true;
            while (i < array.Length)
            {
                // Breaking condition, check if all elements visited
                if (index == 0 && cycle[index] > 0)
                {
                    for (int j = 0; j < cycle.Length; j++)
                    {
                        if (cycle[j] != 1)
                        {
                            hasCycle = false;
                        }
                    }
                    break;
                }
                cycle[index]++;
                int currentVal = array[index];
                if (index + currentVal >= array.Length)
                {
                    index = (index + currentVal) % array.Length;
                }
                else if (index + currentVal < 0)
                {
                    int absIdx = Math.Abs(index + currentVal) % array.Length;
                    index = array.Length - absIdx;
                }
                else
                {
                    index = currentVal + index;
                }
                i++;
            }
            return hasCycle;
        }
    }
}
