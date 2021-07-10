using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DS.SegmentTree;

namespace DS.Test
{
    [TestClass]
    public class SegmentTree
    {
        [TestMethod]
        public void SegmentTreeConstruction()
        {
            int[] arr = { 5, 2, 1, 3, 4, 6, 7, 9, 8, 3 };
            SegmentTreeCreation segmentTree = new SegmentTreeCreation();
            STNode root = segmentTree.Construction(arr);

            DS.SegmentTree.Range queryRange = new DS.SegmentTree.Range(2, 8);
            int result = segmentTree.FindRangeQuerySum(root, queryRange);

            Assert.AreEqual(38, result);

            int[] arr2 = { -2, 0, 3, -5, 2, -1 };
            SegmentTreeCreation segmentTree2 = new SegmentTreeCreation();
            STNode root2 = segmentTree2.Construction(arr2);

            DS.SegmentTree.Range queryRange2 = new DS.SegmentTree.Range(2, 5);
            int result2 = segmentTree2.FindRangeQuerySum(root2, queryRange2);

            Assert.AreEqual(-1, result2);
        }
    }
}
