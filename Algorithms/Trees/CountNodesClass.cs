using System;
using Algorithms.Easy;

namespace Algorithms.Trees
{
    public static class CountNodesClass
    {
        public static int CountNodes(TreeNode root)
        {
            if (root == null)
                return 0;

            return 1 + CountNodes(root.left) + CountNodes(root.right);

        }
    }
}
