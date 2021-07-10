using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BitManipulation
{
    public class BinaryGap
    {
        public int FindBinaryGap(int n)
        {
            string binary = Convert.ToString(n, 2);

            int result = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    for (int j = i + 1; j < binary.Length; j++)
                    {
                        if (binary[j] == '1')
                        {
                            result = Math.Max(j - i, result);
                            // Set i as j - 1, so loop adds 1 in every increment
                            i = j - 1;
                            break;
                        }
                    }
                }
            }
            return result;
        }
    }
}
