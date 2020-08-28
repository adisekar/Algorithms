using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public class AlienDictionary
    {
        public static bool IsAlienSorted(string[] words, string order)
        {
            int[] orderArr = ConstructOrderArr(order);

            bool isInOrder = true;
            for (int i = 1; i < words.Length; i++)
            {
                if (!IsOrdered(words[i - 1], words[i], orderArr))
                {
                    isInOrder = false;
                    break;
                }
            }
            return isInOrder;
        }

        private static bool IsOrdered(string a, string b, int[] orderArr)
        {
            for (int i = 0; i < a.Length && i < b.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return orderArr[a[i] - (int)'a'] < orderArr[b[i] - (int)'a'] ? true : false;
                }
            }
            if (a.Length > b.Length)
            {
                return false;
            }
            return true;
        }

        private static int[] ConstructOrderArr(string order)
        {
            int[] orderArr = new int[26];

            for (int i = 0; i < order.Length; i++)
            {
                char c = order[i];
                int position = (int)c - (int)'a';
                orderArr[position] = i;
            }

            return orderArr;
        }
    }
}
