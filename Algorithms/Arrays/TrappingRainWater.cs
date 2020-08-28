using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public class TrappingRainWater
    {
        // O(n) soln but with space O(n)
        public static int Trap_WithSpace(int[] height)
        {
            int[] iArr = new int[height.Length];
            int[] jArr = new int[height.Length];
            //int[] minArr = new int[height.Length];
            int iMax = 0;
            int jMax = 0;

            int i = 0;
            int j = height.Length - 1;
            // Calculate left and right max Height at each point
            while (i < height.Length && j >= 0)
            {
                iMax = Math.Max(iMax, height[i]);
                jMax = Math.Max(jMax, height[j]);
                iArr[i] = iMax;
                jArr[j] = jMax;
                i++;
                j--;
            }

            int result = 0;
            // Min of iArr and jArr
            // Then subtract building height
            for (int k = 0; k < height.Length; k++)
            {
                result += Math.Min(iArr[k], jArr[k]) - height[k];
            }

            // Space for MinArr can be removed

            //// Min of iArr and jArr
            //for (int k = 0; k < height.Length; k++)
            //{
            //    minArr[k] = Math.Min(iArr[k], jArr[k]);
            //}

            //// Subtract the building height
            //for (int k = 0; k < height.Length; k++)
            //{
            //    minArr[k] = minArr[k] - height[k];
            //}

            //// Sum up all minHeight - building Height to get result
            //for (int k = 0; k < height.Length; k++)
            //{
            //    result += minArr[k];
            //}
            return result;
        }
    }
}
