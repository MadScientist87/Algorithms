using System;
using System.Collections.Generic;
using Algorithms.Easy;

namespace Algorithms.Trees
{
    public static class MinDepthOfTreeClass
    {
        public static int MinDepth(TreeNode root)
        {
            if (root == null) return 0;

            if (root.left == null && root.right == null)
                return 1;

            if (root.left == null)
                return MinDepth(root.right) + 1;

            if (root.right == null)
                return MinDepth(root.left) + 1;

            return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;

        }

        public static int MinDepthIterative(TreeNode root)
        {
            int depth = 0;

            if (root == null) return depth;

            Queue<Tuple<TreeNode,int>> stack = new Queue<Tuple<TreeNode, int>>();

            stack.Enqueue(new Tuple<TreeNode, int>(root,1));
            

            while (stack.Count != 0)
            {
                var temp = stack.Dequeue();
                var node = temp.Item1;
                depth = temp.Item2;

                if (node.left == null && node.right == null) return depth;

                if (node.left != null)
                {
                    stack.Enqueue(new Tuple<TreeNode, int>(node.left, depth + 1));
                }
                if (node.right != null)
                {
                    stack.Enqueue(new Tuple<TreeNode, int>(node.right, depth + 1));
                }
            }

            return depth;
        }
    }
}
