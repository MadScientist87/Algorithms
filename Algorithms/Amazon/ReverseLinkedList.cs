using System;
using System.Collections.Generic;
using System.Text;
using Algorithms.Easy;

namespace Algorithms.Amazon
{
    public class ReverseLinkedList
    {
        public void FirstMethod()
        {
            ListNode list = new ListNode(1);
            var list2 = list.next = new ListNode(3);
            list2.next = new ListNode(5);

            list = ReverseList(list);
            PrintList(list);
        }

        public ListNode ReverseList(ListNode list)
        {
            ListNode prev = null, current = list, next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            list = prev;
            return list;
        }

        public void PrintList(ListNode list)
        {
            ListNode current = list;
            while (current != null)
            {
                Console.Write(current.val + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
