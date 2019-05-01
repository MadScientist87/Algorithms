using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Easy
{
    public class MinimumDepthOfTree
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            if (root.left == null && root.right == null)
            {
                return 1;
            }

            // If left subtree is NULL, recur for right subtree  
            if (root.left == null)
            {
                return MinDepth(root.right) + 1;
            }

            // If right subtree is NULL, recur for left subtree  
            if (root.right == null)
            {
                return MinDepth(root.left) + 1;
            }

            return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;

        }
    }
}
