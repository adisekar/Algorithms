using System;
using System.Collections.Generic;
using System.Text;

namespace DS.SegmentTree
{
    public class SegmentTreeCreation
    {
        // Global variable to keep track of sum. Can use static also
        private int sum = 0;

        public STNode Construction(int[] arr)
        {
            // Construct Tree with range values
            STNode root = Create(arr);
            Console.WriteLine("Segment tree created successfully");

            // Fill in node values bottom up
            return FillValuesRecursive(root, arr);
            //Console.WriteLine("Node values populated successfully");
        }

        public int FindRangeQuerySum(STNode root, Range queryRange)
        {
            FindRangeQuerySumRecursive(root, queryRange);
            return sum;
        }

        private void FindRangeQuerySumRecursive(STNode root, Range queryRange)
        {
            // Base case
            if (root == null)
            {
                return;
            }
            int val = CalculateRangeSubset(root, queryRange);
            switch (val)
            {
                case 1:
                    FindRangeQuerySumRecursive(root.left, queryRange);
                    FindRangeQuerySumRecursive(root.right, queryRange);
                    break;
                case 2:
                    sum += root.value;
                    break;
                case 3:
                    FindRangeQuerySumRecursive(root.left, queryRange);
                    FindRangeQuerySumRecursive(root.right, queryRange);
                    break;
                case 4:
                    sum += 0;
                    break;
                default:
                    break;
            }
        }

        private int CalculateRangeSubset(STNode root, Range queryRange)
        {
            // QR subset of NR
            if (root.range.start <= queryRange.start && root.range.end >= queryRange.end)
            {
                return 1;
            }
            else if (queryRange.start <= root.range.start && queryRange.end >= root.range.end)
            {
                return 2;
            }
            else if (queryRange.start <= root.range.end)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }

        // Formula for mid pt = (start + end)/2
        private STNode Create(int[] arr)
        {
            STNode rootNode = new STNode(new Range(0, arr.Length - 1));

            CreateSegmentTreeRecursive(rootNode);
            return rootNode;
        }

        private void CreateSegmentTreeRecursive(STNode node)
        {
            // Base case
            if (Math.Abs(node.range.end - node.range.start) == 0)
            {
                return;
            }

            int mid = (node.range.start + node.range.end) / 2;
            node.left = new STNode(new Range(node.range.start, mid));
            node.right = new STNode(new Range(mid + 1, node.range.end));

            CreateSegmentTreeRecursive(node.left);
            CreateSegmentTreeRecursive(node.right);
        }

        private STNode FillValuesRecursive(STNode node, int[] arr)
        {
            // Base case
            if (node == null)
            {
                return node;
            }

            STNode left = FillValuesRecursive(node.left, arr);
            STNode right = FillValuesRecursive(node.right, arr);

            // When leaf nodes
            if (left == null && right == null)
            {
                node.value = arr[node.range.end]; // Can use either start or end, as they mustbe equal at leaf node
            }
            else
            {
                int leftVal = left != null ? left.value : 0;
                int rightVal = right != null ? right.value : 0;
                node.value = leftVal + rightVal;
            }
            return node;
        }
    }
}
