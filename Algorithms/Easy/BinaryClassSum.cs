using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Easy
{
    public class BinaryClassSum
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
                return false;
            sum -= root.val;
            if (root.left == null && root.right == null)
            {
                if (sum == 0)
                    return true;
                return false; // Allows for direct return when both the left and right nodes are null. More efficient. 
            }
            return HasPathSum(root.left, sum) || HasPathSum(root.right, sum);
        }
    }
}
