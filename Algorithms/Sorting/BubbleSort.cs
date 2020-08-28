using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class BubbleSort
    {
        public static int[] Sort(int[] array)
        {
            // Write your code here.
            bool isSorted = false;
            // Optimization using counter to not check last element
            int counter = 0;
            while (!isSorted)
            {
                isSorted = true;
                // Each iteration, last value highest is placed
                for (int i = 0; i < array.Length - 1 - counter; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                        isSorted = false;
                    }
                }
                counter++;
            }
            return array;
        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
