using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.SlidingWindow
{
    public class PermutationsInString
    {
        public static bool CheckInclusion_SlidingWindow(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return false;

            int[] s1Hash = new int[26];
            int[] s2Hash = new int[26];
            // Populate array hash with s1 
            for (int i = 0; i < s1.Length; i++)
            {
                int s1position = s1[i] - 'a';
                int s2position = s2[i] - 'a';
                s1Hash[s1position]++;
                s2Hash[s2position]++;
            }

            for (int i = 0; i < s2.Length - s1.Length; i++)
            {
                if (CheckMatch(s1Hash, s2Hash))
                {
                    return true;
                }
                int endIdx = s2[i + s1.Length] - 'a';
                int startIdx = s2[i] - 'a';
                s2Hash[endIdx]++;
                s2Hash[startIdx]--;
            }
            // Check again as loop terminates, and if changed value is now a match
            return CheckMatch(s1Hash, s2Hash);
        }

        public static bool CheckMatch(int[] s1Hash, int[] s2Hash)
        {
            for (int i = 0; i < 26; i++)
            {
                if (s1Hash[i] != s2Hash[i])
                {
                    return false;
                }
            }
            return true;
        }


        // Below code is first approach
        public static bool CheckInclusion(string s1, string s2)
        {
            int needleHash = s1.GetHash();

            for (int i = 0; i <= s2.Length - s1.Length; i++)
            {
                StringBuilder subStr = new StringBuilder();
                for (int j = i; j < s1.Length + i; j++)
                {
                    subStr.Append(s2[j]);
                }
                int subHash = subStr.ToString().GetHash();
                if (subHash == needleHash)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public static class ExtensionMethods
    {
        public static int GetHash(this string s)
        {
            int[] array = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                int position = s[i] - 'a';
                int asciiVal = (int)s[i];
                array[position] += asciiVal * position;
            }

            int hashCode = 0;
            for (int i = 0; i < array.Length; i++)
            {
                hashCode += array[i];
            }
            return hashCode;
        }
    }
}
