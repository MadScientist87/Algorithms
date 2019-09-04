using System;
using Algorithms.Easy;

namespace Algorithms.Amazon.AmazonOnlineAssessment
{
    public class MaximumAverageSubtreeClass
    {
        private double max = 0;
        public double MaximumAverageSubtree(TreeNode root)
        {
            int[] arr = BFS(root);
            return max;
        }

        public int[] BFS(TreeNode root)
        {
            if (root == null) return new int[] { 0, 0 };
            var right = BFS(root.right);
            var left = BFS(root.left);

            var sum = right[0] + left[0] + root.val;
            var count = right[1] + left[1] + 1;

            max = Math.Max(max, (double)sum / (double)count);
            return new int[] { sum, count };
        }

    }
}
