using System;
using System.Collections.Generic;
using Algorithms.Easy;

namespace Algorithms.Trees
{
    public class BFSTreeSearchClass
    {
        public List<int> result = new List<int>();

        public void LevelOrderTravesal(TreeNode node)
        {
            if (node == null)
                return;

            Queue<TreeNode> q = new Queue<TreeNode>();

            q.Enqueue(node);

            while (q.Count != 0)
            {
                node = q.Dequeue();
                result.Add(node.val);

                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }

        }

        public void ReverseLevelOrderTravesal(TreeNode node)
        {
            if (node == null)
                return;

            Queue<TreeNode> q = new Queue<TreeNode>();
            Stack<TreeNode> s = new Stack<TreeNode>();

            q.Enqueue(node);

            while (q.Count != 0)
            {
                node = q.Dequeue();

                s.Push(node);

                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }

            while (s.Count != 0)
            {
                result.Add(s.Pop().val);
            }
        }

        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            TreeNode node = root;

            if (node == null)
                return new List<IList<int>> { };

            Queue<TreeNode> q = new Queue<TreeNode>();
            // Use a stack to place are the codes at level order onto the stack
            // After th nodes are placed on the stack and the inner loop is done. 
            // Pop the values off the stack and place them onto the queue - they will now be in the reverse order.
            Stack<TreeNode> zigzag = new Stack<TreeNode>();
            int level = 0;
            q.Enqueue(node);
            var order = true;

            List<IList<int>> answerResult = new List<IList<int>>();
            while (true)
            {
                List<int> currentNodes = new List<int>();

                // Reset NodeCount for current items in the queue
                int nodeCount = q.Count;
                if (nodeCount == 0)
                    break;
                level++;
                while (nodeCount > 0)
                {
                    node = q.Dequeue();
                    currentNodes.Add(node.val);

                    if (order)
                    {
                        if (node.left != null) zigzag.Push(node.left);
                        if (node.right != null) zigzag.Push(node.right);
                    }
                    else
                    {
                        if (node.right != null) zigzag.Push(node.right);
                        if (node.left != null) zigzag.Push(node.left);
                    }
                    nodeCount--;
                }
                answerResult.Add(currentNodes);

                while (zigzag.Count != 0) q.Enqueue(zigzag.Pop());

                order = !order;
            }

            return answerResult;
        }
    }
}
