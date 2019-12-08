using System;
using System.Collections.Generic;
using Algorithms.Easy;

namespace Algorithms.Trees
{
    public static class LowestCommonAncestorClass
    {
        private static TreeNode ans;
        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || (root.val == p.val || root.val == q.val)) return root;

            var leftSearch = LowestCommonAncestor(root.left, p, q);
            var rightSearch = LowestCommonAncestor(root.right, p, q);

            if (leftSearch == null) return rightSearch;
            if (rightSearch == null) return leftSearch;

            return root;
        }

        public static TreeNode LowestCommonAncestorIterative(TreeNode root, TreeNode p, TreeNode q)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            Dictionary<TreeNode, TreeNode> parent = new Dictionary<TreeNode, TreeNode>();

            stack.Push(root);
            parent.Add(root, null);
            while (!parent.ContainsKey(p) || !parent.ContainsKey(q))
            {
                TreeNode node = stack.Pop();

                if (node.left != null)
                {
                    stack.Push(node.left);
                    parent.Add(node.left, node);
                }

                if (node.right != null)
                {
                    stack.Push(node.right);
                    parent.Add(node.right, node);
                }
            }

            HashSet<TreeNode> ancestors = new HashSet<TreeNode>();

            while(p!=null)
            {
                ancestors.Add(p);
                p = parent.GetValueOrDefault(p);
            }

            while (!ancestors.Contains(q))
            {
                q = parent.GetValueOrDefault(q);
            }

            return q;
        }

        public static int MissingNumber(int[] nums)
        {
            HashSet<int> numSet = new HashSet<int>(nums);

            int expectedNumCount = nums.Length + 1;
            for (int number = 0; number < expectedNumCount; number++)
            {
                if (!numSet.Contains(number))
                {
                    return number;
                }
            }
            return -1;
        }
    }
}
