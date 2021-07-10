using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree.Traversal.Iterative
{
    public class Postorder
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            Stack<StackTreeNode> stack = new Stack<StackTreeNode>();
            TreeNode node = root;

            while (node != null || stack.Count > 0)
            {
                if (node != null)
                {

                    stack.Push(new StackTreeNode(node, false));
                    node = node.left;
                }
                else
                {
                    StackTreeNode temp = stack.Pop();
                    // Need additional flg on stack to say if it is to go to right node, or to print current node
                    // as we will be adding to stack twice.
                    if (!temp.forPrint)
                    {
                        stack.Push(new StackTreeNode(temp.node, true));
                        node = temp.node.right;
                    }
                    else
                    {
                        if (temp.node != null)
                        {
                            result.Add(temp.node.value);
                        }
                        node = null;
                    }
                }
            }

            return result;
        }
    }

    public class StackTreeNode
    {
        public TreeNode node { get; set; }
        public bool forPrint { get; set; }

        public StackTreeNode(TreeNode node, bool print)
        {
            this.node = node;
            this.forPrint = print;
        }
    }
}
