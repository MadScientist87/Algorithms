using System;
using System.Collections.Generic;
using Algorithms.Easy;

namespace Algorithms.Trees
{
    public static class PrintTreeClass
    {
        private static int height;
        private static List<IList<string>> res;
        public static IList<IList<string>> PrintTree(TreeNode root)
        {
            height = GetHeight(root);
            int N = (1 << height) - 1;
            res = new List<IList<string>>();

            for (int i = 0; i < height; i++)
            {
                List<string> lst = new List<string>();
                for (int k = 0; k < N; k++)
                {
                    lst.Add("");
                }
                res.Add(lst);
            }

            dfs(root, 0, N - 1, 0);

            return res;
        }


        private static void dfs(TreeNode root, int left, int right, int level)
        {
            if (root == null)
            {
                return;
            }
            IList<string> curr = res[level];
            int mid = (left + right) / 2;
            curr[mid] = $"{root.val}";
            dfs(root.left, left, mid, level + 1);
            dfs(root.right, mid + 1, right, level + 1);
        }

        public static int GetHeight(TreeNode root)
        {
            if (root == null)
                return 0;
            return 1 + Math.Max(GetHeight(root.left), GetHeight(root.right));
        }
    }
}
