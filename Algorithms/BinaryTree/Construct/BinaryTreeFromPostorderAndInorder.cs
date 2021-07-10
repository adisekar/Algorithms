using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree.Construct
{
    /*
     * Input: inorder = [9,3,15,20,7], postorder = [9,15,7,20,3]
Output: [3,9,20,null,null,15,7]
    */

    public class BinaryTreeFromPostorderAndInorder
    {
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            return RecursiveHelper(postorder.Length - 1, 0, inorder.Length - 1, postorder, inorder);
        }

        public TreeNode RecursiveHelper(int postEnd, int inStart, int inEnd, int[] postorder, int[] inorder)
        {
            // Base case
            if (postEnd >= postorder.Length || inStart > inEnd)
            {
                return null;
            }

            TreeNode root = new TreeNode(postorder[postEnd]);
            int inIndex = 0;
            for (int i = inStart; i <= inEnd; i++)
            {
                if (inorder[i] == root.value)
                {
                    inIndex = i;
                    break;
                }
            }

            root.left = RecursiveHelper(postEnd + inIndex - inEnd - 1, inStart, inIndex - 1, postorder, inorder);
            root.right = RecursiveHelper(postEnd - 1, inIndex + 1, inEnd, postorder, inorder);

            return root;
        }
    }
}
