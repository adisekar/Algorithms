using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree.N_ary.Traversals
{
    public class PreOrder
    {
        public IList<int> PreorderTraversal(Node root)
        {
            var result = new List<int>();
            DFS(root, result);
            return result;
        }

        public void DFS(Node root, List<int> result)
        {
            if (root == null)
            {
                return;
            }
            result.Add(root.val);
            foreach (var child in root.children)
            {
                DFS(child, result);
            }
        }
    }
}
