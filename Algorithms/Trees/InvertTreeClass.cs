using System;
using System.Collections.Generic;
using Algorithms.Easy;

namespace Algorithms.Trees
{
    public static class InvertTreeClass
    {
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;
            TreeNode left = InvertTree(root.left);
            TreeNode right = InvertTree(root.right);

            root.left = right;
            root.right = left;

            return root;
        }

        public static TreeNode InvertTreeIterative(TreeNode root)
        {
            if (root == null)
                return null;

            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while(queue.Count != 0)
            {
                TreeNode curr = queue.Dequeue();
                TreeNode temp = curr.left;
                curr.left = curr.right;
                curr.right = temp;

                if (curr.left != null) queue.Enqueue(curr.left);
                if (curr.right != null) queue.Enqueue(curr.right);
            }

            return root;
        }
    }
}
