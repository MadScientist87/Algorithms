using System;
using System.Collections;
using System.Collections.Generic;
using Algorithms.Easy;

namespace Algorithms.Amazon
{
    public class AddTwoNumbersClass
    {
        //public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        //{
        //    var myStack = new Stack<TwoNumberDTO>();

        //    while (l1 != null || l2 != null)
        //    {
        //        var TwoNumberClass = new TwoNumberDTO
        //        {
        //            Val1 = l1 != null ? l1.val: 0,
        //            Val2 = l2 != null ? l2.val : 0
        //        };

        //        myStack.Push(TwoNumberClass);

        //        if(l1 != null)
        //        l1 = l1.next;
        //        if(l2 != null)
        //        l2 = l2.next;
        //    }
        //    var carry = 0;

        //    ListNode p, head = new ListNode(0);
        //    p = head;
        //    while (myStack.Count > 0)
        //    {
        //        var input = myStack.Pop();
        //        var total = (input.Val1 + input.Val2) + carry;
        //        if (total % 10 != total)
        //        {
        //            if (total == 10)
        //                carry = 1;
        //            else
        //                carry = total % 10;
        //            total = 0;
        //        }
        //        else
        //            carry = 0;
        //        p.next = new ListNode(total);
        //        p = p.next;


        //    }

        //    return head.next;
        //}

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode p, dummy = new ListNode(0);
            p = dummy;
            while (l1 != null || l2 != null || carry != 0)
            {
                if (l1 != null)
                {
                    carry += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    carry += l2.val;
                    l2 = l2.next;
                }
                p.next = new ListNode(carry % 10);
                carry /= 10;
                p = p.next;
            }
            return dummy.next;
        }


        public class TwoNumberDTO
        {
            public int Val1 { get; set; }
            public int Val2 { get; set; }
        }
    }
}
