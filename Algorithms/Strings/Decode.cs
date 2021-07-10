using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    public class Decode
    {
        // 2 stacks. One for number and other for alphabets.
        // if [ then add cacluated str to string stack
        // if ] then create sb for str stack, and then pop num stack and based on this count, loop and build string for result
        // if digit, loop till we find non digit value, and add this to num stack
        // else, (it is character) add to result str, which += the current char
        public static string DecodeString(string s)
        {
            int i = 0;
            string result = "";
            Stack<int> numStack = new Stack<int>();
            Stack<string> strStack = new Stack<string>();

            while (i < s.Length)
            {
                char c = s[i];               

                if (Char.IsDigit(c))
                {
                    StringBuilder sbNum = new StringBuilder();
                    sbNum.Append(c);
                    int j = i + 1;
                    while (j < s.Length)
                    {
                        if (Char.IsDigit(s[j]))
                        {
                            sbNum.Append(s[j]);
                        }
                        else
                        {
                            break;
                        }
                        j++;
                        i++;
                    }
                    numStack.Push(Convert.ToInt32(sbNum.ToString()));
                }
                else if (c == '[')
                {
                    // Add curr alphabets to stack and clear it
                    strStack.Push(result);
                    result = "";
                }
                else if (c == ']')
                {
                    StringBuilder sbStr = new StringBuilder(strStack.Pop());
                    int numCnt = numStack.Pop();

                    for (int k = 0; k < numCnt; k++)
                    {
                        sbStr.Append(result);
                    }
                    result = sbStr.ToString();
                }
                else
                {
                    result += c.ToString();
                }
                i++;
            }
            return result;
        }
    }
}
