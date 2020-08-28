using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings.Conversion
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);

            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int currInt = map[s[i]];
                int nextInt = i + 1 != s.Length ? map[s[i + 1]] : 0;


                if (currInt >= nextInt)
                {
                    total += currInt;
                }
                else
                {
                    total += nextInt - currInt;
                    i++;
                }
            }
            return total;
        }
    }
}
