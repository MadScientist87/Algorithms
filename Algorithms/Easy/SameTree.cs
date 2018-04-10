using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Easy
{
    public class SameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            return Comparetrees(p, q);
        }
        bool Comparetrees(TreeNode node, TreeNode q, bool issame = true)
        {
            if(!issame)
                return false;
            if (node == null && q !=null)
                return false;

            if (node != null && q == null)
                return false;

            if (node == null && q == null)
                return issame;

            issame = node?.val == q?.val;

            /* then recur on left sutree */
            issame = Comparetrees(node.left, q.left, issame);


            /* now recur on right subtree */
            issame = Comparetrees(node.right, q.right, issame);

            return issame;
        }

        // Smaller solution without extra variable
        public bool isSameTree(TreeNode p, TreeNode q)
        {
            //Base cases
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            
            // After calls are placed on the stack once a false is fired by our base cases
            // the false is returned up the call stack
            if (p.val == q.val)
                return isSameTree(p.left, q.left) && isSameTree(p.right, q.right);
            return false;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
