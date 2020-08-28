using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree
{
    public class GetParent
    {
        public static Dictionary<int, int> GetNodeParentMap(TreeNode root)
        {
            Dictionary<int, int> nodeParentMap = new Dictionary<int, int>();
            Preorder(root, nodeParentMap, null);

            return nodeParentMap;

        }
        private static void Preorder(TreeNode root, Dictionary<int, int> nodeParentMap, TreeNode prev)
        {
            if (root == null || root.value == -1)
            {
                return;
            }

            if (root.value != -1 && !nodeParentMap.ContainsKey(root.value))
            {
                nodeParentMap.Add(root.value, prev != null ? prev.value : -1);
            }
            
            prev = root;
            Preorder(root.left, nodeParentMap, prev);
            Preorder(root.right, nodeParentMap, prev);
        }
    }
}
