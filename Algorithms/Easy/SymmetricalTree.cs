using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Easy
{
    public class SymmetricalTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            return isMirror(root.left, root.right);
        }

        public bool isMirror(TreeNode p, TreeNode q)
        {
            //Base cases
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;

            // After calls are placed on the stack once a false is fired by our base cases
            // the false is returned up the call stack
            // I changed my function to compare left to right instead of comparing left to left or right to right
            if (p.val == q.val)
                return isMirror(p.left, q.right) && isMirror(p.right, q.left);
            return false;
        }

        public bool IsSymmetricIterative(TreeNode node)
        {
            var root = node;
            if (root == null) return true;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode left, right;
            if (root.left != null)
            {
                if (root.right == null) return false;
                stack.Push(root.left);
                stack.Push(root.right);
            }
            else if (root.right != null)
            {
                return false;
            }

            while (stack.Count != 0)
            {
                if (stack.Count % 2 != 0) return false;
                right = stack.Pop();
                left = stack.Pop();
                if (right.val != left.val) return false;

                if (left.left != null)
                {
                    if (right.right == null) return false;
                    stack.Push(left.left);
                    stack.Push(right.right);
                }
                else if (right.right != null)
                {
                    return false;
                }

                if (left.right != null)
                {
                    if (right.left == null) return false;
                    stack.Push(left.right);
                    stack.Push(right.left);
                }
                else if (right.left != null)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
