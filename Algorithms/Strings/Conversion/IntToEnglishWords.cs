using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings.Conversion
{
    public class IntToEnglishWords
    {
        static string[] underTwenty = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        static string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        static string[] chunks = { "", "Thousand", "Million", "Billion" };
        public static string NumberToWords(int num)
        {
            if (num == 0) return "Zero";

            int i = 0;
            string words = "";

            while (num > 0)
            {
                if (num % 1000 != 0)
                {
                    words = Helper(num % 1000) + chunks[i] + " " + words;
                }
                num = num / 1000;
                i++;
            }
            return words.Trim();
        }
        private static string Helper(int num)
        {
            if (num == 0)
                return "";
            else if (num < 20)
                return underTwenty[num] + " ";
            else if (num < 100)
                return tens[num / 10] + " " + Helper(num % 10);
            else
                return underTwenty[num / 100] + " Hundred " + Helper(num % 100);
        }
    }
}
