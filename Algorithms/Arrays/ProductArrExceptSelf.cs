using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public class ProductArrExceptSelf
    {
        // O(n*2)
        public static int[] ProductExceptSelf_BF(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int product = 1;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        product = product * nums[j];
                    }
                }
                result[i] = product;
            }
            return result;
        }
        public static int[] ProductExceptSelf_Naive(int[] nums)
        {
            // Brute force is for each element, loop throught ever other element in another loop
            // except that number, and multiply the result. O(n^2)

            // O(n) Loop thru to calculate total product, then loop again and divide by the current num
            // Does not work if input array, contains 0
            int product = 1;
            foreach (var num in nums)
            {
                product = num != 0 ? num * product : 1 * product;
            }

            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    result[i] = product / nums[i];
                }
                else
                {
                    result[i] = 0;
                }
            }
            return result;
        }

        public static int[] ProductExceptSelfWithSpace(int[] nums)
        {
            int[] result = new int[nums.Length];
            int[] left = new int[nums.Length];
            int[] right = new int[nums.Length];
            int product = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                left[i] = product * nums[i];
            }

            product = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                right[i] = product * nums[i];
            }

            for (int i = 1; i < nums.Length - 1; i++)
            {
                result[i] = left[i - 1] * right[i + 1];
            }
            result[0] = right[1];
            result[nums.Length - 1] = left[nums.Length - 2];
            return result;
        }

        // Best Solution. O(n) time and O(1) space
        public static int[] ProductExceptSelfInPlace(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            int product = 1; // right value of result

            // Store left calculated values in result
            result[0] = nums[0];
            for (int i = 1; i < n; i++)
            {
                result[i] = result[i - 1] * nums[i];
            }

            // Boundary conditions first and last element
            result[n - 1] = result[n - 2];
            product = product * nums[n - 1];
            for (int i = n - 2; i > 0; i--)
            {
                result[i] = result[i - 1] * product;
                product *= nums[i];
            }
            result[0] = product;

            return result;
        }
    }
}
