using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    public class RotateByKey
    {
        public static string CaesarCypherEncryptor(string str, int key)
        {
            if (key >= 26)
            {
                key = key % 26;
            }
            if (key > 0)
            {
                char[] arr = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                char start = str[0];
                int startAscii = (int)start; // Get ascii of letter
                int i = 0;
                startAscii = startAscii + key;
                int startIdx = (startAscii % 97) % 26; // Mode 26 again, if result of adding key is over 26

                StringBuilder sb = new StringBuilder();
                while (i < str.Length)
                {
                    if (startIdx == 26)
                    {
                        startIdx = 0;
                    }
                    sb.Append(arr[startIdx]);
                    startIdx++;
                    i++;
                }
                return sb.ToString();
            }
            return str; // else block return original string
        }
    }
}
