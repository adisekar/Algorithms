using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    public class StrStr
    {
        public static int FindStrStr(string haystack, string needle)
        {
            if (needle.Length == 0)
            {
                return 0;
            }

            if (haystack.Length == 0 || needle.Length > haystack.Length)
            {
                return -1;
            }

            for (int i = 0; i < haystack.Length; i++)
            {
                int k = i;
                for (int j = 0; j < needle.Length && k < haystack.Length; j++)
                {
                    if (haystack[k] == needle[j])
                    {
                        if (j == needle.Length - 1)
                        {
                            return i;
                        }
                        k++;
                    }
                    else { break; }
                }
            }
            return -1;
        }

        public static int FindStrStrBetter(string haystack, string needle)
        {
            if (needle.Length == 0)
            {
                return 0;
            }

            if (haystack.Length == 0 || needle.Length > haystack.Length)
            {
                return -1;
            }

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0])
                    for (int j = 0; j < needle.Length; j++)
                    {
                        if (i + j < haystack.Length && haystack[i + j] == needle[j] && j == needle.Length - 1)
                        {
                            return i;
                        }
                    }
            }
            return -1;
        }
    }
}
