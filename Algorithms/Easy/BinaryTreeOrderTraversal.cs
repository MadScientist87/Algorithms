using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Easy
{
    public class BinaryTreeOrderTraversal
    {
        // DFS use queue to place left then right nodes then get info from queue
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> mainList = new List<IList<int>>();
            if (root == null) return mainList;
            Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var size = queue.Count;
                List<int> subList = new List<int>();

                for(var x=0;x< size;x++)
                {
                    root = queue.Dequeue();
                    subList.Add(root.val);
                    if (root.left != null) queue.Enqueue(root.left);
                    if (root.right != null) queue.Enqueue(root.right);
                }
              
                mainList.Insert(0, subList);
            }

            return mainList;
        }
    }
}
