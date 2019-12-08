using System;
using System.Collections.Generic;
using Algorithms.Easy;

namespace Algorithms.Trees
{

    public static class InorderTraversalClass
    {
        static IList<int> answer = new List<int>();

        public static IList<int> InorderTraversal(TreeNode root)
        {
            InorderTraversalHelper(root);
            return answer;
        }

        public static void InorderTraversalHelper(TreeNode root)
        {
            if (root == null)
                return;

            InorderTraversalHelper(root.left);
            answer.Add(root.val);
            InorderTraversalHelper(root.right);
        }

        public static List<int> inorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();

            TreeNode curr = root;

            while(curr != null || stack.Count != 0)
            {
                while(curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }

                curr = stack.Pop();
                result.Add(curr.val);

                curr = curr.right;
            }

            return result;
        }
    }
}
