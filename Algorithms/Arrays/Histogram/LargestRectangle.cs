using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.Histogram
{
    /*
     Input: heights = [2,1,5,6,2,3]
Output: 10
Explanation: The above is a histogram where width of each bar is 1.
The largest rectangle is shown in the red area, which has an area = 10 units.
     */
    public class LargestRectangle
    {
        public int LargestRectangleArea_BF(int[] heights)
        {
            int maxArea = heights[0];

            for (int i = 0; i < heights.Length; i++)
            {
                int minH = heights[i];
                for (int j = i; j < heights.Length; j++)
                {
                    minH = Math.Min(minH, heights[j]);
                    // as index is 0 based, j - i + 1. // 3 -2 = 2
                    maxArea = Math.Max(maxArea, minH * (j - i + 1));
                }
            }
            return maxArea;
        }
    }
}
