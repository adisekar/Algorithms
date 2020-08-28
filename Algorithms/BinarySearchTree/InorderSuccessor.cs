using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinarySearchTree
{
    public class InorderSuccessor
    {
        public static TreeNode FindSuccessor(TreeNode root, int target)
        {
            TreeNode targetNode = Search.SearchBSTIterative(root, target);
            TreeNode temp = null;
            // Case 1 : if Right is not null of node of which successor needs to be found
            // GO to left child of that node, to find least element
            if (targetNode.right != null)
            {
                temp = targetNode.right;
                while (temp.left != null)
                {
                    temp = temp.left;
                }
            }
            // Case 2 : if node does not have right subtree, search from root,
            // the node from where we take last left turn is answer
            else
            {
                TreeNode node = root;
                while (node.value != target)
                {
                    if (node.value > target)
                    {
                        // Store the value, before turing left. This will be node from
                        // where last left was taken
                        temp = node;
                        node = node.left;                     
                    }
                    else
                    {
                        node = node.right;
                    }
                }
            }
            return temp;
        }
    }
}
