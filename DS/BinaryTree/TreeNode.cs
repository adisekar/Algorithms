using System;
using System.Collections.Generic;
using System.Text;

namespace DS.BinaryTree
{
    public class TreeNode
    {
        public int value { get; set; }
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }
        
        // Constructor option as default is left and child will be null 
        public TreeNode(int val = -1, TreeNode left = null, TreeNode right = null)
        {
            this.value = val;
            this.left = left;
            this.right = right;
        }
    }
}
