using System;
using System.Collections.Generic;
using Algorithms.Easy;

namespace Algorithms.Trees
{
    public static class PrintTreeOnOwn
    {
        private static IList<IList<string>> res;
        private static int height;
        public static IList<IList<string>> PrintTree(TreeNode root)
        {
            height = GetHeight(root);

            // Use bit manipulation to create length of inner list of string
            int N = (1 << height) - 1;

            res = new List<IList<string>>();

            //Build blank template of nested lists
            for(int i =0; i< height;i++)
            {
                List<string> innerList = new List<string>();
                for(int j=0; j< N; j++)
                {
                    innerList.Add("");
                }
                res.Add(innerList);
            }

            dfs(root, 0, N, 0);
            return res;
        }

        public static void dfs(TreeNode root, int left, int right, int level)
        {
            if (root == null)
                return;
            // Find midpoint of list and insert root value
            int mid = (right + left) / 2;
            IList<string> curr = res[level];
            curr[mid] = $"{root.val}";

            // Run recursive function against left half of list and right half of list
            dfs(root.left, left, mid ,level + 1);
            dfs(root.right, mid+1, right, level + 1);
        }


        public static int GetHeight(TreeNode root)
        {
            if (root == null)
                return 0;
            // Take the max of the longest node of the right or left of the tree
            return 1 + Math.Max(GetHeight(root.left), GetHeight(root.right));
        }
    }
}
