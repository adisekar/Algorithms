using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class ContainerMostWater
    {
        // Container with most water

        // For all pairs, calculate max area, and find greatest
        public static int MaxAreaBF(int[] height)
        {
            int maxArea = 0;
            for (int i = 0; i < height.Length - 1; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    int minHeight = Math.Min(height[i], height[j]);
                    int width = j - i;

                    var currentMaxArea = minHeight * width;
                    maxArea = Math.Max(currentMaxArea, maxArea);
                    //if (currentMaxArea > maxArea)
                    //{
                    //    maxArea = currentMaxArea;
                    //}
                }
            }
            return maxArea;
        }

        // O(n) solution. One pass
        public static int MaxArea(int[] height)
        {
            int maxArea = 0;
            int i = 0;
            int j = height.Length - 1;

            while (i < j)
            {
                int minHeight = Math.Min(height[i], height[j]);
                int width = j - i;

                var currentMaxArea = minHeight * width;
                maxArea = Math.Max(maxArea, currentMaxArea);
                //if (currentMaxArea > maxArea)
                //{
                //    maxArea = currentMaxArea;
                //}

                // Move left pointer, if height is lower
                // Move right pointer, if height is greater
                // To find max value on both, and calculate area for each case
                if (height[i] < height[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }
            return maxArea;
        }
    }
}
