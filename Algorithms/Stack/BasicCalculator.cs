using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Stack
{
    public class BasicCalculator
    {
        public int Calculate(string s)
        {
            int len = s.Length;
            if (s == null || (len == 0)) return 0;

            Stack<int> stack = new Stack<int>();
            int num = 0;
            char sign = '+';

            for (int i = 0; i < len; i++)
            {
                // Convert string to num value , by subtracting from ascii 0
                if (Char.IsDigit(s[i]))
                {
                    num = num * 10 + (s[i] - '0');
                }

                if ((!Char.IsDigit(s[i])) && ' ' != s[i] || i == len - 1)
                {
                    if (sign == '-')
                    {
                        stack.Push(-num);
                    }
                    if (sign == '+')
                    {
                        stack.Push(num);
                    }
                    if (sign == '*')
                    {
                        stack.Push(stack.Pop() * num);
                    }
                    if (sign == '/')
                    {
                        stack.Push(stack.Pop() / num);
                    }
                    sign = s[i];
                    num = 0;
                }
            }

            int result = 0;
            while (stack.Count > 0)
            {
                result += stack.Pop();
            }
            return result;
        }
    }
}
