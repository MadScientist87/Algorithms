using System;
using System.Collections.Generic;
using Algorithms.Easy;

namespace Algorithms.Trees
{
    public class DFSTreeSearchClass
    {
        public List<int> result = new List<int>();

        public void InOrderTravesal(TreeNode node)
        {
            if (node == null)
                return;

            InOrderTravesal(node.left);
            result.Add(node.val);
            InOrderTravesal(node.right);
        }

        public void PreOrderTravesal(TreeNode node)
        {
            if (node == null)
                return;

            result.Add(node.val);
            PreOrderTravesal(node.left);
            PreOrderTravesal(node.right);
        }

        public void PostOrderTravesal(TreeNode node)
        {
            if (node == null)
                return;

            PostOrderTravesal(node.left);
            PostOrderTravesal(node.right);
            result.Add(node.val);

        }

        public void PreOrderTravesalIterative(TreeNode node)
        {
            if (node == null)
                return;

            Stack<TreeNode> s = new Stack<TreeNode>();

            s.Push(node);

            while (s.Count != 0)
            {
                TreeNode x = s.Pop();
                result.Add(x.val);

                if (x.right != null) s.Push(x.right);
                if (x.left != null) s.Push(x.left);

            }
        }

        public void InOrderTravesalIterative(TreeNode node)
        {
            if (node == null)
                return;

            Stack<TreeNode> s = new Stack<TreeNode>();

            while (s.Count != 0 || node != null)
            {
                if (node != null)
                {
                    s.Push(node);
                    node = node.left;
                }

                else
                {
                    node = s.Pop();
                    result.Add(node.val);

                    node = node.right;
                }
            }
        }

        public void PostOrderTravesalIterative(TreeNode node)
        {
            if (node == null)
                return;

            Stack<TreeNode> s = new Stack<TreeNode>();
            Stack<int> output = new Stack<int>();
            s.Push(node);

            while (s.Count != 0)
            {

                node = s.Pop();
                output.Push(node.val);
                if (node.left != null) s.Push(node.left);
                if (node.right != null) s.Push(node.right);
            }

            while (output.Count != 0)
            {
                result.Add(output.Pop());
            }
        }

    }
}
