using System;
using Algorithms.Easy;

namespace Algorithms.Medium
{
    public static class AddTwoNumbersLinkedList
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var x = l1;
            var y = l2;
            var carry = 0;
            ListNode dummynode = new ListNode(0);
            ListNode curr = dummynode;
            while (x != null || y != null)
            {
                var xValue = x != null ? x.val : 0;

                var yValue = y != null ? y.val : 0;

                var sum = carry + xValue + yValue;

                if (sum > 9)
                {
                    sum = sum % 10;
                    carry += 1;
                }

                curr.next = new ListNode(sum);
                curr = curr.next;
                if (x != null) x = x.next;
                if (y != null) y = y.next;

            }

            return dummynode.next;
        }


    }
}
