using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.BinaryTree;
using System;
using DS;
using Algorithms.BinarySearchTree;
using Algorithms.BinarySearchTree.Construct;

namespace Algorithms.Test
{
    [TestClass]
    public class BinarySearchTree
    {
        [TestMethod]
        public void BSTConstruction()
        {
            int[] array = { 12, 18, 12, 1, 3, 20, 17, 19 };
            var root = Construction.CreateTree(array);

            Console.WriteLine("Pre-order traversal");
            DepthFirstSearch.PreOrder(root);

            Console.WriteLine("In-order traversal");
            DepthFirstSearch.InOrder(root);

            Console.WriteLine("Post-order traversal");
            DepthFirstSearch.PostOrder(root);
        }

        [TestMethod]
        public void FindInorderSuccessor()
        {
            int[] array = { 16, 14, 40, 35, 45, 32, 36, 30, 37, 10, 15 };
            var root = Construction.CreateTree(array);

            var result = InorderSuccessor.FindSuccessor(root, 16);
            Assert.AreEqual(30, result.value);

            var result2 = InorderSuccessor.FindSuccessor(root, 40);
            Assert.AreEqual(45, result2.value);

            var result3 = InorderSuccessor.FindSuccessor(root, 37);
            Assert.AreEqual(40, result3.value);

            var result4 = InorderSuccessor.FindSuccessor(root, 15);
            Assert.AreEqual(16, result4.value);
        }

        [TestMethod]
        public void FindClosest()
        {
            int[] array = { 10, 5, 15, 2, 5, 1, 13, 22, 14 };
            var root = Construction.CreateTree(array);

            var result = ClosestValue.FindClosestValueRecursive(root, 17);
            Assert.AreEqual(15, result);

            var result2 = ClosestValue.FindClosestValueIterative(root, 17);
            Assert.AreEqual(15, result2);
        }

        [TestMethod]
        public void RangeSumBST()
        {
            int[] array = { 10, 5, 15, 3, 7, -1, 18 };
            var root = Construction.CreateTree(array);
            int L = 7;
            int R = 15;
            var result = RangeSum.RangeSumBST(root, L, R);
            Assert.AreEqual(32, result);
        }

        [TestMethod]
        public void KthSmallestElement()
        {
            //int[] array = { 3, 1, 4, -1, 2 };
            int[] array = { 1, -1, 2 };
            var root = Construction.CreateTree(array);
            int k = 2;
            var result = KthSmallest.KthSmallestElement(root, k);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void BSTFromPreorderTraversal()
        {
            int[] A = { 8, 5, 1, 7, 10, 12 };
            BSTFromPreorder bst = new BSTFromPreorder();
            var root = bst.BstFromPreorderRecursive(A);

            DepthFirstSearch.PreOrder(root);

        }

        [TestMethod]
        public void ValidateBST()
        {
            int[] array = { 5, 1, 4, -1, -1, 3, 6 };
            var root = Construction.CreateTree(array);
            ValidBST bst = new ValidBST();

            var result = bst.IsValidBST(root);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void FindTwoSumBST()
        {
            int[] array = { 5, 3, 6, 2, 4, -1, 7 };
            int target = 9;
            var root = Construction.CreateTree(array);
            bool result = TwoSumBST.FindTargetBFS(root, target);
            Assert.AreEqual(true, result);
        }
    }
}
