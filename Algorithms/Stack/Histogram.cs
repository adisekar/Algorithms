using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Stack
{
    public class Histogram
    {
        // Brute Force - Time limit exceeded
        public static int LargestRectangleArea_BF(int[] heights)
        {
            int area = 0;
            int n = heights.Length;
            for (int i = 0; i < n; i++)
            {
                int l = i;
                int r = i;
                while (l >= 0 && heights[l] >= heights[i]) l--;
                while (r < n && heights[r] >= heights[i]) r++;
                area = Math.Max(area, (r - l - 1) * heights[i]);
            }
            return area;
        }

        // Can be done using 1 stack, and clearing it out after left to right
        public int LargestRectangleArea(int[] heights)
        {
            Stack<int> lStack = new Stack<int>();
            Stack<int> rStack = new Stack<int>();
            int[] lArr = new int[heights.Length];
            int[] rArr = new int[heights.Length];

            // Left to Right
            for (int i = 0; i < heights.Length; i++)
            {
                int curr = heights[i];
                if (lStack.Count > 0)
                {
                    while (lStack.Count > 0 && heights[lStack.Peek()] >= curr)
                    {
                        lStack.Pop();
                    }
                    lArr[i] = lStack.Count == 0 ? 0 : lStack.Peek() + 1;
                    lStack.Push(i);
                }
                else
                {
                    lArr[i] = i;
                    lStack.Push(i);
                }
            }

            // Right to Left
            for (int i = heights.Length - 1; i >= 0; i--)
            {
                int curr = heights[i];
                if (rStack.Count > 0)
                {
                    while (rStack.Count > 0 && heights[rStack.Peek()] >= curr)
                    {
                        rStack.Pop();
                    }
                    rArr[i] = rStack.Count == 0 ? heights.Length - 1 : rStack.Peek() - 1;
                    rStack.Push(i);
                }
                else
                {
                    rArr[i] = i;
                    rStack.Push(i);
                }
            }

            // w = r - l + 1;
            int maxArea = 0;
            for (int i = 0; i < lArr.Length; i++)
            {
                int h = heights[i];
                int w = rArr[i] - lArr[i] + 1;
                int area = h * w;
                maxArea = Math.Max(maxArea, area);
            }
            return maxArea;
        }
    }
}
