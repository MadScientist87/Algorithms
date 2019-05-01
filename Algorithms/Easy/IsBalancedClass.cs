using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Algorithms.Easy
{
    public class IsBalancedClass
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;
            int left_depth = GetHeight(root.left);
            int right_depth = GetHeight(root.right);
            if (Math.Abs(left_depth - right_depth) <= 1)
            {
                return IsBalanced(root.left) && IsBalanced(root.right);
            }

            return false;
        }

        public int GetHeight(TreeNode root)
        {
            if (root == null)
                return 0;
            return 1 + Math.Max(GetHeight(root.left),GetHeight(root.right));
        }
    }

   
}
