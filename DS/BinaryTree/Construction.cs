using System;
using System.Collections.Generic;
using System.Text;

namespace DS.BinaryTree
{
    public class Construction
    {
        public static TreeNode CreateTree(int[] array)
        {
            if (array.Length == 0)
            {
                return null;
            }

            TreeNode root = InsertLevelOrder(null, array, 0);
            return root;
        }

        public static TreeNode InsertLevelOrder(TreeNode root, int[] array, int i)
        {
            // Base case for recursion
            if (i < array.Length)
            {
                TreeNode temp = new TreeNode(array[i]);
                root = temp;
                if (i * 2 + 1 < array.Length)
                {
                    root.left = InsertLevelOrder(root, array, i * 2 + 1);
                }
                if (i * 2 + 2 < array.Length)
                {
                    root.right = InsertLevelOrder(root, array, i * 2 + 2);
                }
            }
            return root;
        }
    }
}
