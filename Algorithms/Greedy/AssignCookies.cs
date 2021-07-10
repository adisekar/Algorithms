using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Greedy
{
    public class AssignCookies
    {
        /*
         * Input: [1,2,3], [1,1]

Output: 1

Explanation: You have 3 children and 2 cookies. The greed factors of 3 children are 1, 2, 3. 
And even though you have 2 cookies, since their size is both 1, you could only make the child whose greed factor is 1 content.
You need to output 1.
        */
        public static int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);

            int i = g.Length - 1;
            int j = s.Length - 1;
            int count = 0;

            // Greedy soln, assign largest cookie s to greediest child, then move to next 
            while (i >= 0 && j >= 0)
            {
                if (s[j] >= g[i])
                {
                    i--;
                    j--;
                    count++;
                }
                else
                {
                    i--;
                }
            }
            return count;
        }
    }
}
