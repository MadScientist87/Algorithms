using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Easy
{
    public class DeleteDuplicatesNodes
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            var current = head;
            while (current != null)
            {
                // If current value == the next current value make current next assigned
                // to the node after the next node. This allows us to essentially delete the duplicate
                // else we move current to the next node

                if (current.val == current.next?.val)
                    current.next = current.next.next;
                else
                    current = current.next;
            }

            return head;
        }
    }
}
