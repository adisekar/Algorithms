using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.Peak
{
    public class LargestMountainArray
    {
        public static int LongestMountain(int[] A)
        {
            if (A == null || A.Length == 0) return 0;
            int max = 0;
            for (int i = 1; i < A.Length - 1; i++)
            {
                int count = 1;
                if (A[i] > A[i - 1] && A[i] > A[i + 1])
                {
                    for (int j = i; j >= 1; j--)
                    {
                        if (A[j] > A[j - 1])
                        {
                            count++;
                        }
                        else
                            break;
                    }

                    for (int j = i; j < A.Length - 1; j++)
                    {
                        if (A[j] > A[j + 1])
                        {
                            count++;
                        }
                        else
                            break;
                    }
                    max = Math.Max(count, max);
                }
            }
            return max;
        }

        // Brute Force to find all peaks, and expand on both sides
        // to find the longest mountain
        public static int LongestMountainBF(int[] A)
        {
            var peaksIndex = FindPeaks(A);
            int count = 0;
            foreach (var peakIndex in peaksIndex)
            {
                int left = peakIndex - 1;
                int right = peakIndex + 1;

                while (left >= 0 && right < A.Length)
                {
                    if (A[left] < A[left + 1])
                    {
                        count++;
                    }
                    if (A[right - 1] > A[right])
                    {
                        count++;
                    }
                    left--;
                    right++;
                }
            }
            // Add one for current peak element, as we are going left and right
            return count != 0 ? count + 1 : 0;
        }

        private static List<int> FindPeaks(int[] A)
        {
            List<int> peaksIndex = new List<int>();
            for (int i = 1; i < A.Length - 1; i++)
            {
                if (A[i] > A[i - 1] && A[i] > A[i + 1])
                {
                    peaksIndex.Add(i);
                }
            }
            return peaksIndex;
        }
    }
}
