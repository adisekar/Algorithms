using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    public class Rotation
    {
        // s1 = waterbottle, s2 = erbottlewat. Output is true
        public static bool IsRotation(string s1, string s2)
        {
            if (s1.Length == s2.Length)
            {
                // Add s1 + s1 = waterbottlewaterbottle
                string s1s1 = s1 + s1;
                var result = s1s1.Substring(s1s1.IndexOf(s2));
                return result.Length > 0 ? true : false;
            }
            return false;
        }
    }
}
