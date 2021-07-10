using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    public class OneEdit
    {
        // Given 2 strings are equal length
        // leet -> lest = true
        public static bool IsOneEditAway(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            int count = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    if (count == 0)
                    {
                        count++;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
