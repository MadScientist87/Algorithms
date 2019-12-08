using System;
using System.Collections.Generic;
using Algorithms.Easy;

namespace Algorithms.Trees
{
    public static class SortedListToBSTClass
    {
        static List<int> sortedList = new List<int>();
        public static TreeNode SortedListToBST(ListNode head)
        {
            ConvertLinkedListToAray(head);
            var node = BuildTree(0, sortedList.Count-1);

            return node;
        }


        public static TreeNode BuildTree(int left, int right)
        {
            if (left > right )
                return null;

            

            int mid = (left + right) / 2;

            TreeNode node = new TreeNode(sortedList[mid]);
            

            node.left = BuildTree(left, mid - 1);
            node.right = BuildTree(mid + 1, right);
            return node;
        }


        public static List<int> ConvertLinkedListToAray(ListNode head)
        {
            while (head != null)
            {
                if (head != null)
                {
                    sortedList.Add(head.val);
                    head = head.next;
                }
            }
            return sortedList;
        }
    }
}
