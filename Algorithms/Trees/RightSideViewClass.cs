using System;
using System.Collections.Generic;
using Algorithms.Easy;

namespace Algorithms.Trees
{
    public static class RightSideViewClass
    {
        public static IList<int> RightSideView(TreeNode root)
        {
            // Keep track of individual nodes
            Stack<TreeNode> stacknode = new Stack<TreeNode>();
            // Keep track of depth or current height of tree at particular node 
            Stack<int> stackdepth = new Stack<int>();

            // Dictionary to map depth to value that can be seen at that depth
            Dictionary<int, int> rightSideViewDepthKeeper = new Dictionary<int, int>();

            stacknode.Push(root);
            stackdepth.Push(0);

            while (stacknode.Count != 0)
            {
                var node = stacknode.Pop();
                var depth = stackdepth.Pop();

                if (node != null)
                {
                    if (!rightSideViewDepthKeeper.ContainsKey(depth))
                    {
                        rightSideViewDepthKeeper.Add(depth, node.val);
                    }

                    // Since this is a stack we always read the right before the left when the stack is popped
                    stacknode.Push(node.left);
                    stacknode.Push(node.right);
                    stackdepth.Push(depth + 1);
                    stackdepth.Push(depth + 1);
                }
            }

            List<int> answer = new List<int>();

            // Loop through the dictionary we built and grab the values visible at each depth
            for (int i = 0; i < rightSideViewDepthKeeper.Count; i++)
            {
                if (rightSideViewDepthKeeper.ContainsKey(i))
                {
                    answer.Add(rightSideViewDepthKeeper.GetValueOrDefault(i));
                }
            }

            return answer;

        }

    }
}
