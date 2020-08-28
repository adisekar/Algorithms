using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BitManipulation
{
    public class StringToInteger
    {
        public static int MyAtoi(string str)
        {
            str = str.Trim();
            bool negative = false;

            if (str.Length == 0)
            {
                return 0;
            }

            var newStr = str;
            // Remove start sign
            if (str[0] == '-')
            {
                negative = true;
                newStr = str.Substring(1, str.Length - 1);
            }
            if (str[0] == '+')
            {
                newStr = str.Substring(1, str.Length - 1);
            }

            if (newStr.Length == 0)
            {
                return 0;
            }

            if (!Char.IsDigit(newStr[0]))
            {
                return 0;
            }

            double result = 0;
            foreach (var c in newStr)
            {
                int currentNum = c - '0';
                // Check if valid number
                if (currentNum >= 0 && currentNum <= 9)
                {
                    result = (result * 10) + currentNum;
                }
                else
                {
                    break;
                }
            }
            result = negative ? -1 * result : result;
            if (result < Int32.MinValue)
            {
                return Int32.MinValue;
            }
            if (result > Int32.MaxValue)
            {
                return Int32.MaxValue;
            }
            int intResult = (int)result;
            return intResult;
        }
    }
}
