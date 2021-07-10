using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Stack
{
    public class BackspaceStringCompare
    {
        public static bool BackspaceCompare(string S, string T)
        {
            Stack<char> s1 = new Stack<char>();
            Stack<char> s2 = new Stack<char>();

            foreach (var c in S)
            {
                if (c == '#')
                {
                    if (s1.Count > 0)
                    {
                        s1.Pop();
                    }
                }
                else
                {
                    s1.Push(c);
                }
            }

            foreach (var c in T)
            {
                if (c == '#')
                {
                    if (s2.Count > 0)
                    {
                        s2.Pop();
                    }
                }
                else
                {
                    s2.Push(c);
                }
            }
            if (s1.Count != s2.Count)
            {
                return false;
            }

            while (s1.Count > 0 && s2.Count > 0)
            {
                if (s1.Pop() != s2.Pop())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
