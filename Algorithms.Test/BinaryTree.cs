using Algorithms.BinaryTree;
using Algorithms.BinaryTree.Flatten;
using Algorithms.BinaryTree.Traversal;
using DS.BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Test
{
    [TestClass]
    public class BinaryTree
    {
        [TestMethod]
        public void BTConstruction()
        {
            // Use -1 for null
            int[] array = { 3, 5, 1, 6, 2, 0, 8, -1, -1, 7, 4 };
            var root = Construction.CreateTree(array);

            Console.WriteLine("Pre-order traversal");
            DepthFirstSearch.PreOrder(root);

            Console.WriteLine("In-order traversal");
            DepthFirstSearch.InOrder(root);

            Console.WriteLine("Post-order traversal");
            DepthFirstSearch.PostOrder(root);
        }

        [TestMethod]
        public void BTtoDLinkedListusingInorder()
        {
            // Use -1 for null
            int[] array = { 1, 2, 5, 3, 4, -1, 6 };
            var root = Construction.CreateTree(array);

            Console.WriteLine("Pre-order traversal");
            DepthFirstSearch.PreOrder(root);

            Console.WriteLine("In-order traversal");
            DepthFirstSearch.InOrder(root);

            Console.WriteLine("Post-order traversal");
            DepthFirstSearch.PostOrder(root);

            BTtoDLinkedListInOrder bTtoDoublyLinkedList = new BTtoDLinkedListInOrder();
            var head = bTtoDoublyLinkedList.Flatten(root);

            // Only In Order can be done by this approach

            Console.WriteLine("Linked List");
            while (head != null)
            {
                Console.WriteLine(head.value);
                head = head.right;
            }
        }

        [TestMethod]
        public void BTtoDLinkedListUsingBFS()
        {
            // Use -1 for null
            int[] array = { 1, 2, 5, 3, 4, -1, 6 };
            var root = Construction.CreateTree(array);

            var head = BTtoDLinkedListBFS.FlattenTree(root);
            Console.WriteLine("Linked List");
            while (head != null)
            {
                Console.WriteLine(head.value);
                head = head.right;
            }

            var head2 = BTtoDLinkedListBFS.FlattenTreeInPlace(root);
            Console.WriteLine("Linked List");
            while (head2 != null)
            {
                Console.WriteLine(head2.value);
                head2 = head2.right;
            }
        }

        [TestMethod]
        public void GetParentMap()
        {
            int[] array = { 3, 5, 1, 6, 2, 0, 8, -1, -1, 7, 4 };
            var root = Construction.CreateTree(array);

            var result = GetParent.GetNodeParentMap(root);
        }

        [TestMethod]
        public void MinDepth()
        {
            int[] array = { 3, 9, 20, -1, -1, 15, 7 };
            var root = Construction.CreateTree(array);

            var result = Height.MinDepth(root);
            Assert.AreEqual(2, result);

            // Height for this case is 2, as height is shortest path
            // of leaves, and root cannot have null as child.
            int[] array2 = { 1, 2 };
            var root2 = Construction.CreateTree(array2);

            var result2 = Height.MinDepth(root2);
            Assert.AreEqual(2, result2);
        }

        [TestMethod]
        public void IsBalanced()
        {
            int[] array = { 1, 2, 2, 3, -1, -1, 3, 4, -1, -1, 4 };
            var root = Construction.CreateTree(array);

            var result = IsBalancedTree.IsBalanced(root);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void KDistanceNodes()
        {
            int[] array = { 3, 5, 1, 6, 2, 0, 8, -1, -1, 7, 4 };
            var root = Construction.CreateTree(array);
            // Using parent hashtable
            TreeNode target = SearchTree.FindTargetNode(root, 5);
            var result = KDistance.DistanceK(root, target, 2);
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Converting Tree to Undirected Graph");
            // using conversion to Adjacency matrix
            var result2 = KDistance.DistanceKUsingGraph(root, target, 2);
            foreach (var num in result2)
            {
                Console.WriteLine(num);
            }
        }

        [TestMethod]
        public void FindTargetNode()
        {
            int[] array = { 16, 14, 40, 35, 45, 32, 36, 30, 37, 10, 15 };
            var root = Construction.CreateTree(array);

            var result = SearchTree.FindTargetNode(root, 45);
            Assert.AreEqual(45, result.value);
        }

        [TestMethod]
        public void ConvertToGraphMatrix()
        {
            int[] array = { 3, 5, 1, 6, 2, 0, 8, -1, -1, 7, 4 };
            var root = Construction.CreateTree(array);

            int[,] matrix = ConvertToGraph.AdjacencyMatrixGraph(root);
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        [TestMethod]
        public void CountNodesInTree()
        {
            int[] array = { 3, 5, 1, 6, 2, 0, 8, -1, -1, 7, 4 };
            var root = Construction.CreateTree(array);
            var result = CountNodes.Count(root);
            Assert.AreEqual(9, result);

            var result2 = CountNodes.CountIterative(root);
            Assert.AreEqual(9, result2);
        }

        [TestMethod]
        public void InvertTreeToMirror()
        {
            int[] array = { 4, 2, 7, 1, 3, 6, 9 };
            var root = Construction.CreateTree(array);

            DepthFirstSearch.InOrder(root);
            Console.WriteLine("Reversed InOrder based on Mirror BFS");
            InvertTree.InvertTreeToMirrorBFS(root);

            Console.WriteLine("-----------------");
            Console.WriteLine("Reversed InOrder based on Mirror DFS");
            InvertTree.InvertTreeRecursive(root);

            DepthFirstSearch.InOrder(root);
        }

        [TestMethod]
        public void SumTree()
        {
            int[] array = { 2, 4, 5 };
            var root = Construction.CreateTree(array);

            Console.WriteLine(SearchTree.Sum(root));

        }

        [TestMethod]
        public void HasPathSum()
        {
            int[] array = { 5, 4, 8, 11, 13, 4, 7, 2, 1 };
            var root = Construction.CreateTree(array);

            bool result = PathSum.HasPathSum(root, 20);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void HasPathSumStack()
        {
            int[] array = { 5, 4, 8, 11, 13, 4, 7, 2, 1 };
            var root = Construction.CreateTree(array);

            bool result = PathSum.HasPathSumStack(root, 20);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void PrintPathSum()
        {
            int[] array = { 5, 4, 8, 11, -1, 13, 4, 7, 2, -1, -1, -1, -1, 5, 1 };
            var root = Construction.CreateTree(array);

            var result = PathSum.PrintPaths(root, 22);
            foreach (var list in result)
            {
                foreach (var num in list)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine("");
            }
        }

        [TestMethod]
        public void PrintPathSumStack()
        {
            int[] array = { 5, 4, 8, 11, 13, 4, 7, 2, 1 };
            var root = Construction.CreateTree(array);

            var result = PathSum.PrintPathsStack(root, 20);
            foreach (var list in result)
            {
                foreach (var num in list)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine("");
            }
        }

        [TestMethod]
        public void SumRootToLeafNodes()
        {
            int[] array = { 1, 2, 3 };
            var root = Construction.CreateTree(array);

            var result = SumRootToLeaf.SumNumbers(root);
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void SumOfAllNodes()
        {
            int[] array = { 15, 10, 20, 8, 12, 16, 25 };
            var root = Construction.CreateTree(array);

            var result = Sum.SumOfAllNodes(root);
            Assert.AreEqual(106, result);
        }

        [TestMethod]
        public void IsSumTree()
        {
            int[] array = { 56, 13, 15, 5, 3, 9, 3, 3, 2, -1, -1, -1, -1, 2, 1 };
            var root = Construction.CreateTree(array);

            var result = Sum.IsSumTree(root);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ZigZagLevelOrderTraversal()
        {
            int[] array = { 3, 9, 20, -1, -1, 15, 7 };
            var root = Construction.CreateTree(array);

            var result = ZigZagSpiral.ZigzagLevelOrder(root);
            foreach (var list in result)
            {
                foreach (var num in list)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }

        [TestMethod]
        public void VerticalOrderTraversal()
        {
            int[] array = { 3, 9, 20, -1, -1, 15, 7 };
            var root = Construction.CreateTree(array);

            var result = VerticalOrder.VerticalTraversal(root);
            foreach (var list in result)
            {
                foreach (var num in list)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }

        [TestMethod]
        public void MaximumPathSum()
        {
            int[] array = { -10, 9, 20, -1, -1, 15, 7 };
            var root = Construction.CreateTree(array);

            var result = MaxPathSum.GetMaxPathSum(root);
            Assert.AreEqual(42, result);
        }
    }

}
