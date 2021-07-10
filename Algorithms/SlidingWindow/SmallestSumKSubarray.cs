using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.SlidingWindow
{
    // Smallest subarray with given sum GREATER THAN OR EQUAL TO SUM
    public class SmallestSumKSubarray
    {
        public static int[] SmallestSubArray_BF(int[] arr, int k)
        {
            List<int> currentSubArray = new List<int>();
            List<List<int>> subArrays = new List<List<int>>();

            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if (sum >= k)
                    {
                        // Loop to add all elements in subArray
                        for (int l = i; l <= j; l++)
                        {
                            currentSubArray.Add(arr[l]);
                        }
                        break;
                    }
                }
                if (currentSubArray.Count > 0)
                {
                    subArrays.Add(currentSubArray);
                    currentSubArray = new List<int>();
                }
            }
            var orderedSubArray = subArrays.OrderBy(s => s.Count).ToList();
            return orderedSubArray[0].ToArray();
        }

        public static int SmallestSumSubArrayLength(int[] arr, int k)
        {
            int minLength = int.MaxValue;
            int currentSum = 0;
            int startIndex = 0;
            int i = 0;
            while (i <= arr.Length && startIndex < arr.Length)
            {
                if (currentSum >= k)
                {
                    minLength = Math.Min(minLength, i - startIndex);
                    currentSum -= arr[startIndex];
                    startIndex++;
                }
                else
                {
                    if (i < arr.Length)
                        currentSum += arr[i];
                    i++;
                }
            }
            return arr.Length > 0 && minLength != int.MaxValue ? minLength : 0;
        }
    }
}
