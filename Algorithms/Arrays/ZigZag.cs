using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public class ZigZag
    {
        // [3,4,6,2,1,8,9]
        public static int[] Convert(int[] array)
        {
            bool flag = false;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (flag)
                {
                    if (array[i] < array[i + 1])
                    {
                        Swap(array, i, i + 1);                      
                    }
                    flag = !flag;
                }
                else
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                    flag = !flag;
                }
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
