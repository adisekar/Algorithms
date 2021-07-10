using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree
{
    /*
     Input: root = [1,2,3,4,5,6,7], to_delete = [3,5]
Output: [[1,2,null,4],[6],[7]]
     */
    public class DeleteNodesAndReturnForest
    {
        public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
        {
            HashSet<int> toDeleteNodes = new HashSet<int>();
            IList<TreeNode> result = new List<TreeNode>();
            foreach (int node in to_delete)
            {
                toDeleteNodes.Add(node);
            }
            // Bottom up recusrion, go all way down, then when coming back up, do logic
            DelNodesDFS(root, toDeleteNodes, result);
            // IF set does not contain root, then add root to result
            if (!toDeleteNodes.Contains(root.value))
            {
                result.Add(root);
            }

            return result;
        }

        public TreeNode DelNodesDFS(TreeNode root, HashSet<int> toDeleteNodes, IList<TreeNode> result)
        {
            // Base case
            if (root == null)
            {
                return null;
            }

            root.left = DelNodesDFS(root.left, toDeleteNodes, result);
            root.right = DelNodesDFS(root.right, toDeleteNodes, result);

            if (toDeleteNodes.Contains(root.value))
            {
                if (root.left != null)
                {
                    result.Add(root.left);
                }
                if (root.right != null)
                {
                    result.Add(root.right);
                }
                // return null to remove that node, since it is in set
                return null;
            }
            else
            {
                return root;
            }

        }
    }
}
