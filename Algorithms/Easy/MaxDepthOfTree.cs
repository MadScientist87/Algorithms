using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Easy
{
    public class MaxDepthOfTree
    {
        // Recursive solution
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;

        }


        // Iterative using DFS
        public int MaxDepth2(TreeNode root)
        {
            int count = 0;
            if (root == null) return count;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var size = queue.Count;
                count++;
                for (var x = 0; x < size; x++)
                {
                    root = queue.Dequeue();
                    if (root.left != null) queue.Enqueue(root.left);
                    if (root.right != null) queue.Enqueue(root.right);
                }

            }

            return count;
        }
    }
}
