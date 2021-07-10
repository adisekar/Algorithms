using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree.Construct
{
    // preorder = [3,9,20,15,7]
    // inorder = [9,3,15,20,7]
    public class BinaryTreeFromPreorderAndInorder
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return RecursiveHelper(0, 0, inorder.Length, preorder, inorder);
        }

        public TreeNode RecursiveHelper(int preStart, int inStart, int inEnd, int[] preorder, int[] inorder)
        {
            // Base case
            if (preStart >= preorder.Length || inStart >= inEnd)
            {
                return null;
            }

            TreeNode root = new TreeNode(preorder[preStart]);

            int inIndex = -1;
            for (int i = inStart; i < inEnd; i++)
            {
                if (inorder[i] == root.value)
                {
                    inIndex = i;
                    break;
                }
            }

            root.left = RecursiveHelper(preStart + 1, inStart, inIndex, preorder, inorder);
            root.right = RecursiveHelper(preStart + (inIndex - inStart) + 1, inIndex + 1, inEnd, preorder, inorder);
            return root;
        }
    }
}
