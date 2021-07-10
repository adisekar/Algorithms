using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Recursion
{
    public class PermutationsInString
    {

        public static void Driver(string str)
        {
            Permute(str.ToCharArray(), 0, str.Length - 1);
        }

        public static void Swap(char[] str, int left, int right)
        {
            char temp = str[left];
            str[left] = str[right];
            str[right] = temp;
        }

        public static void Permute(char[] str, int left, int right)
        {
            if (left == right)
            {
                Console.WriteLine(new string(str));
            }
            else
            {
                for (int i = left; i <= right; i++)
                {
                    Swap(str, left, i);
                    Permute(str, left + 1, right);
                    Swap(str, left, i); // Backtrack
                }
            }
        }
    }
}
