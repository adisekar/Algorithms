using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algorithms.SegmentTree;
using System;

namespace Algorithms.Test
{
    [TestClass]
    public class SegmentTree
    {
        /*
         Input
["NumArray", "sumRange", "sumRange", "sumRange"]
[[[-2, 0, 3, -5, 2, -1]], [0, 2], [2, 5], [0, 5]]
Output
[null, 1, -1, -3]

Explanation
NumArray numArray = new NumArray([-2, 0, 3, -5, 2, -1]);
numArray.sumRange(0, 2); // return 1 ((-2) + 0 + 3)
numArray.sumRange(2, 5); // return -1 (3 + (-5) + 2 + (-1)) 
numArray.sumRange(0, 5); // return -3 ((-2) + 0 + 3 + (-5) + 2 + (-1))
         */
        [TestMethod]
        public void Immutable_RangeSumQuery()
        {
            int[] nums = { -2, 0, 3, -5, 2, -1 };
            RangeSumQuery_Immutable query = new RangeSumQuery_Immutable(nums);
            int result1 = query.SumRange(0, 2);
            int result2 = query.SumRange(2, 5); 
            int result3 = query.SumRange(0, 5);

            Assert.AreEqual(1, result1);
            Assert.AreEqual(-1, result2);
            Assert.AreEqual(-3, result3);
        }       
    }
}
