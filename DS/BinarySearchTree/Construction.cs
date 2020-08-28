using DS.BinaryTree;
using System;
using System.Collections.Generic;

namespace DS
{
    public class Construction
    {
        public static TreeNode CreateTree(int[] array)
        {
            if (array.Length == 0)
            {
                return null;
            }

            TreeNode root = new TreeNode(array[0]);

            for (int i = 1; i < array.Length; i++)
            {
                Insert(array[i], root);
            }

            return root;
        }

        public static void Insert(int nodeVal, TreeNode root)
        {
            TreeNode node = root;
            TreeNode newNode = new TreeNode(nodeVal);

            while (true)
            {
                if(newNode.value < node.value)
                {
                    if (node.left != null)
                    {
                        node = node.left;
                    }
                    else
                    {
                        // If null, add new node to left
                        node.left = newNode;
                        break;
                    }
                }
                else if (newNode.value >= node.value)
                {
                    if (node.right != null)
                    {
                        node = node.right;
                    }
                    else
                    {
                        node.right = newNode;
                        break;
                    }
                }
            }
        }
    }
}
