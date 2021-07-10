using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Stack
{
    public class NextGreatestElement
    {
        public static int[] GetAll(int[] arr)
        {
            int[] result = new int[arr.Length];
            // Stack stores indexes of elements
            Stack<int> stack = new Stack<int>();

            // insert in stack if stack is empty or element is smaller
            // than top of stack.
            int i = 0;
            while (i < arr.Length)
            {
                if (stack.Count == 0)
                {
                    stack.Push(i);
                    i++;
                }
                else
                {
                    if (arr[i] < arr[stack.Peek()])
                    {
                        stack.Push(i);
                        i++;
                    }
                    else // If stack element is greater, then use that
                    {
                        int index = stack.Pop();
                        result[index] = arr[i];
                    }
                }
            }

            // Initialize all elements in array as -1
            for (int j = 0; j <= stack.Count; j++)
            {
                int index = stack.Pop();
                result[index] = -1;
            }
            return result;
        }
    }
}
