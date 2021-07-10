using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Greedy
{
    /*
A string s is called good if there are no two different characters in s that have the same frequency.

Given a string s, return the minimum number of characters you need to delete to make s good.

The frequency of a character in a string is the number of times it appears in the string. For example, in the string "aab", the frequency of 'a' is 2, while the frequency of 'b' is 1.

 

Example 1:

Input: s = "aab"
Output: 0
Explanation: s is already good.
Example 2:

Input: s = "aaabbbcc"
Output: 2
Explanation: You can delete two 'b's resulting in the good string "aaabcc".
Another way it to delete one 'b' and one 'c' resulting in the good string "aaabbc".
     */
    public class MinDeletionForUniqueCharFrequencies
    {
        public int MinDeletions(string s)
        {
            int[] map = new int[26];
            int res = 0;

            foreach (var c in s)
            {
                int index = c - 'a';
                map[index]++;
            }

            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < map.Length; i++)
            {
                int freq = map[i];
                while (freq > 0)
                {
                    if (!set.Contains(freq))
                    {
                        set.Add(freq);
                        break;
                    }
                    freq--;
                    res++;
                }
            }
            return res;
        }
    }
}
