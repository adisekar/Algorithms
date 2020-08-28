using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Stack
{
    public class ValidParenthesis
    {
        public static bool IsValid(string s)
        {
            Dictionary<char, char> map = new Dictionary<char, char>();
            map.Add(')', '(');
            map.Add('}', '{');
            map.Add(']', '[');

            Stack<char> stack = new Stack<char>();

            HashSet<char> set = new HashSet<char>();
            set.Add('(');
            set.Add('{');
            set.Add('[');

            foreach (var c in s)
            {
                if (set.Contains(c))
                {
                    stack.Push(c);
                }
                else if (map.ContainsKey(c))
                {
                    if (stack.Count > 0)
                    {
                        var current = stack.Pop();
                        if (current != map[c])
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0 ? true : false;
        }
    }
}
