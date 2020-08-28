using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree.N_ary.Traversals
{
    public class PostOrder
    {
        public IList<int> PostorderTraversal(Node root)
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
            foreach (var child in root.children)
            {
                DFS(child, result);
            }
            result.Add(root.val);
        }
    }
}
