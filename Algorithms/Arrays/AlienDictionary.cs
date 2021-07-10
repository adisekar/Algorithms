using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public class AlienDictionary
    {
        public static bool IsAlienSorted(string[] words, string order)
        {
            int[] map = ConstructOrderArr(order);

            for (int i = 1; i < words.Length; i++)
            {
                if (!CheckOrder(words[i - 1], words[i], map))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool CheckOrder(string a, string b, int[] map)
        {
            int minLength = Math.Min(a.Length, b.Length);
            // For each word and next word, compare the characters if they are ordered
            // 3 cases: 
            // a. if first word char is lesser than second word char, then it is ordered
            // b. if first word char is greater than second word char, then it is NOT ordered
            // c. if it is max length of smallest word, and first word length is greater than second word, then it is NOT ordered
            for (int j = 0; j < minLength; j++)
            {
                if (map[a[j] - 'a'] < map[b[j] - 'a'])
                {
                    return true;
                }
                else if (map[a[j] - 'a'] > map[b[j] - 'a'])
                {
                    return false;
                }
                else if (j == minLength - 1 && a.Length > b.Length)
                {
                    return false;
                }
            }
            return true;
        }

        private static int[] ConstructOrderArr(string order)
        {
            int[] map = new int[26];
            for (int i = 0; i < order.Length; i++)
            {
                int index = order[i] - 'a';
                map[index] = i;
            }
            return map;
        }
    }
}
