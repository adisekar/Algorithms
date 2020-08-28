using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public class MoveToEnd
    {
        public static int[] MoveElement(int[] array, int num)
        {
            int i = 0;
            int j = array.Length - 1;

            while(i < j)
            {
                if(array[j] == num)
                {
                    j--;
                }
                if(array[i] == num)
                {
                    Swap(i, j, array);
                }
                else
                {
                    i++;
                }
            }
            return array;
        }

        private static void Swap(int i, int j, int[] array)
        {
            // Array passed by ref
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
