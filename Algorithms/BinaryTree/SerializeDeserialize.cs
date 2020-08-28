using DS.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree
{
    public class SerializeDeserialize
    {
        public class Codec
        {
            int i = 0;
            // Encodes a tree to a single string.
            public string serialize(TreeNode root)
            {
                if (root == null) return "null";
                return root.value + "," + serialize(root.left) + "," + serialize(root.right);
            }

            // Decodes your encoded data to tree.
            public TreeNode Deserialize(string data)
            {
                var dataArr = data.Split(',');

                return RecursiveDeserialize(dataArr);
            }

            public TreeNode RecursiveDeserialize(string[] dataArr)
            {
                var s = dataArr[i++];
                if (s == "null") return null;

                var node = new TreeNode(Convert.ToInt32(s));
                node.left = RecursiveDeserialize(dataArr);
                node.right = RecursiveDeserialize(dataArr);
                return node;
            }
        }

        // Your Codec object will be instantiated and called as such:
        // Codec codec = new Codec();
        // codec.deserialize(codec.serialize(root));
    }
}
