using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings.Conversion
{
    public class IntToRomanConversion
    {
        public static string IntToRoman(int num)
        {
            int[] numbers = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] numerals = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            if (num >= 3999 && num <= 1)
            {
                return "";
            }
            int i = 0;
            StringBuilder sb = new StringBuilder();
            while (num > 0)
            {
                if (num - numbers[i] >= 0)
                {
                    sb.Append(numerals[i]);
                    num = num - numbers[i];
                }
                else
                {
                    i++;
                }
            }
            return sb.ToString();
        }
    }
}
