using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    public class Isomorphic
    {
        public static bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> map = new Dictionary<char, char>();

            if (s.Length != t.Length)
            {
                return false;
            }
            if (s.Length == 1)
            {
                return true;
            }
            HashSet<char> valueSet = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                {
                    map.Add(s[i], t[i]);
                    if (!valueSet.Contains(t[i]))
                    {
                        valueSet.Add(t[i]);
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (map[s[i]] != t[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
