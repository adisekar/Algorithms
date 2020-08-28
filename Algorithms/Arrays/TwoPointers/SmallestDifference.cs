using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.TwoPointers
{
    public class SmallestDifferenceTwoArrays
    {
        public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            // Write your code here.
            // Inplace default array Sort
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            int smallest = Int32.MaxValue;
            int currentSmallest = Int32.MaxValue;
            int i = 0;
            int j = 0;
            int firstElement = arrayOne[0];
            int secondElement = arrayTwo[0];

            while (i < arrayOne.Length && j < arrayTwo.Length)
            {
                currentSmallest = Math.Abs(arrayOne[i] - arrayTwo[j]);
                smallest = Math.Min(smallest, currentSmallest);
                if (arrayOne[i] == arrayTwo[j])
                {
                    firstElement = arrayOne[i];
                    secondElement = arrayTwo[j];
                    break;
                }
                else if (arrayOne[i] < arrayTwo[j])
                {
                    if (currentSmallest == smallest)
                    {
                        firstElement = arrayOne[i];
                        secondElement = arrayTwo[j];
                    }
                    i++;
                }
                else
                { // arrayOne[i] > arrayTwo[j]
                    if (currentSmallest == smallest)
                    {
                        firstElement = arrayOne[i];
                        secondElement = arrayTwo[j];
                    }
                    j++;
                }
            }
            return new int[] { firstElement, secondElement };
        }
    }
}
