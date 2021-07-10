using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    class MoveZeroes
    {
        public void MoveZeroesToEnd(int[] nums)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[index] = nums[i];
                    index++;
                }
            }

            for (int i = index; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
