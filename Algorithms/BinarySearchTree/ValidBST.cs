﻿using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinarySearchTree
{
    public class ValidBST
    {
        public static bool IsValidBSTDFS(TreeNode root)
        {
            return ValidateDFS(root, null, null);
        }

        // Need to pass min and max, as subtree left may be lesser
        // than root value. Min/max let us have boundaries
        private static bool ValidateDFS(TreeNode root, int? min, int? max)
        {
            if (root == null)
            {
                return true;
            }
            else if (min != null && root.value <= min || max != null && root.value >= max)
            {
                return false;
            }
            else
            {
                return ValidateDFS(root.left, min, root.value) && ValidateDFS(root.right, root.value, max);
            }
        }

        // 2nd Approach, using Inorder sorted list in class level variable
        // Now going thru the list to find if list is in ascending order
        List<int> nodes = new List<int>();
        public bool IsValidBST(TreeNode root)
        {
            Validate(root);

            double prevValue = Double.MinValue;
            foreach (var node in nodes)
            {
                if (node > prevValue)
                {
                    prevValue = node;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public void Validate(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Validate(root.left);
            nodes.Add(root.value);
            Validate(root.right);
        }
    }
}
