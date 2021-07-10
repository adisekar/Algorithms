using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public class RescueBoats
    {
        public static int NumRescueBoats(int[] people, int limit)
        {
            Array.Sort(people);
            int minBoats = 0;

            int i = 0;
            int j = people.Length - 1;

            while (i <= j)
            {
                if (people[i] + people[j] <= limit)
                {
                    i++;
                    j--;
                }
                else
                {
                    j--;
                }
                minBoats++;
            }
            return minBoats;
        }
    }
}
