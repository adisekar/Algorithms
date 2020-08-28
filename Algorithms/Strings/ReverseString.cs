using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    public class ReverseString
    {
        public static string ReverseStr(string s, int k)
        {
            if (k > 0 && k < s.Length)
            {
                char[] chars = s.ToCharArray();
                int i = 0;
                int j = k - 1;
                while (i < j)
                {
                    char temp = chars[i];
                    chars[i] = chars[j];
                    chars[j] = temp;
                    i++;
                    j--;
                }
                return new string(chars);
            }
            return s;
        }
    }
}
