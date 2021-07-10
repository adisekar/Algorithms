using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    public class Compression
    {
        public static int Compress(char[] chars)
        {
            if (chars.Length == 1)
            {
                return 1;
            }

            int i = 0;
            int index = 0;

            while (i < chars.Length)
            {
                int j = i;
                while (j < chars.Length && chars[j] == chars[i])
                {
                    j++;
                }
                // Add the character (alphabet)
                chars[index++] = chars[i];

                int count = j - i;
                if (count > 1)
                {
                    foreach (var c in count.ToString())
                    {
                        // Add the length or count of character
                        chars[index++] = c;
                    }
                }
                // Update i to j position
                i = j;
            }
            return index;
        }
    }
}
