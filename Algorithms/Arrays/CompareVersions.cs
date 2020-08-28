using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public class CompareVersions
    {
        public int CompareVersion(string version1, string version2)
        {
            string[] nums1 = version1.Split('.');
            string[] nums2 = version2.Split('.');
            int n1 = nums1.Length;
            int n2 = nums2.Length;

            // compare versions
            // If any number is larger, we can return immediately
            int i1, i2;
            for (int i = 0; i < Math.Max(n1, n2); i++)
            {
                i1 = i < n1 ? int.Parse(nums1[i]) : 0;
                i2 = i < n2 ? int.Parse(nums2[i]) : 0;
                if (i1 != i2)
                {
                    return i1 > i2 ? 1 : -1;
                }
            }
            // the versions are equal
            return 0;
        }
    }
}
