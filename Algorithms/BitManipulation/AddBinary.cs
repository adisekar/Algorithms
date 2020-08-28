using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BitManipulation
{
    public class AddBinary
    {
        public static string AddBinaryStrings(string a, string b)
        {
            int carry = 0;
            StringBuilder sb = new StringBuilder();
            int maxLen = Math.Max(a.Length, b.Length);

            // Padding with leading zeroes
            StringBuilder padSB = new StringBuilder();
            if (a.Length < maxLen)
            {
                for (int i = 0; i < maxLen; i++)
                {
                    if (i >= maxLen - a.Length)
                    {
                        padSB.Append(a);
                        a = padSB.ToString();
                        break;
                    }
                    padSB.Insert(0, 0);
                }
            }
            if (b.Length < maxLen)
            {
                for (int i = 0; i < maxLen; i++)
                {

                    if (i >= maxLen - b.Length)
                    {
                        padSB.Append(b);
                        b = padSB.ToString();
                        break;
                    }
                    padSB.Insert(0, 0);
                }
            }


            for (int i = maxLen - 1; i >= 0; i--)
            {
                char firstNum = a[i];
                char secondNum = b[i];

                if ((firstNum == '0' && secondNum == '1') || (firstNum == '1' && secondNum == '0'))
                {
                    if (carry == 0)
                    {
                        sb.Insert(0, '1');
                    }
                    else
                    {
                        sb.Insert(0, '0');
                    }
                }
                else if (firstNum == '0' && secondNum == '0')
                {
                    if (carry == 0)
                    {
                        sb.Insert(0, '0');
                    }
                    else
                    {
                        sb.Insert(0, '1');
                        carry--;
                    }
                }
                else if (firstNum == '1' && secondNum == '1')
                {
                    if (carry == 0)
                    {
                        sb.Insert(0, '0');
                        carry++;
                    }
                    else
                    {
                        sb.Insert(0, '1');
                    }
                }
            }
            if (carry > 0)
            {
                sb.Insert(0, '1');
            }
            return sb.ToString();
        }
    }
}
