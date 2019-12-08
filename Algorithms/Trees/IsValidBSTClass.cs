using System;
using System.Collections.Generic;
using Algorithms.Easy;

namespace Algorithms.Trees
{
    public static class IsValidBSTClass
    {
        // This uses an inorder traversal where we push left first and place items on the stack
        // then we set the inorder which will be our upperbound to check to see if the left node is less than
        // the subtrees above it
        public static bool IsValidBST(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            double inOrder = -double.MaxValue;

            while (root != null || stack.Count != 0)
            {

                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }

                root = stack.Pop();
                if (root.val <= inOrder) return false;
                inOrder = root.val;
                root = root.right;
            }
            return true;
        }

        public static bool IsValidBSTRecursive(TreeNode root)
        {
            return Helper(root, null, null);
        }

        private static bool Helper(TreeNode root, int? lower, int? upper)
        {
            if (root == null) return true;
            if (lower != null && root.val <= lower) return false;
            if (upper != null && root.val >= upper) return false;

            if (!Helper(root.right, root.val, upper)) return false;
            if (!Helper(root.left, lower, root.val)) return false;

            return true;
        }
    }
}
